using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomAttackInput
{
    public partial class CustomAttack : Form
    {
        public string name = "";
        public string roll = "";
        public string level = "";
        public string description = "";

        public CustomAttack()
        {
            InitializeComponent();
        }

        public void saveAtk(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_Name.Text))
            {
                MessageBox.Show("Please enter a name for this attack", "Form check", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (string.IsNullOrEmpty(tb_RollString.Text))
            {
                MessageBox.Show("Please enter a roll for this attack", "Form check", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            this.name = tb_Name.Text;
            this.roll = tb_RollString.Text;
            this.level = tb_Level.Text;
            this.description = tb_Description.Text;
            this.Close();
        }

        public void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void Show (int xPos)
        {
            Form.ActiveForm.Left = xPos;
      
        }
    }
}
