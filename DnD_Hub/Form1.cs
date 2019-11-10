using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnD_Hub
{
    public partial class Form1 : Form
    {
        DieRegex regexParse = new DieRegex();
        List<string> diceTBlist = new List<string>() { "d4RollNum", "d6RollNum", "d8RollNum", "d10RollNum", "d12RollNum", "d20RollNum" };

        public Form1()
        {
            InitializeComponent();
        }

        private int roll(int numberOfRolls, int dieValue)
        {
            Random roll = new Random();
            int result = 0;
            for (int i=0; i<numberOfRolls; i++)
            {
                result += roll.Next(dieValue + 1);
            }
            return result;
        } 
       
        
        private void manualRoll(int die)
        {

        }

        private void manualRoll(object sender, MouseEventArgs e)
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

            Console.WriteLine(roll(rollQuantity, dieValue));
             
        }

        private void rollConcat(object sender, EventArgs e)
        {
            TextBox diceBox = new TextBox();
            foreach (String box in diceTBlist)
            {
                diceBox.Name = box;
                if di
            }

        }
    }
}
