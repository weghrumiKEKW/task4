namespace task4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button2 = new Button();
            btnExit = new Button();
            panel3 = new Panel();
            button5 = new Button();
            button4 = new Button();
            txtHistory = new TextBox();
            textBox2 = new TextBox();
            txtDisplay = new TextBox();
            button1 = new Button();
            BtnClearEntry = new Button();
            BtnClear = new Button();
            BtnBackSpace = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button17 = new Button();
            button18 = new Button();
            button19 = new Button();
            button20 = new Button();
            button21 = new Button();
            button22 = new Button();
            button23 = new Button();
            button24 = new Button();
            BtnEqual = new Button();
            button26 = new Button();
            button27 = new Button();
            BtnNegate = new Button();
            lstHistory = new ListBox();
            label1 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 51);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(btnExit);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(460, 51);
            panel2.TabIndex = 1;
            panel2.MouseDown += panel2_MouseDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(50, 11);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 5;
            label2.Text = "Calculator";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.calculator2;
            pictureBox1.Location = new Point(12, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 37);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Right;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Properties.Resources.minus;
            button3.Location = new Point(310, 0);
            button3.Name = "button3";
            button3.Size = new Size(50, 51);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.square;
            button2.Location = new Point(360, 0);
            button2.Name = "button2";
            button2.Size = new Size(50, 51);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Right;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseOverBackColor = Color.Red;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Image = Properties.Resources.close;
            btnExit.Location = new Point(410, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(50, 51);
            btnExit.TabIndex = 0;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 51);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(460, 51);
            panel3.TabIndex = 1;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Left;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Image = Properties.Resources.menu;
            button5.Location = new Point(0, 0);
            button5.Name = "button5";
            button5.Size = new Size(50, 51);
            button5.TabIndex = 2;
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Right;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = Properties.Resources.history;
            button4.Location = new Point(410, 0);
            button4.Name = "button4";
            button4.Size = new Size(50, 51);
            button4.TabIndex = 1;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txtHistory
            // 
            txtHistory.BackColor = Color.FromArgb(32, 32, 32);
            txtHistory.BorderStyle = BorderStyle.None;
            txtHistory.Dock = DockStyle.Top;
            txtHistory.Font = new Font("Segoe UI", 11F);
            txtHistory.ForeColor = Color.DarkGray;
            txtHistory.Location = new Point(0, 102);
            txtHistory.Multiline = true;
            txtHistory.Name = "txtHistory";
            txtHistory.Size = new Size(460, 40);
            txtHistory.TabIndex = 2;
            txtHistory.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(32, 32, 32);
            textBox2.Dock = DockStyle.Top;
            textBox2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox2.ForeColor = Color.DarkGray;
            textBox2.Location = new Point(0, 142);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(460, 0);
            textBox2.TabIndex = 3;
            textBox2.Text = "3131";
            textBox2.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDisplay
            // 
            txtDisplay.BackColor = Color.FromArgb(32, 32, 32);
            txtDisplay.BorderStyle = BorderStyle.None;
            txtDisplay.Dock = DockStyle.Top;
            txtDisplay.Font = new Font("Segoe UI", 27F);
            txtDisplay.ForeColor = Color.WhiteSmoke;
            txtDisplay.Location = new Point(0, 142);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(460, 67);
            txtDisplay.TabIndex = 4;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(48, 48, 48);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(0, 215);
            button1.Name = "button1";
            button1.Size = new Size(110, 60);
            button1.TabIndex = 5;
            button1.Text = "%";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnInstantOperator_Click;
            // 
            // BtnClearEntry
            // 
            BtnClearEntry.BackColor = Color.FromArgb(48, 48, 48);
            BtnClearEntry.FlatAppearance.BorderSize = 0;
            BtnClearEntry.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            BtnClearEntry.FlatStyle = FlatStyle.Flat;
            BtnClearEntry.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnClearEntry.ForeColor = Color.WhiteSmoke;
            BtnClearEntry.Location = new Point(116, 215);
            BtnClearEntry.Name = "BtnClearEntry";
            BtnClearEntry.Size = new Size(110, 60);
            BtnClearEntry.TabIndex = 6;
            BtnClearEntry.Text = "CE";
            BtnClearEntry.UseVisualStyleBackColor = false;
            BtnClearEntry.Click += BtnClearEntry_Click;
            // 
            // BtnClear
            // 
            BtnClear.BackColor = Color.FromArgb(48, 48, 48);
            BtnClear.FlatAppearance.BorderSize = 0;
            BtnClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            BtnClear.FlatStyle = FlatStyle.Flat;
            BtnClear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            BtnClear.ForeColor = Color.WhiteSmoke;
            BtnClear.Location = new Point(232, 215);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(110, 60);
            BtnClear.TabIndex = 7;
            BtnClear.Text = "C";
            BtnClear.UseVisualStyleBackColor = false;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnBackSpace
            // 
            BtnBackSpace.BackColor = Color.FromArgb(48, 48, 48);
            BtnBackSpace.FlatAppearance.BorderSize = 0;
            BtnBackSpace.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            BtnBackSpace.FlatStyle = FlatStyle.Flat;
            BtnBackSpace.ForeColor = Color.WhiteSmoke;
            BtnBackSpace.Image = Properties.Resources.delete;
            BtnBackSpace.Location = new Point(348, 215);
            BtnBackSpace.Name = "BtnBackSpace";
            BtnBackSpace.Size = new Size(110, 60);
            BtnBackSpace.TabIndex = 8;
            BtnBackSpace.UseVisualStyleBackColor = false;
            BtnBackSpace.Click += BtnBackSpace_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(48, 48, 48);
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Segoe UI", 12F);
            button9.ForeColor = Color.WhiteSmoke;
            button9.Location = new Point(348, 281);
            button9.Name = "button9";
            button9.Size = new Size(110, 60);
            button9.TabIndex = 12;
            button9.Text = "/";
            button9.UseVisualStyleBackColor = false;
            button9.Click += BtnOperator_Click;
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(48, 48, 48);
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Segoe UI", 12F);
            button10.ForeColor = Color.WhiteSmoke;
            button10.Location = new Point(232, 281);
            button10.Name = "button10";
            button10.Size = new Size(110, 60);
            button10.TabIndex = 11;
            button10.Text = "sqrt";
            button10.UseVisualStyleBackColor = false;
            button10.Click += btnInstantOperator_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(48, 48, 48);
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Segoe UI", 12F);
            button11.ForeColor = Color.WhiteSmoke;
            button11.Location = new Point(116, 281);
            button11.Name = "button11";
            button11.RightToLeft = RightToLeft.No;
            button11.Size = new Size(110, 60);
            button11.TabIndex = 10;
            button11.Text = "x²";
            button11.UseVisualStyleBackColor = false;
            button11.Click += btnInstantOperator_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(48, 48, 48);
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Segoe UI", 12F);
            button12.ForeColor = Color.WhiteSmoke;
            button12.Location = new Point(0, 281);
            button12.Name = "button12";
            button12.Size = new Size(110, 60);
            button12.TabIndex = 9;
            button12.Text = "1/x";
            button12.UseVisualStyleBackColor = false;
            button12.Click += btnInstantOperator_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(48, 48, 48);
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Segoe UI", 14F);
            button13.ForeColor = Color.WhiteSmoke;
            button13.Location = new Point(348, 347);
            button13.Name = "button13";
            button13.Size = new Size(110, 60);
            button13.TabIndex = 16;
            button13.Text = "x";
            button13.UseVisualStyleBackColor = false;
            button13.Click += BtnOperator_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.FromArgb(64, 64, 64);
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 48, 48);
            button14.FlatStyle = FlatStyle.Flat;
            button14.Font = new Font("Segoe UI", 12F);
            button14.ForeColor = Color.WhiteSmoke;
            button14.Location = new Point(232, 347);
            button14.Name = "button14";
            button14.Size = new Size(110, 60);
            button14.TabIndex = 15;
            button14.Text = "9";
            button14.UseVisualStyleBackColor = false;
            button14.Click += BtnNumber_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.FromArgb(64, 64, 64);
            button15.FlatAppearance.BorderSize = 0;
            button15.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 48, 48);
            button15.FlatStyle = FlatStyle.Flat;
            button15.Font = new Font("Segoe UI", 12F);
            button15.ForeColor = Color.WhiteSmoke;
            button15.Location = new Point(116, 347);
            button15.Name = "button15";
            button15.Size = new Size(110, 60);
            button15.TabIndex = 14;
            button15.Text = "8";
            button15.UseVisualStyleBackColor = false;
            button15.Click += BtnNumber_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.FromArgb(64, 64, 64);
            button16.FlatAppearance.BorderSize = 0;
            button16.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 48, 48);
            button16.FlatStyle = FlatStyle.Flat;
            button16.Font = new Font("Segoe UI", 12F);
            button16.ForeColor = Color.WhiteSmoke;
            button16.Location = new Point(0, 347);
            button16.Name = "button16";
            button16.Size = new Size(110, 60);
            button16.TabIndex = 13;
            button16.Text = "7";
            button16.UseVisualStyleBackColor = false;
            button16.Click += BtnNumber_Click;
            // 
            // button17
            // 
            button17.BackColor = Color.FromArgb(48, 48, 48);
            button17.FlatAppearance.BorderSize = 0;
            button17.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button17.FlatStyle = FlatStyle.Flat;
            button17.Font = new Font("Segoe UI", 19F);
            button17.ForeColor = Color.WhiteSmoke;
            button17.Location = new Point(348, 413);
            button17.Name = "button17";
            button17.Size = new Size(110, 60);
            button17.TabIndex = 20;
            button17.Text = "-";
            button17.UseVisualStyleBackColor = false;
            button17.Click += BtnOperator_Click;
            // 
            // button18
            // 
            button18.BackColor = Color.FromArgb(64, 64, 64);
            button18.FlatAppearance.BorderSize = 0;
            button18.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 48, 48);
            button18.FlatStyle = FlatStyle.Flat;
            button18.Font = new Font("Segoe UI", 12F);
            button18.ForeColor = Color.WhiteSmoke;
            button18.Location = new Point(232, 413);
            button18.Name = "button18";
            button18.Size = new Size(110, 60);
            button18.TabIndex = 19;
            button18.Text = "6";
            button18.UseVisualStyleBackColor = false;
            button18.Click += BtnNumber_Click;
            // 
            // button19
            // 
            button19.BackColor = Color.FromArgb(64, 64, 64);
            button19.FlatAppearance.BorderSize = 0;
            button19.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 48, 48);
            button19.FlatStyle = FlatStyle.Flat;
            button19.Font = new Font("Segoe UI", 12F);
            button19.ForeColor = Color.WhiteSmoke;
            button19.Location = new Point(116, 413);
            button19.Name = "button19";
            button19.Size = new Size(110, 60);
            button19.TabIndex = 18;
            button19.Text = "5";
            button19.UseVisualStyleBackColor = false;
            button19.Click += BtnNumber_Click;
            // 
            // button20
            // 
            button20.BackColor = Color.FromArgb(64, 64, 64);
            button20.FlatAppearance.BorderSize = 0;
            button20.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 48, 48);
            button20.FlatStyle = FlatStyle.Flat;
            button20.Font = new Font("Segoe UI", 12F);
            button20.ForeColor = Color.WhiteSmoke;
            button20.Location = new Point(0, 413);
            button20.Name = "button20";
            button20.Size = new Size(110, 60);
            button20.TabIndex = 17;
            button20.Text = "4";
            button20.UseVisualStyleBackColor = false;
            button20.Click += BtnNumber_Click;
            // 
            // button21
            // 
            button21.BackColor = Color.FromArgb(48, 48, 48);
            button21.FlatAppearance.BorderSize = 0;
            button21.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button21.FlatStyle = FlatStyle.Flat;
            button21.Font = new Font("Segoe UI", 16F);
            button21.ForeColor = Color.WhiteSmoke;
            button21.Location = new Point(348, 479);
            button21.Name = "button21";
            button21.Size = new Size(110, 60);
            button21.TabIndex = 24;
            button21.Text = "+";
            button21.UseVisualStyleBackColor = false;
            button21.Click += BtnOperator_Click;
            // 
            // button22
            // 
            button22.BackColor = Color.FromArgb(64, 64, 64);
            button22.FlatAppearance.BorderSize = 0;
            button22.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 48, 48);
            button22.FlatStyle = FlatStyle.Flat;
            button22.Font = new Font("Segoe UI", 12F);
            button22.ForeColor = Color.WhiteSmoke;
            button22.Location = new Point(232, 479);
            button22.Name = "button22";
            button22.Size = new Size(110, 60);
            button22.TabIndex = 23;
            button22.Text = "3";
            button22.UseVisualStyleBackColor = false;
            button22.Click += BtnNumber_Click;
            // 
            // button23
            // 
            button23.BackColor = Color.FromArgb(64, 64, 64);
            button23.FlatAppearance.BorderSize = 0;
            button23.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 48, 48);
            button23.FlatStyle = FlatStyle.Flat;
            button23.Font = new Font("Segoe UI", 12F);
            button23.ForeColor = Color.WhiteSmoke;
            button23.Location = new Point(116, 479);
            button23.Name = "button23";
            button23.Size = new Size(110, 60);
            button23.TabIndex = 22;
            button23.Text = "2";
            button23.UseVisualStyleBackColor = false;
            button23.Click += BtnNumber_Click;
            // 
            // button24
            // 
            button24.BackColor = Color.FromArgb(64, 64, 64);
            button24.FlatAppearance.BorderSize = 0;
            button24.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 48, 48);
            button24.FlatStyle = FlatStyle.Flat;
            button24.Font = new Font("Segoe UI", 12F);
            button24.ForeColor = Color.WhiteSmoke;
            button24.Location = new Point(0, 479);
            button24.Name = "button24";
            button24.Size = new Size(110, 60);
            button24.TabIndex = 21;
            button24.Text = "1";
            button24.UseVisualStyleBackColor = false;
            button24.Click += BtnNumber_Click;
            // 
            // BtnEqual
            // 
            BtnEqual.BackColor = Color.FromArgb(192, 192, 255);
            BtnEqual.FlatAppearance.BorderSize = 0;
            BtnEqual.FlatStyle = FlatStyle.Flat;
            BtnEqual.Font = new Font("Segoe UI", 16F);
            BtnEqual.ForeColor = Color.FromArgb(32, 32, 32);
            BtnEqual.Location = new Point(348, 545);
            BtnEqual.Name = "BtnEqual";
            BtnEqual.Size = new Size(110, 60);
            BtnEqual.TabIndex = 28;
            BtnEqual.Text = "=";
            BtnEqual.UseVisualStyleBackColor = false;
            BtnEqual.Click += BtnEqual_Click;
            // 
            // button26
            // 
            button26.BackColor = Color.FromArgb(64, 64, 64);
            button26.FlatAppearance.BorderSize = 0;
            button26.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 48, 48);
            button26.FlatStyle = FlatStyle.Flat;
            button26.ForeColor = Color.WhiteSmoke;
            button26.Location = new Point(232, 545);
            button26.Name = "button26";
            button26.Size = new Size(110, 60);
            button26.TabIndex = 27;
            button26.Text = ",";
            button26.UseVisualStyleBackColor = false;
            button26.Click += BtnNumber_Click;
            // 
            // button27
            // 
            button27.BackColor = Color.FromArgb(64, 64, 64);
            button27.FlatAppearance.BorderSize = 0;
            button27.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 48, 48);
            button27.FlatStyle = FlatStyle.Flat;
            button27.Font = new Font("Segoe UI", 12F);
            button27.ForeColor = Color.WhiteSmoke;
            button27.Location = new Point(116, 545);
            button27.Name = "button27";
            button27.Size = new Size(110, 60);
            button27.TabIndex = 26;
            button27.Text = "0";
            button27.UseVisualStyleBackColor = false;
            button27.Click += BtnNumber_Click;
            // 
            // BtnNegate
            // 
            BtnNegate.BackColor = Color.FromArgb(64, 64, 64);
            BtnNegate.FlatAppearance.BorderSize = 0;
            BtnNegate.FlatAppearance.MouseOverBackColor = Color.FromArgb(48, 48, 48);
            BtnNegate.FlatStyle = FlatStyle.Flat;
            BtnNegate.Font = new Font("Segoe UI", 12F);
            BtnNegate.ForeColor = Color.WhiteSmoke;
            BtnNegate.Location = new Point(0, 545);
            BtnNegate.Name = "BtnNegate";
            BtnNegate.Size = new Size(110, 60);
            BtnNegate.TabIndex = 25;
            BtnNegate.Text = "+/-";
            BtnNegate.UseVisualStyleBackColor = false;
            // 
            // lstHistory
            // 
            lstHistory.BackColor = Color.FromArgb(48, 48, 48);
            lstHistory.BorderStyle = BorderStyle.None;
            lstHistory.Font = new Font("Segoe UI", 12F);
            lstHistory.ForeColor = Color.WhiteSmoke;
            lstHistory.FormattingEnabled = true;
            lstHistory.Location = new Point(0, 227);
            lstHistory.Name = "lstHistory";
            lstHistory.Size = new Size(458, 378);
            lstHistory.TabIndex = 29;
            lstHistory.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(48, 48, 48);
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(148, 19);
            label1.TabIndex = 30;
            label1.Text = "There is no history yet.";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(50, 8);
            label3.Name = "label3";
            label3.Size = new Size(107, 30);
            label3.TabIndex = 6;
            label3.Text = "Standard";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(460, 605);
            Controls.Add(BtnEqual);
            Controls.Add(button26);
            Controls.Add(button27);
            Controls.Add(BtnNegate);
            Controls.Add(button21);
            Controls.Add(button22);
            Controls.Add(button23);
            Controls.Add(button24);
            Controls.Add(button17);
            Controls.Add(button18);
            Controls.Add(button19);
            Controls.Add(button20);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button16);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(BtnBackSpace);
            Controls.Add(BtnClear);
            Controls.Add(BtnClearEntry);
            Controls.Add(button1);
            Controls.Add(txtDisplay);
            Controls.Add(textBox2);
            Controls.Add(txtHistory);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(lstHistory);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button3;
        private Button button2;
        private Button btnExit;
        private Panel panel3;
        private Button button5;
        private Button button4;
        private TextBox txtHistory;
        private TextBox textBox2;
        private TextBox txtDisplay;
        private Button button1;
        private Button BtnClearEntry;
        private Button BtnClear;
        private Button BtnBackSpace;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button17;
        private Button button18;
        private Button button19;
        private Button button20;
        private Button button21;
        private Button button22;
        private Button button23;
        private Button button24;
        private Button BtnEqual;
        private Button button26;
        private Button button27;
        private Button BtnNegate;
        private ListBox lstHistory;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
    }
}
