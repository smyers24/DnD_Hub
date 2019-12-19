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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.rollGroupBox = new System.Windows.Forms.GroupBox();
            this.rollChest = new System.Windows.Forms.ListBox();
            this.diceGroupBox = new System.Windows.Forms.GroupBox();
            this.d4RollNum = new System.Windows.Forms.TextBox();
            this.textBoxD20Extra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxD10Extra = new System.Windows.Forms.TextBox();
            this.d4Button = new System.Windows.Forms.Button();
            this.textBoxD6Extra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxD12Extra = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.d8Button = new System.Windows.Forms.Button();
            this.textBoxD8Extra = new System.Windows.Forms.TextBox();
            this.d6Button = new System.Windows.Forms.Button();
            this.textBoxD4Extra = new System.Windows.Forms.TextBox();
            this.d12Button = new System.Windows.Forms.Button();
            this.d20RollNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.d10Button = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.d10RollNum = new System.Windows.Forms.TextBox();
            this.d20Button = new System.Windows.Forms.Button();
            this.d6RollNum = new System.Windows.Forms.TextBox();
            this.d8RollNum = new System.Windows.Forms.TextBox();
            this.d12RollNum = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.addCustomRoll = new System.Windows.Forms.Button();
            this.modifyCustomRoll = new System.Windows.Forms.Button();
            this.deleteCustomRoll = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.mapBrowser = new System.Windows.Forms.WebBrowser();
            this.rollGroupBox.SuspendLayout();
            this.diceGroupBox.SuspendLayout();
            this.characterGroupBox.SuspendLayout();
            this.fileGroupBox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(658, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Standard Hit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(740, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Standard Crit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(658, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "Rage Hit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(750, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Rage Crit";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // rollGroupBox
            // 
            this.rollGroupBox.Controls.Add(this.rollChest);
            this.rollGroupBox.Controls.Add(this.diceGroupBox);
            this.rollGroupBox.Controls.Add(this.checkBox1);
            this.rollGroupBox.Controls.Add(this.label10);
            this.rollGroupBox.Controls.Add(this.textBox1);
            this.rollGroupBox.Controls.Add(this.addCustomRoll);
            this.rollGroupBox.Controls.Add(this.modifyCustomRoll);
            this.rollGroupBox.Controls.Add(this.deleteCustomRoll);
            this.rollGroupBox.Controls.Add(this.button9);
            this.rollGroupBox.Location = new System.Drawing.Point(22, 208);
            this.rollGroupBox.Name = "rollGroupBox";
            this.rollGroupBox.Size = new System.Drawing.Size(555, 264);
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
            // diceGroupBox
            // 
            this.diceGroupBox.Controls.Add(this.d4RollNum);
            this.diceGroupBox.Controls.Add(this.textBoxD20Extra);
            this.diceGroupBox.Controls.Add(this.label4);
            this.diceGroupBox.Controls.Add(this.textBoxD10Extra);
            this.diceGroupBox.Controls.Add(this.d4Button);
            this.diceGroupBox.Controls.Add(this.textBoxD6Extra);
            this.diceGroupBox.Controls.Add(this.label6);
            this.diceGroupBox.Controls.Add(this.label5);
            this.diceGroupBox.Controls.Add(this.textBoxD12Extra);
            this.diceGroupBox.Controls.Add(this.label8);
            this.diceGroupBox.Controls.Add(this.d8Button);
            this.diceGroupBox.Controls.Add(this.textBoxD8Extra);
            this.diceGroupBox.Controls.Add(this.d6Button);
            this.diceGroupBox.Controls.Add(this.textBoxD4Extra);
            this.diceGroupBox.Controls.Add(this.d12Button);
            this.diceGroupBox.Controls.Add(this.d20RollNum);
            this.diceGroupBox.Controls.Add(this.label7);
            this.diceGroupBox.Controls.Add(this.d10Button);
            this.diceGroupBox.Controls.Add(this.button8);
            this.diceGroupBox.Controls.Add(this.label9);
            this.diceGroupBox.Controls.Add(this.d10RollNum);
            this.diceGroupBox.Controls.Add(this.d20Button);
            this.diceGroupBox.Controls.Add(this.d6RollNum);
            this.diceGroupBox.Controls.Add(this.d8RollNum);
            this.diceGroupBox.Controls.Add(this.d12RollNum);
            this.diceGroupBox.Location = new System.Drawing.Point(324, 12);
            this.diceGroupBox.Name = "diceGroupBox";
            this.diceGroupBox.Size = new System.Drawing.Size(216, 239);
            this.diceGroupBox.TabIndex = 7;
            this.diceGroupBox.TabStop = false;
            this.diceGroupBox.Text = "Dice Box";
            // 
            // d4RollNum
            // 
            this.d4RollNum.Location = new System.Drawing.Point(18, 19);
            this.d4RollNum.Name = "d4RollNum";
            this.d4RollNum.Size = new System.Drawing.Size(37, 20);
            this.d4RollNum.TabIndex = 5;
            // 
            // textBoxD20Extra
            // 
            this.textBoxD20Extra.Location = new System.Drawing.Point(123, 162);
            this.textBoxD20Extra.Name = "textBoxD20Extra";
            this.textBoxD20Extra.Size = new System.Drawing.Size(31, 20);
            this.textBoxD20Extra.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "+/-";
            // 
            // textBoxD10Extra
            // 
            this.textBoxD10Extra.Location = new System.Drawing.Point(123, 105);
            this.textBoxD10Extra.Name = "textBoxD10Extra";
            this.textBoxD10Extra.Size = new System.Drawing.Size(31, 20);
            this.textBoxD10Extra.TabIndex = 5;
            // 
            // d4Button
            // 
            this.d4Button.Location = new System.Drawing.Point(61, 16);
            this.d4Button.Name = "d4Button";
            this.d4Button.Size = new System.Drawing.Size(34, 23);
            this.d4Button.TabIndex = 1;
            this.d4Button.Text = "d4";
            this.d4Button.UseVisualStyleBackColor = true;
            this.d4Button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.manualRoll);
            // 
            // textBoxD6Extra
            // 
            this.textBoxD6Extra.Location = new System.Drawing.Point(123, 48);
            this.textBoxD6Extra.Name = "textBoxD6Extra";
            this.textBoxD6Extra.Size = new System.Drawing.Size(31, 20);
            this.textBoxD6Extra.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "+/-";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "+/-";
            // 
            // textBoxD12Extra
            // 
            this.textBoxD12Extra.Location = new System.Drawing.Point(123, 133);
            this.textBoxD12Extra.Name = "textBoxD12Extra";
            this.textBoxD12Extra.Size = new System.Drawing.Size(31, 20);
            this.textBoxD12Extra.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(101, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "+/-";
            // 
            // d8Button
            // 
            this.d8Button.Location = new System.Drawing.Point(61, 73);
            this.d8Button.Name = "d8Button";
            this.d8Button.Size = new System.Drawing.Size(34, 23);
            this.d8Button.TabIndex = 1;
            this.d8Button.Text = "d8";
            this.d8Button.UseVisualStyleBackColor = true;
            this.d8Button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.manualRoll);
            // 
            // textBoxD8Extra
            // 
            this.textBoxD8Extra.Location = new System.Drawing.Point(123, 76);
            this.textBoxD8Extra.Name = "textBoxD8Extra";
            this.textBoxD8Extra.Size = new System.Drawing.Size(31, 20);
            this.textBoxD8Extra.TabIndex = 5;
            // 
            // d6Button
            // 
            this.d6Button.Location = new System.Drawing.Point(61, 45);
            this.d6Button.Name = "d6Button";
            this.d6Button.Size = new System.Drawing.Size(34, 23);
            this.d6Button.TabIndex = 1;
            this.d6Button.Text = "d6";
            this.d6Button.UseVisualStyleBackColor = true;
            this.d6Button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.manualRoll);
            // 
            // textBoxD4Extra
            // 
            this.textBoxD4Extra.Location = new System.Drawing.Point(123, 19);
            this.textBoxD4Extra.Name = "textBoxD4Extra";
            this.textBoxD4Extra.Size = new System.Drawing.Size(31, 20);
            this.textBoxD4Extra.TabIndex = 5;
            // 
            // d12Button
            // 
            this.d12Button.Location = new System.Drawing.Point(61, 130);
            this.d12Button.Name = "d12Button";
            this.d12Button.Size = new System.Drawing.Size(34, 23);
            this.d12Button.TabIndex = 1;
            this.d12Button.Text = "d12";
            this.d12Button.UseVisualStyleBackColor = true;
            this.d12Button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.manualRoll);
            // 
            // d20RollNum
            // 
            this.d20RollNum.Location = new System.Drawing.Point(18, 162);
            this.d20RollNum.Name = "d20RollNum";
            this.d20RollNum.Size = new System.Drawing.Size(37, 20);
            this.d20RollNum.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "+/-";
            // 
            // d10Button
            // 
            this.d10Button.Location = new System.Drawing.Point(61, 102);
            this.d10Button.Name = "d10Button";
            this.d10Button.Size = new System.Drawing.Size(34, 23);
            this.d10Button.TabIndex = 1;
            this.d10Button.Text = "d10";
            this.d10Button.UseVisualStyleBackColor = true;
            this.d10Button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.manualRoll);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(61, 205);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 3;
            this.button8.Text = "Roll";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.rollConcat);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(101, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "+/-";
            // 
            // d10RollNum
            // 
            this.d10RollNum.Location = new System.Drawing.Point(18, 105);
            this.d10RollNum.Name = "d10RollNum";
            this.d10RollNum.Size = new System.Drawing.Size(37, 20);
            this.d10RollNum.TabIndex = 5;
            // 
            // d20Button
            // 
            this.d20Button.Location = new System.Drawing.Point(61, 159);
            this.d20Button.Name = "d20Button";
            this.d20Button.Size = new System.Drawing.Size(34, 23);
            this.d20Button.TabIndex = 1;
            this.d20Button.Text = "d20";
            this.d20Button.UseVisualStyleBackColor = true;
            this.d20Button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.manualRoll);
            // 
            // d6RollNum
            // 
            this.d6RollNum.Location = new System.Drawing.Point(18, 48);
            this.d6RollNum.Name = "d6RollNum";
            this.d6RollNum.Size = new System.Drawing.Size(37, 20);
            this.d6RollNum.TabIndex = 5;
            // 
            // d8RollNum
            // 
            this.d8RollNum.Location = new System.Drawing.Point(18, 76);
            this.d8RollNum.Name = "d8RollNum";
            this.d8RollNum.Size = new System.Drawing.Size(37, 20);
            this.d8RollNum.TabIndex = 5;
            // 
            // d12RollNum
            // 
            this.d12RollNum.Location = new System.Drawing.Point(18, 133);
            this.d12RollNum.Name = "d12RollNum";
            this.d12RollNum.Size = new System.Drawing.Size(37, 20);
            this.d12RollNum.TabIndex = 5;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 20);
            this.textBox1.TabIndex = 5;
            // 
            // addCustomRoll
            // 
            this.addCustomRoll.Location = new System.Drawing.Point(6, 120);
            this.addCustomRoll.Name = "addCustomRoll";
            this.addCustomRoll.Size = new System.Drawing.Size(75, 23);
            this.addCustomRoll.TabIndex = 3;
            this.addCustomRoll.Text = "Add";
            this.addCustomRoll.UseVisualStyleBackColor = true;
            this.addCustomRoll.Click += new System.EventHandler(this.addSavedRoll);
            // 
            // modifyCustomRoll
            // 
            this.modifyCustomRoll.Location = new System.Drawing.Point(98, 120);
            this.modifyCustomRoll.Name = "modifyCustomRoll";
            this.modifyCustomRoll.Size = new System.Drawing.Size(75, 23);
            this.modifyCustomRoll.TabIndex = 3;
            this.modifyCustomRoll.Text = "Modify";
            this.modifyCustomRoll.UseVisualStyleBackColor = true;
            // 
            // deleteCustomRoll
            // 
            this.deleteCustomRoll.Location = new System.Drawing.Point(193, 120);
            this.deleteCustomRoll.Name = "deleteCustomRoll";
            this.deleteCustomRoll.Size = new System.Drawing.Size(75, 23);
            this.deleteCustomRoll.TabIndex = 3;
            this.deleteCustomRoll.Text = "Delete";
            this.deleteCustomRoll.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(10, 217);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 3;
            this.button9.Text = "Manual Roll";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(14, 134);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(145, 23);
            this.button5.TabIndex = 3;
            this.button5.Text = "Open Character Sheet";
            this.button5.UseVisualStyleBackColor = true;
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
            this.characterGroupBox.Controls.Add(this.button5);
            this.characterGroupBox.Location = new System.Drawing.Point(22, 21);
            this.characterGroupBox.Name = "characterGroupBox";
            this.characterGroupBox.Size = new System.Drawing.Size(318, 181);
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
            this.fileGroupBox.Location = new System.Drawing.Point(346, 21);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(858, 635);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.characterGroupBox);
            this.tabPage1.Controls.Add(this.fileGroupBox);
            this.tabPage1.Controls.Add(this.rollGroupBox);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(850, 609);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.mapBrowser);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(850, 609);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(903, 666);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.rollGroupBox.ResumeLayout(false);
            this.rollGroupBox.PerformLayout();
            this.diceGroupBox.ResumeLayout(false);
            this.diceGroupBox.PerformLayout();
            this.characterGroupBox.ResumeLayout(false);
            this.characterGroupBox.PerformLayout();
            this.fileGroupBox.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox rollGroupBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox characterGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox fileGroupBox;
        private System.Windows.Forms.Button openListBtn;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBoxD20Extra;
        private System.Windows.Forms.TextBox textBoxD10Extra;
        private System.Windows.Forms.TextBox textBoxD6Extra;
        private System.Windows.Forms.TextBox textBoxD12Extra;
        private System.Windows.Forms.TextBox textBoxD8Extra;
        private System.Windows.Forms.TextBox textBoxD4Extra;
        private System.Windows.Forms.TextBox d20RollNum;
        private System.Windows.Forms.TextBox d10RollNum;
        private System.Windows.Forms.TextBox d6RollNum;
        private System.Windows.Forms.TextBox d12RollNum;
        private System.Windows.Forms.TextBox d8RollNum;
        private System.Windows.Forms.TextBox d4RollNum;
        private System.Windows.Forms.Button d20Button;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button d10Button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button d12Button;
        private System.Windows.Forms.Button d6Button;
        private System.Windows.Forms.Button d8Button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button d4Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hpMaxTB;
        private System.Windows.Forms.TextBox acTB;
        private System.Windows.Forms.TextBox hpCurrentTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label acLabel;
        private System.Windows.Forms.TextBox charNameTB;
        private System.Windows.Forms.ListBox openedItemsListBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.GroupBox diceGroupBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.WebBrowser mapBrowser;
        private System.Windows.Forms.Button mapSelection;
        private System.Windows.Forms.ListBox rollChest;
        private System.Windows.Forms.Button addCustomRoll;
        private System.Windows.Forms.Button modifyCustomRoll;
        private System.Windows.Forms.Button deleteCustomRoll;
    }
}

