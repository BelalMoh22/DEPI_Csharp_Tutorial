namespace MyFirstWindowsFormApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            submitbtn = new Button();
            userName = new Label();
            txtName = new TextBox();
            label1 = new Label();
            txtPassword = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // submitbtn
            // 
            submitbtn.Image = (Image)resources.GetObject("submitbtn.Image");
            submitbtn.ImageAlign = ContentAlignment.TopLeft;
            submitbtn.Location = new Point(192, 188);
            submitbtn.Name = "submitbtn";
            submitbtn.Size = new Size(110, 40);
            submitbtn.TabIndex = 0;
            submitbtn.Text = "submit";
            submitbtn.UseVisualStyleBackColor = true;
            submitbtn.Click += button1_Click;
            // 
            // userName
            // 
            userName.AutoSize = true;
            userName.Location = new Point(78, 92);
            userName.Name = "userName";
            userName.Size = new Size(62, 15);
            userName.TabIndex = 1;
            userName.Text = "UserName";
            userName.Click += UserName_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(146, 89);
            txtName.Name = "txtName";
            txtName.Size = new Size(212, 23);
            txtName.TabIndex = 2;
            txtName.TextChanged += txtName_TextChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 142);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 3;
            label1.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(146, 139);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(212, 23);
            txtPassword.TabIndex = 4;
            txtPassword.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(192, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 250);
            Controls.Add(pictureBox1);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(userName);
            Controls.Add(submitbtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MySmartApp";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button submitbtn;
        private Label userName;
        private TextBox txtName;
        private Label label1;
        private TextBox txtPassword;
        private PictureBox pictureBox1;
    }
}
