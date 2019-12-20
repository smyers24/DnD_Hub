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

        public Form1()
        {
            InitializeComponent();
        }

        private int roll(int numberOfRolls, int dieValue)
        {
            Random roll = new Random();
            int result = 0;
            for (int i = 0; i < numberOfRolls; i++)
            {
                result += roll.Next(1, dieValue + 1);
            }
            Console.WriteLine(result);
            return result;

        }


        private void manualRoll(object sender, MouseEventArgs e)
        {
            rollCalc(sender);

        }

        private int rollCalc(object sender)
        {
            Button dieButton = sender as Button;
            bool validRollQty;
            int rollQty;
            int dieValue = int.Parse(dieButton.Text.Substring(1)); //get die value from button name
            string rollQtyName = dieButton.Text + "RollNum"; //make name of corresponding textbox
            TextBox tb = new TextBox();
            tb.Name = rollQtyName;
            int rollQuantity;

            TextBox tbx = this.Controls.Find(rollQtyName, true).FirstOrDefault() as TextBox;
            validRollQty = int.TryParse(tbx.Text, out rollQty);
            if (validRollQty)
                rollQuantity = rollQty;
            else
                rollQuantity = 1;
            int result = roll(rollQuantity, dieValue);

            return result;
        }

        private void rollConcat(object sender, EventArgs e)
        {
            TextBox diceBox = new TextBox();
            int rollQty;
            int total = 0;
            foreach (String box in diceTBlist)
            {

                TextBox tbx = this.Controls.Find(box, true).FirstOrDefault() as TextBox;
                if (tbx.Text != "")
                {
                    total += rollCalc(tbx);
                    Console.WriteLine(total);
                    bool validRollQty = int.TryParse(tbx.Text, out rollQty);
                    diceBox.Name = box;
                }
                //  if di
            }

        }

        private void openListOfThings(object sender, EventArgs e)
        {
            openedItemsListBox.Items.Clear();
            string[] files = Array.Empty<string>();
            OpenFileDialog fileDialog = new OpenFileDialog();
          //  var fullFilePath = fileDialog.FileName;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                files = File.ReadAllLines(fileDialog.FileName);
            }
            foreach (string file in files)
            {
                openedItemsListBox.Items.Add(file);
                OpenFileWithDefault(file);
                Console.WriteLine(file);
            }
        }

        private void ropenItemFromList(object sender, EventArgs e)
        {
            if (openedItemsListBox.SelectedItem != null)
            {
                Console.WriteLine(openedItemsListBox.SelectedItem.ToString());
            }
            openedItemsListBox.ClearSelected();
        }

        private void OpenFileWithDefault(string fileName)
        {
            Process fileopener = new Process();
            try
            {
                fileopener.StartInfo.FileName = fileName;
                fileopener.Start();
                fileopener.Close();
            }
            catch
            {
                MessageBox.Show("Invalid file selection: " + fileName);
            }
        }

        private void openMap(object sender, EventArgs e)
        {
            OpenFileDialog openMap = new OpenFileDialog();
            var path = openMap.ShowDialog();
            mapBrowser.Navigate(openMap.FileName);
        }

        private void addSavedRoll(object sender, EventArgs e)
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
                    roll(Convert.ToInt16(rollValue[0]), Convert.ToInt16(rollValue[1]));
                }

            }
        }

        private void manualRoll(object sender, EventArgs e)
        {

        }


    }
}
