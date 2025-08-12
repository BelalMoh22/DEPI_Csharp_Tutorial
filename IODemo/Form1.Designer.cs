namespace IODemo
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
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            lbl = new Label();
            listBox2 = new ListBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            richTextBox1 = new RichTextBox();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(13, 146);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(146, 139);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 55);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(34, 15);
            label1.TabIndex = 2;
            label1.Text = "Drive";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 118);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "Folders";
            // 
            // lbl
            // 
            lbl.Location = new Point(522, 9);
            lbl.Name = "lbl";
            lbl.Size = new Size(214, 96);
            lbl.TabIndex = 4;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(201, 146);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(146, 139);
            listBox2.TabIndex = 5;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(201, 118);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 6;
            label3.Text = "Files";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(401, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(335, 383);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(31, 349);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Create";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(211, 349);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.Location = new Point(750, 167);
            label4.Name = "label4";
            label4.Size = new Size(237, 205);
            label4.TabIndex = 10;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(993, 73);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(213, 336);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            // 
            // button3
            // 
            button3.Location = new Point(1034, 415);
            button3.Name = "button3";
            button3.Size = new Size(172, 23);
            button3.TabIndex = 12;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(993, 35);
            button4.Name = "button4";
            button4.Size = new Size(203, 23);
            button4.TabIndex = 13;
            button4.Text = "Read";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(759, 44);
            button5.Name = "button5";
            button5.Size = new Size(203, 23);
            button5.TabIndex = 14;
            button5.Text = "Open File Stream";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(759, 98);
            button6.Name = "button6";
            button6.Size = new Size(203, 23);
            button6.TabIndex = 15;
            button6.Text = "Write File Stream";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1227, 450);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(richTextBox1);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(listBox2);
            Controls.Add(lbl);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "IO";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Label lbl;
        private ListBox listBox2;
        private Label label3;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Label label4;
        private RichTextBox richTextBox1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
