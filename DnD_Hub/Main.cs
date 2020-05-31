using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using DnD.Rolls;
using IO;
using DnD.Objects;

namespace DnD
{
    public partial class Main : Form
    {
        List<string> diceTBlist = new List<string>() { "d4RollNum", "d6RollNum", "d8RollNum", "d10RollNum", "d12RollNum", "d20RollNum" };
        List<string> validRolls = new List<string>() { "4", "6", "8", "10", "12", "20" };
        Random rollSeed = new Random();
        RollFunctions roll = new RollFunctions();
        CustomRollForm CustomRollForm;
        DataTable RollTable;
        CustomRollForm.RollParameters parameters;

        public Main()
        {
            InitializeComponent();
            DataTable RollTable = new DataTable("Roll Table");
            DGV_Rolls.DataSource = RollTable;
        }

        private void clickManualRoll(object sender, EventArgs e)
        {
            Button dieButton = sender as Button;
            int dieValue = DieRegex.findDieValue(dieButton.Name); //get die value from button name
            manualRoll(dieValue);
        }


        private void manualRoll(int dieValue)
        {
            string panelName = "panel_d" + dieValue;
            string labelName = "label_d" + dieValue + "Result";

            var panel = this.Controls.Find(panelName, true).First();
            var label = this.Controls.Find(labelName, true).First();
            panel_d4.Controls.OfType<TextBox>().Where(tb => tb.Name.Contains("Qty")).First();
            TextBox tb_Qty = panel.Controls.OfType<TextBox>().Where(tb => tb.Name.Contains("Qty")).First();
            TextBox tb_Mod = panel.Controls.OfType<TextBox>().Where(tb => tb.Name.Contains("Mod")).First();
            int result = roll.rollCalc(tb_Qty.Text, dieValue, tb_Mod.Text);
            label.Text = result.ToString();
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

                var label = this.Controls.Find(labelName, true).First();
                panel_d4.Controls.OfType<TextBox>().Where(tb => tb.Name.Contains("Qty")).First();
                TextBox tb_Qty = panel.Controls.OfType<TextBox>().Where(tb => tb.Name.Contains("Qty")).First();
                TextBox tb_Mod = panel.Controls.OfType<TextBox>().Where(tb => tb.Name.Contains("Mod")).First();
                if (!string.IsNullOrEmpty(tb_Qty.Text))
                {
                    int result = roll.rollCalc(tb_Qty.Text, dieValue, tb_Mod.Text);
                    label.Text = result.ToString();
                    total += result;
                }
                label_dbTotal.Text = total.ToString();
            }

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
                Console.WriteLine(openedItemsListBox.SelectedItem.ToString());
                FileIO.OpenFileWithDefault(openedItemsListBox.SelectedItem.ToString());
            }
            openedItemsListBox.ClearSelected();
        }

        private void openMap(object sender, EventArgs e)
        {
            OpenFileDialog openMap = new OpenFileDialog();
            var path = openMap.ShowDialog();
            mapBrowser.Navigate(openMap.FileName);
        }

        private void manualRollString(object sender, EventArgs e)
        {
            parseRoll(tb_rollString.Text);
            if (!cb_saveRoll.Checked)
                tb_rollString.Text = "";
        }
        private void parseRoll(string rollString)
        {
            int total = 0;
            string processingType = "";
            DieRegex.parseRoll(rollString);
            string[] rollTokens = rollString.Split('+', '-');
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
                            return;
                        }
                        else
                        {
                            total += roll.roll(Convert.ToInt16(rollValue[0]), Convert.ToInt16(rollValue[1]));
                        }
                        break;
                    case "integer":
                        total += int.Parse(rollValue[0]);
                        break;
                }
            }
            label_manualTotal.Text = total.ToString();
        }

        private void openFileBrowser(object sender, EventArgs e)
        {
            OpenFileDialog openMap = new OpenFileDialog();
            var path = openMap.ShowDialog();
            FileIO.OpenFileWithDefault(openMap.FileName);
        }

        private void saveSettings(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.ss_charName = tb_charName.Text;
            Properties.Settings.Default.ss_charHPcurr = tb_charHPcurr.Text;
            Properties.Settings.Default.ss_charHPmax = tb_charHPmax.Text;
            Properties.Settings.Default.ss_charAC = tb_charAC.Text;
            try
            {
                FileIO.WriteDataToCSV(RollTable);
            }
            catch (NullReferenceException)
            {
                return;
            }
        }

        private void loadSettings(object sender, EventArgs e)
        {
            tb_charName.Text = Properties.Settings.Default.ss_charName;
            tb_charHPcurr.Text = Properties.Settings.Default.ss_charHPcurr;
            tb_charHPmax.Text = Properties.Settings.Default.ss_charHPmax;
            tb_charAC.Text = Properties.Settings.Default.ss_charAC;
            try
            {
                RollTable = LoadTable();
            }
            catch(FileNotFoundException)
            {
                return;
            }

            DGV_Rolls.AllowUserToAddRows = false;
            DGV_Rolls.AllowUserToDeleteRows = false;
            DGV_Rolls.AllowUserToOrderColumns = true;
            DGV_Rolls.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGV_Rolls.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders; // Appears that this line should be `AllCells` to avoid the problem you are facing
            DGV_Rolls.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Rolls.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                     
            DGV_Rolls.DataSource = RollTable;
        }

        private void openChSheet(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            FileIO.OpenFileWithDefault(fileDialog.FileName);
        }

        private void addCustomRoll(object sender, EventArgs e)
        {
            //var roll = new CustomRoll();
            CustomRollForm = new CustomRollForm();
            CustomRollForm.Show();
            CustomRollForm.ParametersSet += new EventHandler(AddNewRollToTable);
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


        private void btn_modifyCustomRoll_Click(object sender, EventArgs e)
        {
            //   Solution sa = new Solution();
            //   int[][] fuck = new int[1][];
            //   fuck[0] = new int[2] { 2,1 };
            ////   fuck[1] = new int[3] { 1,1,0 };
            ////   fuck[2] = new int[3] { 0,1,1 };
            //   sa.OrangesRotting(fuck);\
        }

        static DataTable LoadTable()
        {
            var systemPath = System.Environment.
                 GetFolderPath(
                     Environment.SpecialFolder.CommonApplicationData
                 );
            var complete = Path.Combine(systemPath, "rolls.csv");

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

        private void TriggerCustomRoll(object sender, DataGridViewCellMouseEventArgs e)
        {
            int SelectedRow = e.RowIndex;
            if (SelectedRow == 0)
                return;
            else
            {

            }
        }
    }
}
