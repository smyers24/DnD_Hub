namespace DnD_Hub
{
    partial class Form1
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
            this.rollGroupBox = new System.Windows.Forms.GroupBox();
            this.rollChest = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_rollString = new System.Windows.Forms.TextBox();
            this.btn_addCustomRoll = new System.Windows.Forms.Button();
            this.btn_modifyCustomRoll = new System.Windows.Forms.Button();
            this.btn_deleteCustomRoll = new System.Windows.Forms.Button();
            this.btn_ManualRoll = new System.Windows.Forms.Button();
            this.btn_openCharSheet = new System.Windows.Forms.Button();
            this.characterGroupBox = new System.Windows.Forms.GroupBox();
            this.hpMaxTB = new System.Windows.Forms.TextBox();
            this.acTB = new System.Windows.Forms.TextBox();
            this.hpCurrentTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.acLabel = new System.Windows.Forms.Label();
            this.charNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fileGroupBox = new System.Windows.Forms.GroupBox();
            this.openedItemsListBox = new System.Windows.Forms.ListBox();
            this.mapSelection = new System.Windows.Forms.Button();
            this.openListBtn = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tab_overview = new System.Windows.Forms.TabPage();
            this.tab_map = new System.Windows.Forms.TabPage();
            this.mapBrowser = new System.Windows.Forms.WebBrowser();
            this.d12RollNum = new System.Windows.Forms.TextBox();
            this.d8RollNum = new System.Windows.Forms.TextBox();
            this.d6RollNum = new System.Windows.Forms.TextBox();
            this.btn_d20 = new System.Windows.Forms.Button();
            this.d10RollNum = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_rollDiceBox = new System.Windows.Forms.Button();
            this.btn_d10 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.d20RollNum = new System.Windows.Forms.TextBox();
            this.btn_d12 = new System.Windows.Forms.Button();
            this.textBoxD4Extra = new System.Windows.Forms.TextBox();
            this.btn_d6 = new System.Windows.Forms.Button();
            this.textBoxD8Extra = new System.Windows.Forms.TextBox();
            this.btn_d8 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxD12Extra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxD6Extra = new System.Windows.Forms.TextBox();
            this.btn_d4 = new System.Windows.Forms.Button();
            this.textBoxD10Extra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxD20Extra = new System.Windows.Forms.TextBox();
            this.d4RollNum = new System.Windows.Forms.TextBox();
            this.diceGroupBox = new System.Windows.Forms.GroupBox();
            this.label_d4Result = new System.Windows.Forms.Label();
            this.label_d6Result = new System.Windows.Forms.Label();
            this.label_d8Result = new System.Windows.Forms.Label();
            this.label_d10Result = new System.Windows.Forms.Label();
            this.label_d12Result = new System.Windows.Forms.Label();
            this.label_d20Result = new System.Windows.Forms.Label();
            this.chkbox_d4Vantage = new System.Windows.Forms.CheckBox();
            this.chkbox_d6Vantage = new System.Windows.Forms.CheckBox();
            this.chkbox_d8Vantage = new System.Windows.Forms.CheckBox();
            this.chkbox_d10Vantage = new System.Windows.Forms.CheckBox();
            this.chkbox_d12Vantage = new System.Windows.Forms.CheckBox();
            this.chkbox_d20Vantage = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label_manualRollResult = new System.Windows.Forms.Label();
            this.rollGroupBox.SuspendLayout();
            this.characterGroupBox.SuspendLayout();
            this.fileGroupBox.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tab_overview.SuspendLayout();
            this.tab_map.SuspendLayout();
            this.diceGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rollGroupBox
            // 
            this.rollGroupBox.Controls.Add(this.rollChest);
            this.rollGroupBox.Controls.Add(this.diceGroupBox);
            this.rollGroupBox.Controls.Add(this.checkBox1);
            this.rollGroupBox.Controls.Add(this.label10);
            this.rollGroupBox.Controls.Add(this.tb_rollString);
            this.rollGroupBox.Controls.Add(this.btn_addCustomRoll);
            this.rollGroupBox.Controls.Add(this.btn_modifyCustomRoll);
            this.rollGroupBox.Controls.Add(this.label_manualRollResult);
            this.rollGroupBox.Controls.Add(this.btn_deleteCustomRoll);
            this.rollGroupBox.Controls.Add(this.btn_ManualRoll);
            this.rollGroupBox.Location = new System.Drawing.Point(22, 208);
            this.rollGroupBox.Name = "rollGroupBox";
            this.rollGroupBox.Size = new System.Drawing.Size(769, 336);
            this.rollGroupBox.TabIndex = 2;
            this.rollGroupBox.TabStop = false;
            this.rollGroupBox.Text = "Roll";
            // 
            // rollChest
            // 
            this.rollChest.FormattingEnabled = true;
            this.rollChest.Location = new System.Drawing.Point(6, 19);
            this.rollChest.Name = "rollChest";
            this.rollChest.Size = new System.Drawing.Size(262, 95);
            this.rollChest.TabIndex = 4;
            this.rollChest.DoubleClick += new System.EventHandler(this.ropenItemFromList);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(195, 184);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Save roll?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Roll String";
            // 
            // tb_rollString
            // 
            this.tb_rollString.Location = new System.Drawing.Point(10, 182);
            this.tb_rollString.Name = "tb_rollString";
            this.tb_rollString.Size = new System.Drawing.Size(163, 20);
            this.tb_rollString.TabIndex = 5;
            // 
            // btn_addCustomRoll
            // 
            this.btn_addCustomRoll.Location = new System.Drawing.Point(6, 120);
            this.btn_addCustomRoll.Name = "btn_addCustomRoll";
            this.btn_addCustomRoll.Size = new System.Drawing.Size(75, 23);
            this.btn_addCustomRoll.TabIndex = 3;
            this.btn_addCustomRoll.Text = "Add";
            this.btn_addCustomRoll.UseVisualStyleBackColor = true;
            this.btn_addCustomRoll.Click += new System.EventHandler(this.addSavedRoll);
            // 
            // btn_modifyCustomRoll
            // 
            this.btn_modifyCustomRoll.Location = new System.Drawing.Point(98, 120);
            this.btn_modifyCustomRoll.Name = "btn_modifyCustomRoll";
            this.btn_modifyCustomRoll.Size = new System.Drawing.Size(75, 23);
            this.btn_modifyCustomRoll.TabIndex = 3;
            this.btn_modifyCustomRoll.Text = "Modify";
            this.btn_modifyCustomRoll.UseVisualStyleBackColor = true;
            // 
            // btn_deleteCustomRoll
            // 
            this.btn_deleteCustomRoll.Location = new System.Drawing.Point(193, 120);
            this.btn_deleteCustomRoll.Name = "btn_deleteCustomRoll";
            this.btn_deleteCustomRoll.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteCustomRoll.TabIndex = 3;
            this.btn_deleteCustomRoll.Text = "Delete";
            this.btn_deleteCustomRoll.UseVisualStyleBackColor = true;
            // 
            // btn_ManualRoll
            // 
            this.btn_ManualRoll.Location = new System.Drawing.Point(10, 234);
            this.btn_ManualRoll.Name = "btn_ManualRoll";
            this.btn_ManualRoll.Size = new System.Drawing.Size(75, 23);
            this.btn_ManualRoll.TabIndex = 3;
            this.btn_ManualRoll.Text = "Manual Roll";
            this.btn_ManualRoll.UseVisualStyleBackColor = true;
            this.btn_ManualRoll.Click += new System.EventHandler(this.manualRoll);
            // 
            // btn_openCharSheet
            // 
            this.btn_openCharSheet.Location = new System.Drawing.Point(14, 134);
            this.btn_openCharSheet.Name = "btn_openCharSheet";
            this.btn_openCharSheet.Size = new System.Drawing.Size(145, 23);
            this.btn_openCharSheet.TabIndex = 3;
            this.btn_openCharSheet.Text = "Open Character Sheet";
            this.btn_openCharSheet.UseVisualStyleBackColor = true;
            // 
            // characterGroupBox
            // 
            this.characterGroupBox.Controls.Add(this.hpMaxTB);
            this.characterGroupBox.Controls.Add(this.acTB);
            this.characterGroupBox.Controls.Add(this.hpCurrentTB);
            this.characterGroupBox.Controls.Add(this.label3);
            this.characterGroupBox.Controls.Add(this.acLabel);
            this.characterGroupBox.Controls.Add(this.charNameTB);
            this.characterGroupBox.Controls.Add(this.label2);
            this.characterGroupBox.Controls.Add(this.label1);
            this.characterGroupBox.Controls.Add(this.btn_openCharSheet);
            this.characterGroupBox.Location = new System.Drawing.Point(22, 21);
            this.characterGroupBox.Name = "characterGroupBox";
            this.characterGroupBox.Size = new System.Drawing.Size(387, 181);
            this.characterGroupBox.TabIndex = 4;
            this.characterGroupBox.TabStop = false;
            this.characterGroupBox.Text = "Character ";
            // 
            // hpMaxTB
            // 
            this.hpMaxTB.Location = new System.Drawing.Point(113, 39);
            this.hpMaxTB.Name = "hpMaxTB";
            this.hpMaxTB.Size = new System.Drawing.Size(46, 20);
            this.hpMaxTB.TabIndex = 5;
            // 
            // acTB
            // 
            this.acTB.Location = new System.Drawing.Point(43, 65);
            this.acTB.Name = "acTB";
            this.acTB.Size = new System.Drawing.Size(46, 20);
            this.acTB.TabIndex = 5;
            // 
            // hpCurrentTB
            // 
            this.hpCurrentTB.Location = new System.Drawing.Point(43, 39);
            this.hpCurrentTB.Name = "hpCurrentTB";
            this.hpCurrentTB.Size = new System.Drawing.Size(46, 20);
            this.hpCurrentTB.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "/";
            // 
            // acLabel
            // 
            this.acLabel.AutoSize = true;
            this.acLabel.Location = new System.Drawing.Point(7, 68);
            this.acLabel.Name = "acLabel";
            this.acLabel.Size = new System.Drawing.Size(21, 13);
            this.acLabel.TabIndex = 4;
            this.acLabel.Text = "AC";
            // 
            // charNameTB
            // 
            this.charNameTB.Location = new System.Drawing.Point(43, 17);
            this.charNameTB.Name = "charNameTB";
            this.charNameTB.Size = new System.Drawing.Size(116, 20);
            this.charNameTB.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "HP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // fileGroupBox
            // 
            this.fileGroupBox.Controls.Add(this.openedItemsListBox);
            this.fileGroupBox.Controls.Add(this.mapSelection);
            this.fileGroupBox.Controls.Add(this.openListBtn);
            this.fileGroupBox.Location = new System.Drawing.Point(415, 21);
            this.fileGroupBox.Name = "fileGroupBox";
            this.fileGroupBox.Size = new System.Drawing.Size(231, 181);
            this.fileGroupBox.TabIndex = 4;
            this.fileGroupBox.TabStop = false;
            this.fileGroupBox.Text = "File Management";
            // 
            // openedItemsListBox
            // 
            this.openedItemsListBox.FormattingEnabled = true;
            this.openedItemsListBox.Location = new System.Drawing.Point(7, 48);
            this.openedItemsListBox.Name = "openedItemsListBox";
            this.openedItemsListBox.Size = new System.Drawing.Size(209, 95);
            this.openedItemsListBox.TabIndex = 4;
            this.openedItemsListBox.DoubleClick += new System.EventHandler(this.ropenItemFromList);
            // 
            // mapSelection
            // 
            this.mapSelection.Location = new System.Drawing.Point(46, 149);
            this.mapSelection.Name = "mapSelection";
            this.mapSelection.Size = new System.Drawing.Size(108, 23);
            this.mapSelection.TabIndex = 3;
            this.mapSelection.Text = "Open Map";
            this.mapSelection.UseVisualStyleBackColor = true;
            this.mapSelection.Click += new System.EventHandler(this.openMap);
            // 
            // openListBtn
            // 
            this.openListBtn.Location = new System.Drawing.Point(46, 19);
            this.openListBtn.Name = "openListBtn";
            this.openListBtn.Size = new System.Drawing.Size(108, 23);
            this.openListBtn.TabIndex = 3;
            this.openListBtn.Text = "Open List of Things";
            this.openListBtn.UseVisualStyleBackColor = true;
            this.openListBtn.Click += new System.EventHandler(this.openListOfThings);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tab_overview);
            this.tabControl.Controls.Add(this.tab_map);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(858, 635);
            this.tabControl.TabIndex = 5;
            // 
            // tab_overview
            // 
            this.tab_overview.Controls.Add(this.characterGroupBox);
            this.tab_overview.Controls.Add(this.fileGroupBox);
            this.tab_overview.Controls.Add(this.rollGroupBox);
            this.tab_overview.Location = new System.Drawing.Point(4, 22);
            this.tab_overview.Name = "tab_overview";
            this.tab_overview.Padding = new System.Windows.Forms.Padding(3);
            this.tab_overview.Size = new System.Drawing.Size(850, 609);
            this.tab_overview.TabIndex = 0;
            this.tab_overview.Text = "Overview";
            this.tab_overview.UseVisualStyleBackColor = true;
            // 
            // tab_map
            // 
            this.tab_map.Controls.Add(this.mapBrowser);
            this.tab_map.Location = new System.Drawing.Point(4, 22);
            this.tab_map.Name = "tab_map";
            this.tab_map.Padding = new System.Windows.Forms.Padding(3);
            this.tab_map.Size = new System.Drawing.Size(850, 609);
            this.tab_map.TabIndex = 1;
            this.tab_map.Text = "Map";
            this.tab_map.UseVisualStyleBackColor = true;
            // 
            // mapBrowser
            // 
            this.mapBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapBrowser.Location = new System.Drawing.Point(3, 3);
            this.mapBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.mapBrowser.Name = "mapBrowser";
            this.mapBrowser.Size = new System.Drawing.Size(844, 603);
            this.mapBrowser.TabIndex = 0;
            // 
            // d12RollNum
            // 
            this.d12RollNum.Location = new System.Drawing.Point(18, 133);
            this.d12RollNum.Name = "d12RollNum";
            this.d12RollNum.Size = new System.Drawing.Size(40, 20);
            this.d12RollNum.TabIndex = 5;
            // 
            // d8RollNum
            // 
            this.d8RollNum.Location = new System.Drawing.Point(18, 76);
            this.d8RollNum.Name = "d8RollNum";
            this.d8RollNum.Size = new System.Drawing.Size(40, 20);
            this.d8RollNum.TabIndex = 5;
            // 
            // d6RollNum
            // 
            this.d6RollNum.Location = new System.Drawing.Point(18, 48);
            this.d6RollNum.Name = "d6RollNum";
            this.d6RollNum.Size = new System.Drawing.Size(40, 20);
            this.d6RollNum.TabIndex = 5;
            // 
            // btn_d20
            // 
            this.btn_d20.Location = new System.Drawing.Point(80, 159);
            this.btn_d20.Name = "btn_d20";
            this.btn_d20.Size = new System.Drawing.Size(75, 23);
            this.btn_d20.TabIndex = 1;
            this.btn_d20.Text = "d20";
            this.btn_d20.UseVisualStyleBackColor = true;
            this.btn_d20.MouseClick += new System.Windows.Forms.MouseEventHandler(this.manualRoll);
            // 
            // d10RollNum
            // 
            this.d10RollNum.Location = new System.Drawing.Point(18, 105);
            this.d10RollNum.Name = "d10RollNum";
            this.d10RollNum.Size = new System.Drawing.Size(40, 20);
            this.d10RollNum.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(161, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "+/-";
            // 
            // btn_rollDiceBox
            // 
            this.btn_rollDiceBox.Location = new System.Drawing.Point(80, 205);
            this.btn_rollDiceBox.Name = "btn_rollDiceBox";
            this.btn_rollDiceBox.Size = new System.Drawing.Size(75, 23);
            this.btn_rollDiceBox.TabIndex = 3;
            this.btn_rollDiceBox.Text = "Roll";
            this.btn_rollDiceBox.UseVisualStyleBackColor = true;
            this.btn_rollDiceBox.Click += new System.EventHandler(this.rollConcat);
            // 
            // btn_d10
            // 
            this.btn_d10.Location = new System.Drawing.Point(80, 102);
            this.btn_d10.Name = "btn_d10";
            this.btn_d10.Size = new System.Drawing.Size(75, 23);
            this.btn_d10.TabIndex = 1;
            this.btn_d10.Text = "d10";
            this.btn_d10.UseVisualStyleBackColor = true;
            this.btn_d10.MouseClick += new System.Windows.Forms.MouseEventHandler(this.manualRoll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(161, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "+/-";
            // 
            // d20RollNum
            // 
            this.d20RollNum.Location = new System.Drawing.Point(18, 162);
            this.d20RollNum.Name = "d20RollNum";
            this.d20RollNum.Size = new System.Drawing.Size(40, 20);
            this.d20RollNum.TabIndex = 5;
            // 
            // btn_d12
            // 
            this.btn_d12.Location = new System.Drawing.Point(80, 130);
            this.btn_d12.Name = "btn_d12";
            this.btn_d12.Size = new System.Drawing.Size(75, 23);
            this.btn_d12.TabIndex = 1;
            this.btn_d12.Text = "d12";
            this.btn_d12.UseVisualStyleBackColor = true;
            this.btn_d12.MouseClick += new System.Windows.Forms.MouseEventHandler(this.manualRoll);
            // 
            // textBoxD4Extra
            // 
            this.textBoxD4Extra.Location = new System.Drawing.Point(183, 20);
            this.textBoxD4Extra.Name = "textBoxD4Extra";
            this.textBoxD4Extra.Size = new System.Drawing.Size(31, 20);
            this.textBoxD4Extra.TabIndex = 5;
            // 
            // btn_d6
            // 
            this.btn_d6.Location = new System.Drawing.Point(80, 45);
            this.btn_d6.Name = "btn_d6";
            this.btn_d6.Size = new System.Drawing.Size(75, 23);
            this.btn_d6.TabIndex = 1;
            this.btn_d6.Text = "d6";
            this.btn_d6.UseVisualStyleBackColor = true;
            this.btn_d6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.manualRoll);
            // 
            // textBoxD8Extra
            // 
            this.textBoxD8Extra.Location = new System.Drawing.Point(183, 77);
            this.textBoxD8Extra.Name = "textBoxD8Extra";
            this.textBoxD8Extra.Size = new System.Drawing.Size(31, 20);
            this.textBoxD8Extra.TabIndex = 5;
            // 
            // btn_d8
            // 
            this.btn_d8.Location = new System.Drawing.Point(80, 73);
            this.btn_d8.Name = "btn_d8";
            this.btn_d8.Size = new System.Drawing.Size(75, 23);
            this.btn_d8.TabIndex = 1;
            this.btn_d8.Text = "d8";
            this.btn_d8.UseVisualStyleBackColor = true;
            this.btn_d8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.manualRoll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "+/-";
            // 
            // textBoxD12Extra
            // 
            this.textBoxD12Extra.Location = new System.Drawing.Point(183, 134);
            this.textBoxD12Extra.Name = "textBoxD12Extra";
            this.textBoxD12Extra.Size = new System.Drawing.Size(31, 20);
            this.textBoxD12Extra.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "+/-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "+/-";
            // 
            // textBoxD6Extra
            // 
            this.textBoxD6Extra.Location = new System.Drawing.Point(183, 49);
            this.textBoxD6Extra.Name = "textBoxD6Extra";
            this.textBoxD6Extra.Size = new System.Drawing.Size(31, 20);
            this.textBoxD6Extra.TabIndex = 5;
            // 
            // btn_d4
            // 
            this.btn_d4.Location = new System.Drawing.Point(80, 16);
            this.btn_d4.Name = "btn_d4";
            this.btn_d4.Size = new System.Drawing.Size(75, 23);
            this.btn_d4.TabIndex = 1;
            this.btn_d4.Text = "d4";
            this.btn_d4.UseVisualStyleBackColor = true;
            this.btn_d4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.manualRoll);
            // 
            // textBoxD10Extra
            // 
            this.textBoxD10Extra.Location = new System.Drawing.Point(183, 106);
            this.textBoxD10Extra.Name = "textBoxD10Extra";
            this.textBoxD10Extra.Size = new System.Drawing.Size(31, 20);
            this.textBoxD10Extra.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "+/-";
            // 
            // textBoxD20Extra
            // 
            this.textBoxD20Extra.Location = new System.Drawing.Point(183, 163);
            this.textBoxD20Extra.Name = "textBoxD20Extra";
            this.textBoxD20Extra.Size = new System.Drawing.Size(31, 20);
            this.textBoxD20Extra.TabIndex = 5;
            // 
            // d4RollNum
            // 
            this.d4RollNum.Location = new System.Drawing.Point(18, 19);
            this.d4RollNum.Name = "d4RollNum";
            this.d4RollNum.Size = new System.Drawing.Size(40, 20);
            this.d4RollNum.TabIndex = 5;
            // 
            // diceGroupBox
            // 
            this.diceGroupBox.Controls.Add(this.panel1);
            this.diceGroupBox.Controls.Add(this.chkbox_d20Vantage);
            this.diceGroupBox.Controls.Add(this.chkbox_d12Vantage);
            this.diceGroupBox.Controls.Add(this.chkbox_d10Vantage);
            this.diceGroupBox.Controls.Add(this.chkbox_d8Vantage);
            this.diceGroupBox.Controls.Add(this.chkbox_d6Vantage);
            this.diceGroupBox.Controls.Add(this.chkbox_d4Vantage);
            this.diceGroupBox.Controls.Add(this.label_d20Result);
            this.diceGroupBox.Controls.Add(this.label_d12Result);
            this.diceGroupBox.Controls.Add(this.label_d8Result);
            this.diceGroupBox.Controls.Add(this.label_d10Result);
            this.diceGroupBox.Controls.Add(this.label_d6Result);
            this.diceGroupBox.Controls.Add(this.label_d4Result);
            this.diceGroupBox.Controls.Add(this.d4RollNum);
            this.diceGroupBox.Controls.Add(this.textBoxD20Extra);
            this.diceGroupBox.Controls.Add(this.label4);
            this.diceGroupBox.Controls.Add(this.textBoxD10Extra);
            this.diceGroupBox.Controls.Add(this.btn_d4);
            this.diceGroupBox.Controls.Add(this.textBoxD6Extra);
            this.diceGroupBox.Controls.Add(this.label6);
            this.diceGroupBox.Controls.Add(this.label5);
            this.diceGroupBox.Controls.Add(this.textBoxD12Extra);
            this.diceGroupBox.Controls.Add(this.label8);
            this.diceGroupBox.Controls.Add(this.btn_d8);
            this.diceGroupBox.Controls.Add(this.textBoxD8Extra);
            this.diceGroupBox.Controls.Add(this.btn_d6);
            this.diceGroupBox.Controls.Add(this.textBoxD4Extra);
            this.diceGroupBox.Controls.Add(this.btn_d12);
            this.diceGroupBox.Controls.Add(this.d20RollNum);
            this.diceGroupBox.Controls.Add(this.label7);
            this.diceGroupBox.Controls.Add(this.btn_d10);
            this.diceGroupBox.Controls.Add(this.btn_rollDiceBox);
            this.diceGroupBox.Controls.Add(this.label9);
            this.diceGroupBox.Controls.Add(this.d10RollNum);
            this.diceGroupBox.Controls.Add(this.btn_d20);
            this.diceGroupBox.Controls.Add(this.d6RollNum);
            this.diceGroupBox.Controls.Add(this.d8RollNum);
            this.diceGroupBox.Controls.Add(this.d12RollNum);
            this.diceGroupBox.Location = new System.Drawing.Point(312, 12);
            this.diceGroupBox.Name = "diceGroupBox";
            this.diceGroupBox.Size = new System.Drawing.Size(451, 318);
            this.diceGroupBox.TabIndex = 7;
            this.diceGroupBox.TabStop = false;
            this.diceGroupBox.Text = "Dice Box";
            // 
            // label_d4Result
            // 
            this.label_d4Result.AutoSize = true;
            this.label_d4Result.Location = new System.Drawing.Point(234, 27);
            this.label_d4Result.Name = "label_d4Result";
            this.label_d4Result.Size = new System.Drawing.Size(41, 13);
            this.label_d4Result.TabIndex = 6;
            this.label_d4Result.Text = "label11";
            // 
            // label_d6Result
            // 
            this.label_d6Result.AutoSize = true;
            this.label_d6Result.Location = new System.Drawing.Point(234, 56);
            this.label_d6Result.Name = "label_d6Result";
            this.label_d6Result.Size = new System.Drawing.Size(41, 13);
            this.label_d6Result.TabIndex = 6;
            this.label_d6Result.Text = "label11";
            // 
            // label_d8Result
            // 
            this.label_d8Result.AutoSize = true;
            this.label_d8Result.Location = new System.Drawing.Point(234, 84);
            this.label_d8Result.Name = "label_d8Result";
            this.label_d8Result.Size = new System.Drawing.Size(41, 13);
            this.label_d8Result.TabIndex = 6;
            this.label_d8Result.Text = "label11";
            // 
            // label_d10Result
            // 
            this.label_d10Result.AutoSize = true;
            this.label_d10Result.Location = new System.Drawing.Point(234, 109);
            this.label_d10Result.Name = "label_d10Result";
            this.label_d10Result.Size = new System.Drawing.Size(41, 13);
            this.label_d10Result.TabIndex = 6;
            this.label_d10Result.Text = "label11";
            // 
            // label_d12Result
            // 
            this.label_d12Result.AutoSize = true;
            this.label_d12Result.Location = new System.Drawing.Point(234, 138);
            this.label_d12Result.Name = "label_d12Result";
            this.label_d12Result.Size = new System.Drawing.Size(41, 13);
            this.label_d12Result.TabIndex = 6;
            this.label_d12Result.Text = "label11";
            // 
            // label_d20Result
            // 
            this.label_d20Result.AutoSize = true;
            this.label_d20Result.Location = new System.Drawing.Point(234, 166);
            this.label_d20Result.Name = "label_d20Result";
            this.label_d20Result.Size = new System.Drawing.Size(41, 13);
            this.label_d20Result.TabIndex = 6;
            this.label_d20Result.Text = "label11";
            // 
            // chkbox_d4Vantage
            // 
            this.chkbox_d4Vantage.AutoSize = true;
            this.chkbox_d4Vantage.Location = new System.Drawing.Point(290, 23);
            this.chkbox_d4Vantage.Name = "chkbox_d4Vantage";
            this.chkbox_d4Vantage.Size = new System.Drawing.Size(65, 17);
            this.chkbox_d4Vantage.TabIndex = 7;
            this.chkbox_d4Vantage.Text = "Dis / Ad";
            this.chkbox_d4Vantage.UseVisualStyleBackColor = true;
            // 
            // chkbox_d6Vantage
            // 
            this.chkbox_d6Vantage.AutoSize = true;
            this.chkbox_d6Vantage.Location = new System.Drawing.Point(290, 52);
            this.chkbox_d6Vantage.Name = "chkbox_d6Vantage";
            this.chkbox_d6Vantage.Size = new System.Drawing.Size(65, 17);
            this.chkbox_d6Vantage.TabIndex = 7;
            this.chkbox_d6Vantage.Text = "Dis / Ad";
            this.chkbox_d6Vantage.UseVisualStyleBackColor = true;
            // 
            // chkbox_d8Vantage
            // 
            this.chkbox_d8Vantage.AutoSize = true;
            this.chkbox_d8Vantage.Location = new System.Drawing.Point(290, 80);
            this.chkbox_d8Vantage.Name = "chkbox_d8Vantage";
            this.chkbox_d8Vantage.Size = new System.Drawing.Size(65, 17);
            this.chkbox_d8Vantage.TabIndex = 7;
            this.chkbox_d8Vantage.Text = "Dis / Ad";
            this.chkbox_d8Vantage.UseVisualStyleBackColor = true;
            // 
            // chkbox_d10Vantage
            // 
            this.chkbox_d10Vantage.AutoSize = true;
            this.chkbox_d10Vantage.Location = new System.Drawing.Point(290, 109);
            this.chkbox_d10Vantage.Name = "chkbox_d10Vantage";
            this.chkbox_d10Vantage.Size = new System.Drawing.Size(65, 17);
            this.chkbox_d10Vantage.TabIndex = 7;
            this.chkbox_d10Vantage.Text = "Dis / Ad";
            this.chkbox_d10Vantage.UseVisualStyleBackColor = true;
            // 
            // chkbox_d12Vantage
            // 
            this.chkbox_d12Vantage.AutoSize = true;
            this.chkbox_d12Vantage.Location = new System.Drawing.Point(290, 137);
            this.chkbox_d12Vantage.Name = "chkbox_d12Vantage";
            this.chkbox_d12Vantage.Size = new System.Drawing.Size(65, 17);
            this.chkbox_d12Vantage.TabIndex = 7;
            this.chkbox_d12Vantage.Text = "Dis / Ad";
            this.chkbox_d12Vantage.UseVisualStyleBackColor = true;
            // 
            // chkbox_d20Vantage
            // 
            this.chkbox_d20Vantage.AutoSize = true;
            this.chkbox_d20Vantage.Location = new System.Drawing.Point(290, 166);
            this.chkbox_d20Vantage.Name = "chkbox_d20Vantage";
            this.chkbox_d20Vantage.Size = new System.Drawing.Size(65, 17);
            this.chkbox_d20Vantage.TabIndex = 7;
            this.chkbox_d20Vantage.Text = "Dis / Ad";
            this.chkbox_d20Vantage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Location = new System.Drawing.Point(198, 212);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 8;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(29, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Advantage";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(29, 39);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(91, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Disadvantage";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label_manualRollResult
            // 
            this.label_manualRollResult.AutoSize = true;
            this.label_manualRollResult.Location = new System.Drawing.Point(11, 210);
            this.label_manualRollResult.Name = "label_manualRollResult";
            this.label_manualRollResult.Size = new System.Drawing.Size(41, 13);
            this.label_manualRollResult.TabIndex = 6;
            this.label_manualRollResult.Text = "label11";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(903, 681);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.rollGroupBox.ResumeLayout(false);
            this.rollGroupBox.PerformLayout();
            this.characterGroupBox.ResumeLayout(false);
            this.characterGroupBox.PerformLayout();
            this.fileGroupBox.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tab_overview.ResumeLayout(false);
            this.tab_map.ResumeLayout(false);
            this.diceGroupBox.ResumeLayout(false);
            this.diceGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox rollGroupBox;
        private System.Windows.Forms.Button btn_openCharSheet;
        private System.Windows.Forms.GroupBox characterGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox fileGroupBox;
        private System.Windows.Forms.Button openListBtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox hpMaxTB;
        private System.Windows.Forms.TextBox acTB;
        private System.Windows.Forms.TextBox hpCurrentTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label acLabel;
        private System.Windows.Forms.TextBox charNameTB;
        private System.Windows.Forms.ListBox openedItemsListBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_rollString;
        private System.Windows.Forms.Button btn_ManualRoll;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tab_overview;
        private System.Windows.Forms.TabPage tab_map;
        private System.Windows.Forms.WebBrowser mapBrowser;
        private System.Windows.Forms.Button mapSelection;
        private System.Windows.Forms.ListBox rollChest;
        private System.Windows.Forms.Button btn_addCustomRoll;
        private System.Windows.Forms.Button btn_modifyCustomRoll;
        private System.Windows.Forms.Button btn_deleteCustomRoll;
        private System.Windows.Forms.GroupBox diceGroupBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox chkbox_d20Vantage;
        private System.Windows.Forms.CheckBox chkbox_d12Vantage;
        private System.Windows.Forms.CheckBox chkbox_d10Vantage;
        private System.Windows.Forms.CheckBox chkbox_d8Vantage;
        private System.Windows.Forms.CheckBox chkbox_d6Vantage;
        private System.Windows.Forms.CheckBox chkbox_d4Vantage;
        private System.Windows.Forms.Label label_d20Result;
        private System.Windows.Forms.Label label_d12Result;
        private System.Windows.Forms.Label label_d8Result;
        private System.Windows.Forms.Label label_d10Result;
        private System.Windows.Forms.Label label_d6Result;
        private System.Windows.Forms.Label label_d4Result;
        private System.Windows.Forms.TextBox d4RollNum;
        private System.Windows.Forms.TextBox textBoxD20Extra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxD10Extra;
        private System.Windows.Forms.Button btn_d4;
        private System.Windows.Forms.TextBox textBoxD6Extra;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxD12Extra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_d8;
        private System.Windows.Forms.TextBox textBoxD8Extra;
        private System.Windows.Forms.Button btn_d6;
        private System.Windows.Forms.TextBox textBoxD4Extra;
        private System.Windows.Forms.Button btn_d12;
        private System.Windows.Forms.TextBox d20RollNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_d10;
        private System.Windows.Forms.Button btn_rollDiceBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox d10RollNum;
        private System.Windows.Forms.Button btn_d20;
        private System.Windows.Forms.TextBox d6RollNum;
        private System.Windows.Forms.TextBox d8RollNum;
        private System.Windows.Forms.TextBox d12RollNum;
        private System.Windows.Forms.Label label_manualRollResult;
    }
}

