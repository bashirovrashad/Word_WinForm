namespace WinFormsApp1
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
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label4 = new Label();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            label5 = new Label();
            comboBox3 = new ComboBox();
            colorDialog1 = new ColorDialog();
            fontDialog1 = new FontDialog();
            openFileDialog1 = new OpenFileDialog();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 76);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(843, 424);
            textBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(780, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 32);
            button1.TabIndex = 1;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(780, 38);
            button2.Name = "button2";
            button2.Size = new Size(75, 32);
            button2.TabIndex = 2;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Location = new Point(47, 9);
            label1.Name = "label1";
            label1.Size = new Size(51, 23);
            label1.TabIndex = 5;
            label1.Text = "Font";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 6;
            comboBox1.Enter += comboBox1_Enter;
            // 
            // label2
            // 
            label2.Location = new Point(139, 9);
            label2.Name = "label2";
            label2.Size = new Size(51, 23);
            label2.TabIndex = 7;
            label2.Text = "Size";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(139, 33);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(53, 23);
            comboBox2.TabIndex = 8;
            comboBox2.Enter += comboBox2_Enter;
            // 
            // label3
            // 
            label3.Location = new Point(234, 5);
            label3.Name = "label3";
            label3.Size = new Size(64, 23);
            label3.TabIndex = 9;
            label3.Text = "FontStlye";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(211, 33);
            button3.Name = "button3";
            button3.Size = new Size(30, 23);
            button3.TabIndex = 10;
            button3.Text = "B";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            button4.Location = new Point(247, 33);
            button4.Name = "button4";
            button4.Size = new Size(30, 23);
            button4.TabIndex = 11;
            button4.Text = "U";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            button5.Location = new Point(283, 33);
            button5.Name = "button5";
            button5.Size = new Size(30, 23);
            button5.TabIndex = 12;
            button5.Text = "I";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label4
            // 
            label4.Location = new Point(342, 6);
            label4.Name = "label4";
            label4.Size = new Size(64, 23);
            label4.TabIndex = 13;
            label4.Text = "Alignment";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button6
            // 
            button6.Location = new Point(321, 33);
            button6.Name = "button6";
            button6.Size = new Size(30, 23);
            button6.TabIndex = 14;
            button6.Text = "L";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(357, 34);
            button7.Name = "button7";
            button7.Size = new Size(30, 23);
            button7.TabIndex = 15;
            button7.Text = "C";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(393, 33);
            button8.Name = "button8";
            button8.Size = new Size(30, 23);
            button8.TabIndex = 16;
            button8.Text = "R";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // label5
            // 
            label5.Location = new Point(481, 9);
            label5.Name = "label5";
            label5.Size = new Size(64, 23);
            label5.TabIndex = 17;
            label5.Text = "Color";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(447, 34);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 18;
            comboBox3.Enter += comboBox3_Enter;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(592, 44);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(172, 23);
            textBox3.TabIndex = 4;
            textBox3.Text = "Tap To Enter Name And Save...";
            textBox3.Enter += textBox3_Enter;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(592, 6);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 23);
            textBox2.TabIndex = 3;
            textBox2.Text = "Enter Name and Load File...";
            textBox2.Enter += textBox2_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 512);
            Controls.Add(comboBox3);
            Controls.Add(label5);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(label4);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private ComboBox comboBox2;
        private Label label3;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label4;
        private Button button6;
        private Button button7;
        private Button button8;
        private Label label5;
        private ComboBox comboBox3;
        private ColorDialog colorDialog1;
        private FontDialog fontDialog1;
        private OpenFileDialog openFileDialog1;
        private TextBox textBox3;
        private TextBox textBox2;
        private SaveFileDialog saveFileDialog1;
    }
}