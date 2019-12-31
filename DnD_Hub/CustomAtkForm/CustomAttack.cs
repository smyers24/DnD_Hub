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
        string name = "";
        string roll = "";
        string level = "";
        string description = "";

        public CustomAttack()
        {
            InitializeComponent();
        }

        private void saveAtk(object sender, EventArgs e)
        {
            this.name = tb_Name.Text;
            this.roll = tb_RollString.Text;
            this.level = tb_Level.Text;
            this.description = tb_Description.Text;
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void Show (int xPos)
        {
            Form.ActiveForm.Left = xPos;
      
        }
    }
}
