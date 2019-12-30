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

namespace DnD_Hub
{
    public partial class Form1 : Form
    {
        DieRegex regexParse = new DieRegex();
        List<string> diceTBlist = new List<string>() { "d4RollNum", "d6RollNum", "d8RollNum", "d10RollNum", "d12RollNum", "d20RollNum" };
        List<string> validRolls = new List<string>() { "4", "6", "8", "10", "12", "20" };
        Random rollSeed = new Random();
        RollFunctions roll = new RollFunctions();
        FileIO file = new FileIO();

        public Form1()
        {
            InitializeComponent();
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
                }
            }

        }
        
        private void openListOfThings(object sender, EventArgs e)
        {
            openedItemsListBox.Items.Clear();
            string[] files = file.openListOfThings();
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
                file.OpenFileWithDefault(openedItemsListBox.SelectedItem.ToString());
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
        }
        private void parseRoll(string rollString)
        {
            DieRegex.parseRoll(rollString);
            string[] rollTokens = rollString.Split('+','-');
            foreach (string individualRoll in rollTokens)
            {
                string[] rollValue = individualRoll.Split('d');

                if (rollValue[0].Contains(" "))
                    rollValue[0] = rollValue[0].Replace(" ", string.Empty);
                if (rollValue[1].Contains(" "))
                    rollValue[1] = rollValue[1].Replace(" ", string.Empty);

                if (!validRolls.Contains(rollValue[1])){
                    MessageBox.Show(rollValue[1] + " is not a valid die. Please check your roll string", "Roll check", MessageBoxButtons.OK);
                        return;
                }
                else
                {
                    roll.roll(Convert.ToInt16(rollValue[0]), Convert.ToInt16(rollValue[1]));
                }

            }
        }

        private void openFileBrowser(object sender, EventArgs e)
        {
            OpenFileDialog openMap = new OpenFileDialog();
            var path = openMap.ShowDialog();
            file.OpenFileWithDefault(openMap.FileName);
        }

        private void saveSettings(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.ss_charName   = tb_charName.Text;
            Properties.Settings.Default.ss_charHPcurr = tb_charHPcurr.Text;
            Properties.Settings.Default.ss_charHPmax  = tb_charHPmax.Text;
            Properties.Settings.Default.ss_charAC     = tb_charAC.Text;
        }

        private void loadSettings(object sender, EventArgs e)
        {
            tb_charName.Text   = Properties.Settings.Default.ss_charName;
            tb_charHPcurr.Text = Properties.Settings.Default.ss_charHPcurr;
            tb_charHPmax.Text  = Properties.Settings.Default.ss_charHPmax;
            tb_charAC.Text     = Properties.Settings.Default.ss_charAC;
        }

        private void openChSheet(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            file.OpenFileWithDefault(fileDialog.FileName);
        }

        private void addCustomRoll(object sender, EventArgs e)
        {

        }
    }
}
