using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DnD.Rolls;
using IO;
using DnD.Objects;

namespace DnD
{
    public partial class Main : Form
    {
        private readonly string RollsCSVName = "rolls.csv";
        private readonly string SavingThrowsCSVName = "savingthrows.csv";
        private readonly string SkillsCSVName = "skills.csv";
        bool CustomRollsDirty = false;
        bool SavingThrowsDirty = false;
        bool SkillsDirty = false;

        public enum RollTypes
        {
            CustomRoll,
            SkillRoll,
            SavingThrowRoll
        }
        List<string> diceTBlist = new List<string>() { "d4RollNum", "d6RollNum", "d8RollNum", "d10RollNum", "d12RollNum", "d20RollNum" };
        List<string> validRolls = new List<string>() { "4", "6", "8", "10", "12", "20" };
        Random rollSeed = new Random();
        CustomRollForm CustomRollForm;
        DataTable RollTable;
        DataTable SavingThrowsTable;
        DataTable SkillsTable;

        public Main()
        {
            InitializeComponent();
        }
        private void clickManualRoll(object sender, EventArgs e)
        {
            Button dieButton = sender as Button;
            int dieValue = DieRegex.findDieValue(dieButton.Name); //get die value from button name
            ManualRoll(dieValue);
        }
        private void UnluckyTimerEvent(object sender, EventArgs e)
        {
            /*
            Invoke(new Action(() =>
           {
               pb_Unlucky.Enabled = false;
               pb_Unlucky.Visible = false;
           }));
           */
        }
        private void openListOfThings(object sender, EventArgs e)
        {
            openedItemsListBox.Items.Clear();
            string[] files = FileIO.openListOfThings();
            foreach (string file in files)
            {
                openedItemsListBox.Items.Add(file);
            }
        }
        private void ropenItemFromList(object sender, EventArgs e)
        {
            if (openedItemsListBox.SelectedItem != null)
            {
                //Console.WriteLine(openedItemsListBox.SelectedItem.ToString());
                FileIO.OpenFileWithDefault(openedItemsListBox.SelectedItem.ToString());
            }
            openedItemsListBox.ClearSelected();
        }
        private void OpenMap(object sender, EventArgs e)
        {
            OpenFileDialog openMap = new OpenFileDialog();
            var path = openMap.ShowDialog();
            mapBrowser.Navigate(openMap.FileName);
        }
        private void openFileBrowser(object sender, EventArgs e)
        {
            OpenFileDialog openMap = new OpenFileDialog();
            var path = openMap.ShowDialog();
            FileIO.OpenFileWithDefault(openMap.FileName);
        }
        #region DataGridView and DataTable Modification Methods
        private void ConfigureDataGridView(DataGridView dgv)
        {
            //Configure the DataTable
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToOrderColumns = true;
            dgv.MultiSelect = false;
            dgv.EditMode = DataGridViewEditMode.EditOnF2;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders; // Appears that this line should be `AllCells` to avoid the problem you are facing
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
        private void AddNewRollToTable(object sender, EventArgs e)
        {
            AddRowToTable();
        }
        private void AddRowToTable()
        {
            //This method is very poorly written/susceptible to breaking when/if more fields are added
            var parameters = CustomRollForm.GetRollParameters();

            DataRow RollRow = RollTable.NewRow();
            //  var fields = parameters.NumberOfFields;
            RollRow[0] = parameters.RollName;
            RollRow[1] = parameters.RollString;
            RollRow[2] = parameters.Description;
            RollTable.Rows.Add(RollRow);

            CustomRollForm.Dispose();
        }

        #endregion
        #region Load/Save Methods 
        private void LoadSettings(object sender, EventArgs e)
        {
            LoadCharacterSettings();
            LoadSavingThrows();
            LoadSkills();
            LoadCustomRolls();
        }

        private void LoadCharacterSettings()
        {
            tb_charName.Text = Properties.Settings.Default.ss_charName;
            tb_charHPcurr.Text = Properties.Settings.Default.ss_charHPcurr;
            tb_charHPmax.Text = Properties.Settings.Default.ss_charHPmax;
            tb_charAC.Text = Properties.Settings.Default.ss_charAC;
        }
        private void LoadSavingThrows()
        {
            try
            {
                SavingThrowsTable = LoadTable(SavingThrowsCSVName);
            }
            catch (FileNotFoundException)
            {
                return;
            }
            ConfigureDataGridView(DGV_SavingThrows);
            DGV_SavingThrows.DataSource = SavingThrowsTable;
        }
        private void LoadSkills()
        {
            try
            {
                SkillsTable = LoadTable(SkillsCSVName);
            }
            catch (FileNotFoundException)
            {
                return;
            }
            ConfigureDataGridView(DGV_Skills);
            DGV_Skills.DataSource = SkillsTable;
        }
        private void LoadCustomRolls()
        {
            try
            {
                RollTable = LoadTable(RollsCSVName);
            }
            catch (FileNotFoundException)
            {
                return;
            }
            ConfigureDataGridView(DGV_Rolls);
            DGV_Rolls.DataSource = RollTable;
        }
        static DataTable LoadTable(string csvName)
        {
            var systemPath = System.Environment.
                 GetFolderPath(
                     Environment.SpecialFolder.CommonApplicationData
                 );
            var complete = Path.Combine(systemPath, csvName);

            var data = FileIO.LoadCSV(complete);
            var headerData = data[0].Split(',');
            int NumberOfColumns = headerData.Length;
            DataTable RollHolder = new DataTable();
            DataColumn column;
            for (int col = 0; col < NumberOfColumns; col++)
            {
                column = new DataColumn
                {
                    Caption = headerData[col],
                    ColumnName = headerData[col]
                };
                RollHolder.Columns.Add(column);
            }

            int NumberOfRows = data.Length;
            for (int row = 1; row < NumberOfRows; row++)
            {
                var rollData = data[row].Split(',');
                DataRow RollRow = RollHolder.NewRow();

                for (int i = 0; i < NumberOfColumns; i++)
                {
                    RollRow[i] = rollData[i];
                }
                RollHolder.Rows.Add(RollRow);
            }

            return RollHolder;
        }
        private void SaveSettings(object sender, FormClosingEventArgs e)
        {
            SaveCharacterSettings(); //NEED TO IMPLEMENT
            //Prevent unnecessary saving by checking if fields have been modified before needing to save
            if (!CustomRollsDirty)
                SaveCustomRolls();
            if (!SavingThrowsDirty)
                SaveSavingThrows();
            if (!SkillsDirty)
                SaveSkills();
        }
        private void SaveCharacterSettings()
        {
            Properties.Settings.Default.ss_charName = tb_charName.Text;
            Properties.Settings.Default.ss_charHPcurr = tb_charHPcurr.Text;
            Properties.Settings.Default.ss_charHPmax = tb_charHPmax.Text;
            Properties.Settings.Default.ss_charAC = tb_charAC.Text;
        }
        private void SaveCustomRolls()
        {
            try
            {
                FileIO.WriteDataToCSV(RollTable, RollsCSVName);
            }
            catch (NullReferenceException)
            {
                return;
            }
        }
        private void SaveSavingThrows()
        {
            try
            {
                FileIO.WriteDataToCSV(SavingThrowsTable, SavingThrowsCSVName);
            }
            catch (NullReferenceException)
            {
                return;
            }
        }
        private void SaveSkills()
        {
            try
            {
                FileIO.WriteDataToCSV(SkillsTable, SkillsCSVName);
            }
            catch (NullReferenceException)
            {
                return;
            }
        }
        #endregion
        #region Events 
        private void TriggerCustomRoll(object sender, DataGridViewCellMouseEventArgs e)
        {
            int SelectedRow = e.RowIndex;
            var row = RollTable.Rows[SelectedRow];
            var RollToParse = row[1].ToString();
            var (Total, IndividualRolls) = ParseRoll(RollToParse);
            var FinalResult = CombineTotalAndIndivRolls(Total, IndividualRolls);

            lbl_FinalRoll.Text = Total;
            lbl_TableRoll.Text = FinalResult;
        }
        private void TriggerSavingThrowRoll(object sender, DataGridViewCellMouseEventArgs e)
        {
            int SelectedRow = e.RowIndex;
            var row = SavingThrowsTable.Rows[SelectedRow];
            int modValue = int.Parse(row[1].ToString());
            var rollResult = RollFunctions.Roll(1, 20);
            var total = modValue + rollResult;

            lbl_FinalRoll.Text = total.ToString();
        }
        private void TriggerSkillRoll(object sender, DataGridViewCellMouseEventArgs e)
        {
            int SelectedRow = e.RowIndex;
            var row = SkillsTable.Rows[SelectedRow];
            int modValue = int.Parse(row[1].ToString());
            var rollResult = RollFunctions.Roll(1, 20);
            var total = modValue + rollResult;

            lbl_FinalRoll.Text = total.ToString();
        }
        private void ModifySkillsBool(object sender, DataGridViewCellEventArgs e)
        {
            SkillsDirty = true;
        }
        private void ModifySavingThrowsBool(object sender, DataGridViewCellEventArgs e)
        {
            SavingThrowsDirty = true;
        }
        private void ModifyCustomRollBool(object sender, DataGridViewCellEventArgs e)
        {
            CustomRollsDirty = true;
        }
        #endregion
        #region Roll Methods
        private string CombineTotalAndIndivRolls(string total, string[] indivRoll)
        {
            var sb = new StringBuilder();
            sb.Append(total + "    (");
            int numOfRolls = indivRoll.Length;
            for (int i = 0; i < numOfRolls; i++)
            {
                sb.Append(indivRoll[i] + ", ");
            }
            int sbLength = sb.Length;
            sb.Remove(sbLength - 2, 2); //Removes the extra comma at the end

            sb.Append(")");
            return sb.ToString();
        }
        private void ManualRollString(object sender, EventArgs e)
        {
            var (Total, IndividualRolls) = ParseRoll(tb_rollString.Text);
            var FinalResult = CombineTotalAndIndivRolls(Total, IndividualRolls);

            lbl_FinalRoll.Text = Total;
            label_manualTotal.Text = FinalResult;

            if (!cb_saveRoll.Checked)
                tb_rollString.Text = "";
        }
        private (string Total, string[] IndividualRolls) ParseRoll(string rollString)
        {
            int total = 0;
            string processingType = "";
            DieRegex.parseRoll(rollString);
            string[] rollTokens = rollString.Split('+', '-');
            string[] indivRolls = new string[rollTokens.Length];
            int indivIndex = 0;
            int result;
            foreach (string individualRoll in rollTokens)
            {
                string[] rollValue = individualRoll.Split('d');
                if (rollValue.Length > 1)
                    processingType = "dice roll";
                else
                    processingType = "integer";
                switch (processingType)
                {
                    case "dice roll":
                        if (rollValue[0].Contains(" "))
                            rollValue[0] = rollValue[0].Replace(" ", string.Empty);
                        if (rollValue[1].Contains(" "))
                            rollValue[1] = rollValue[1].Replace(" ", string.Empty);

                        if (!validRolls.Contains(rollValue[1]))
                        {
                            MessageBox.Show(rollValue[1] + " is not a valid die. Please check your roll string", "Roll check", MessageBoxButtons.OK);
                            return (string.Empty, new string[0]);
                        }
                        else
                        {
                            result = RollFunctions.Roll(Convert.ToInt16(rollValue[0]), Convert.ToInt16(rollValue[1]));
                            total += result;
                            indivRolls[indivIndex] = result.ToString();
                            indivIndex++;
                        }
                        break;

                    case "integer":
                        result = int.Parse(rollValue[0]);
                        total += result;
                        indivRolls[indivIndex] = result.ToString();
                        indivIndex++;
                        break;
                }
            }
            return (total.ToString(), indivRolls);
        }
        private void rollConcat(object sender, EventArgs e)
        {
            int total = 0;
            var panels = diceGroupBox.Controls.OfType<Panel>();
            foreach (Panel panel in panels)
            {
                Button dieButton = sender as Button;
                string[] panelSplit = panel.Name.Split('d');
                int dieValue = int.Parse(panelSplit[1]);
                string panelName = "panel_d" + dieValue;
                string labelName = "label_d" + dieValue + "Result";
                //Again, not proper practice. But it was a fun challenge
                var label = this.Controls.Find(labelName, true).First();
                panel_d4.Controls.OfType<TextBox>().Where(tb => tb.Name.Contains("Qty")).First();
                TextBox tb_Qty = panel.Controls.OfType<TextBox>().Where(tb => tb.Name.Contains("Qty")).First();
                TextBox tb_Mod = panel.Controls.OfType<TextBox>().Where(tb => tb.Name.Contains("Mod")).First();
                if (!string.IsNullOrEmpty(tb_Qty.Text))
                {
                    int result = RollFunctions.RollCalc(tb_Qty.Text, dieValue, tb_Mod.Text);
                    label.Text = result.ToString();
                    total += result;
                }
                label_dbTotal.Text = total.ToString();
            }
        }
        private void ManualRoll(int dieValue)
        {
            string panelName = "panel_d" + dieValue;
            string labelName = "label_d" + dieValue + "Result";

            //I know that none of this is proper practice, but I just wanted to see if I could do it
            //Parsing based on control name is not ideal
            var panel = this.Controls.Find(panelName, true).First();
            var label = this.Controls.Find(labelName, true).First();
            panel_d4.Controls.OfType<TextBox>().Where(tb => tb.Name.Contains("Qty")).First();
            TextBox tb_Qty = panel.Controls.OfType<TextBox>().Where(tb => tb.Name.Contains("Qty")).First();
            TextBox tb_Mod = panel.Controls.OfType<TextBox>().Where(tb => tb.Name.Contains("Mod")).First();
            int result = RollFunctions.RollCalc(tb_Qty.Text, dieValue, tb_Mod.Text);
            if (result == 1 & dieValue == 20 & string.IsNullOrEmpty(tb_Mod.Text))
            {
                /*
                critical fail easter egg
                pb_Unlucky.Enabled = true;
                pb_Unlucky.Visible = true;
                var timer = new System.Timers.Timer(3500);
                timer.Elapsed += UnluckyTimerEvent;
                timer.Start();
                */
            }
            lbl_FinalRoll.Text = result.ToString();
        }
        #endregion
        private void openChSheet(object sender, EventArgs e)
        {
            //Open character sheet
            OpenFileDialog fileDialog = new OpenFileDialog();
            FileIO.OpenFileWithDefault(fileDialog.FileName);
        }
        private void addCustomRoll(object sender, EventArgs e)
        {
            //Used to populate the custom roll table
            CustomRollForm = new CustomRollForm();
            CustomRollForm.Show();
            CustomRollForm.ParametersSet += new EventHandler(AddNewRollToTable);
        }
        private void btn_modifyCustomRoll_Click(object sender, EventArgs e)
        {
            //Needs proper implementation
        }
        //private void GUIRolls(RollTypes roll, int RowID) ///WORK IN PROGRESS
        //{
        //    DataTable dt;
        //    string Total;
        //    int rollRow;
        //    if (roll == RollTypes.CustomRoll)
        //    {
        //        dt = RollTable;
        //        rollRow = 1;
        //        (Total, string[] IndividualRolls) = ParseRoll(RollToParse);
        //        var FinalResult = CombineTotalAndIndivRolls(Total, IndividualRolls);

        //        lbl_FinalRoll.Text = Total;
        //        lbl_TableRoll.Text = FinalResult;
        //    }
        //    else if (roll == RollTypes.SavingThrowRoll)
        //    {
        //        dt = SavingThrowsTable;
        //        rollRow = 1;
        //    }
        //    else
        //    {
        //        dt = SkillsTable;
        //        rollRow = 1;
        //    }
        //    var row = dt.Rows[RowID];
        //    var RollToParse = row[rollRow].ToString();
        //}
        
        private void btn_deleteCustomRoll_Click(object sender, EventArgs e)
        {
            var selectedCell = DGV_Rolls.CurrentRow;
            DGV_Rolls.Rows.Remove(selectedCell); //Remove 0 because MultiSelect is disabled
        }
    }
}
