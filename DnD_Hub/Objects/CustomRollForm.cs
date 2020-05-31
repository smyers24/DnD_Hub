using System;
using System.Windows.Forms;

namespace DnD.Objects
{
    public partial class CustomRollForm : Form
    {
        public event EventHandler ParametersSet;
        public string RollName { get; private set; }
        public string RollString { get; private set; }
        public string Description { get; private set; }

        public struct RollParameters
        {
            public string RollName;
            public string RollString;
            public string Description;
          //  public int NumberOfFields;
        }
        public CustomRollForm()
        {
            InitializeComponent();
           // ParametersSet += ParametersSet;
        }
         
        public RollParameters GetRollParameters()
        {
            SetParameters();
            return new RollParameters
            {
                RollName    = RollName,
                RollString  = RollString,
                Description = Description,
            //    NumberOfFields = 3
            };
        }

        private void SetParameters()
        {
            RollName = tb_RollName.Text;
            RollString = tb_RollString.Text;
            Description = tb_Description.Text;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            SetParameters();
            ParametersSet?.Invoke(this, e);
            this.Hide();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
