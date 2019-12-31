namespace CustomAttackInput
{
    partial class CustomAttack
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Name = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.label_Roll = new System.Windows.Forms.Label();
            this.tb_RollString = new System.Windows.Forms.TextBox();
            this.label_Desc = new System.Windows.Forms.Label();
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.label_Level = new System.Windows.Forms.Label();
            this.tb_Level = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(5, 13);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(38, 13);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Name:";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(50, 10);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(148, 20);
            this.tb_Name.TabIndex = 1;
            // 
            // label_Roll
            // 
            this.label_Roll.AutoSize = true;
            this.label_Roll.Location = new System.Drawing.Point(5, 39);
            this.label_Roll.Name = "label_Roll";
            this.label_Roll.Size = new System.Drawing.Size(28, 13);
            this.label_Roll.TabIndex = 0;
            this.label_Roll.Text = "Roll:";
            // 
            // tb_RollString
            // 
            this.tb_RollString.Location = new System.Drawing.Point(50, 36);
            this.tb_RollString.Name = "tb_RollString";
            this.tb_RollString.Size = new System.Drawing.Size(148, 20);
            this.tb_RollString.TabIndex = 1;
            // 
            // label_Desc
            // 
            this.label_Desc.AutoSize = true;
            this.label_Desc.Location = new System.Drawing.Point(5, 90);
            this.label_Desc.Name = "label_Desc";
            this.label_Desc.Size = new System.Drawing.Size(66, 13);
            this.label_Desc.TabIndex = 0;
            this.label_Desc.Text = "Description: ";
            // 
            // tb_Description
            // 
            this.tb_Description.Location = new System.Drawing.Point(8, 106);
            this.tb_Description.Multiline = true;
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.Size = new System.Drawing.Size(190, 77);
            this.tb_Description.TabIndex = 1;
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(8, 189);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(88, 23);
            this.btn_OK.TabIndex = 2;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.saveAtk);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Cancel.Location = new System.Drawing.Point(112, 189);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(86, 23);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // label_Level
            // 
            this.label_Level.AutoSize = true;
            this.label_Level.Location = new System.Drawing.Point(5, 65);
            this.label_Level.Name = "label_Level";
            this.label_Level.Size = new System.Drawing.Size(36, 13);
            this.label_Level.TabIndex = 0;
            this.label_Level.Text = "Level:";
            // 
            // tb_Level
            // 
            this.tb_Level.Location = new System.Drawing.Point(50, 62);
            this.tb_Level.Name = "tb_Level";
            this.tb_Level.Size = new System.Drawing.Size(148, 20);
            this.tb_Level.TabIndex = 1;
            // 
            // CustomAttack
            // 
            this.AcceptButton = this.btn_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Cancel;
            this.ClientSize = new System.Drawing.Size(210, 221);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.label_Desc);
            this.Controls.Add(this.tb_Description);
            this.Controls.Add(this.tb_Level);
            this.Controls.Add(this.label_Level);
            this.Controls.Add(this.tb_RollString);
            this.Controls.Add(this.label_Roll);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.label_Name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomAttack";
            this.Text = "Custom Attack/Spell";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Label label_Roll;
        private System.Windows.Forms.TextBox tb_RollString;
        private System.Windows.Forms.Label label_Desc;
        private System.Windows.Forms.TextBox tb_Description;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label_Level;
        private System.Windows.Forms.TextBox tb_Level;
    }
}

