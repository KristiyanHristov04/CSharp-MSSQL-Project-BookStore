
namespace Online_Book_Shop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Title = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.haveAccount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelUsernameWarning = new System.Windows.Forms.Label();
            this.labelPasswordWarning = new System.Windows.Forms.Label();
            this.labelCPasswordWarning = new System.Windows.Forms.Label();
            this.labelpasswordDoNotMatch = new System.Windows.Forms.Label();
            this.labelCpasswordDoNotMatch = new System.Windows.Forms.Label();
            this.redTriangle01 = new System.Windows.Forms.PictureBox();
            this.redTriangle02 = new System.Windows.Forms.PictureBox();
            this.redTriangle03 = new System.Windows.Forms.PictureBox();
            this.btnHidePassword = new System.Windows.Forms.Button();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.btnShowCPassword = new System.Windows.Forms.Button();
            this.btnHideCPassword = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTriangle01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTriangle02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTriangle03)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Title.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.YellowGreen;
            this.Title.Location = new System.Drawing.Point(135, 27);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(148, 65);
            this.Title.TabIndex = 0;
            this.Title.Text = "Booki";
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Username.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.Username.Location = new System.Drawing.Point(138, 185);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(106, 25);
            this.Username.TabIndex = 2;
            this.Username.Text = "Username:";
            this.Username.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(136, 212);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(208, 22);
            this.txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(136, 289);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(208, 22);
            this.txtPassword.TabIndex = 5;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Password.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.Password.Location = new System.Drawing.Point(138, 262);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(101, 25);
            this.Password.TabIndex = 4;
            this.Password.Text = "Password:";
            this.Password.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(136, 369);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(208, 22);
            this.txtConfirmPassword.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Location = new System.Drawing.Point(138, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Confirm Password:";
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.RegisterButton.FlatAppearance.BorderSize = 0;
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.ForeColor = System.Drawing.Color.Transparent;
            this.RegisterButton.Location = new System.Drawing.Point(136, 426);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(208, 52);
            this.RegisterButton.TabIndex = 8;
            this.RegisterButton.Text = "REGISTER";
            this.RegisterButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // haveAccount
            // 
            this.haveAccount.AutoSize = true;
            this.haveAccount.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.haveAccount.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.haveAccount.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.haveAccount.Location = new System.Drawing.Point(139, 481);
            this.haveAccount.Name = "haveAccount";
            this.haveAccount.Size = new System.Drawing.Size(213, 21);
            this.haveAccount.TabIndex = 9;
            this.haveAccount.Text = "Already have an account ? ";
            this.haveAccount.Click += new System.EventHandler(this.haveAccount_Click);
            this.haveAccount.MouseLeave += new System.EventHandler(this.haveAccount_MouseLeave);
            this.haveAccount.MouseHover += new System.EventHandler(this.haveAccount_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(198, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // labelUsernameWarning
            // 
            this.labelUsernameWarning.AutoSize = true;
            this.labelUsernameWarning.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelUsernameWarning.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsernameWarning.ForeColor = System.Drawing.Color.IndianRed;
            this.labelUsernameWarning.Location = new System.Drawing.Point(138, 237);
            this.labelUsernameWarning.Name = "labelUsernameWarning";
            this.labelUsernameWarning.Size = new System.Drawing.Size(148, 13);
            this.labelUsernameWarning.TabIndex = 11;
            this.labelUsernameWarning.Text = "*Please enter an username.";
            this.labelUsernameWarning.Visible = false;
            this.labelUsernameWarning.Click += new System.EventHandler(this.labelUsernameWarning_Click);
            // 
            // labelPasswordWarning
            // 
            this.labelPasswordWarning.AutoSize = true;
            this.labelPasswordWarning.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelPasswordWarning.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordWarning.ForeColor = System.Drawing.Color.IndianRed;
            this.labelPasswordWarning.Location = new System.Drawing.Point(140, 314);
            this.labelPasswordWarning.Name = "labelPasswordWarning";
            this.labelPasswordWarning.Size = new System.Drawing.Size(140, 13);
            this.labelPasswordWarning.TabIndex = 12;
            this.labelPasswordWarning.Text = "*Please enter a password.";
            this.labelPasswordWarning.Visible = false;
            // 
            // labelCPasswordWarning
            // 
            this.labelCPasswordWarning.AutoSize = true;
            this.labelCPasswordWarning.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelCPasswordWarning.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPasswordWarning.ForeColor = System.Drawing.Color.IndianRed;
            this.labelCPasswordWarning.Location = new System.Drawing.Point(140, 394);
            this.labelCPasswordWarning.Name = "labelCPasswordWarning";
            this.labelCPasswordWarning.Size = new System.Drawing.Size(140, 13);
            this.labelCPasswordWarning.TabIndex = 13;
            this.labelCPasswordWarning.Text = "*Please enter a password.";
            this.labelCPasswordWarning.Visible = false;
            // 
            // labelpasswordDoNotMatch
            // 
            this.labelpasswordDoNotMatch.AutoSize = true;
            this.labelpasswordDoNotMatch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelpasswordDoNotMatch.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpasswordDoNotMatch.ForeColor = System.Drawing.Color.IndianRed;
            this.labelpasswordDoNotMatch.Location = new System.Drawing.Point(138, 314);
            this.labelpasswordDoNotMatch.Name = "labelpasswordDoNotMatch";
            this.labelpasswordDoNotMatch.Size = new System.Drawing.Size(143, 13);
            this.labelpasswordDoNotMatch.TabIndex = 14;
            this.labelpasswordDoNotMatch.Text = "*Passwords do not match.";
            this.labelpasswordDoNotMatch.Visible = false;
            // 
            // labelCpasswordDoNotMatch
            // 
            this.labelCpasswordDoNotMatch.AutoSize = true;
            this.labelCpasswordDoNotMatch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelCpasswordDoNotMatch.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCpasswordDoNotMatch.ForeColor = System.Drawing.Color.IndianRed;
            this.labelCpasswordDoNotMatch.Location = new System.Drawing.Point(138, 394);
            this.labelCpasswordDoNotMatch.Name = "labelCpasswordDoNotMatch";
            this.labelCpasswordDoNotMatch.Size = new System.Drawing.Size(143, 13);
            this.labelCpasswordDoNotMatch.TabIndex = 15;
            this.labelCpasswordDoNotMatch.Text = "*Passwords do not match.";
            this.labelCpasswordDoNotMatch.Visible = false;
            // 
            // redTriangle01
            // 
            this.redTriangle01.Image = ((System.Drawing.Image)(resources.GetObject("redTriangle01.Image")));
            this.redTriangle01.Location = new System.Drawing.Point(349, 209);
            this.redTriangle01.Name = "redTriangle01";
            this.redTriangle01.Size = new System.Drawing.Size(27, 26);
            this.redTriangle01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.redTriangle01.TabIndex = 16;
            this.redTriangle01.TabStop = false;
            this.redTriangle01.Visible = false;
            // 
            // redTriangle02
            // 
            this.redTriangle02.Image = ((System.Drawing.Image)(resources.GetObject("redTriangle02.Image")));
            this.redTriangle02.Location = new System.Drawing.Point(349, 286);
            this.redTriangle02.Name = "redTriangle02";
            this.redTriangle02.Size = new System.Drawing.Size(27, 26);
            this.redTriangle02.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.redTriangle02.TabIndex = 17;
            this.redTriangle02.TabStop = false;
            this.redTriangle02.Visible = false;
            // 
            // redTriangle03
            // 
            this.redTriangle03.Image = ((System.Drawing.Image)(resources.GetObject("redTriangle03.Image")));
            this.redTriangle03.Location = new System.Drawing.Point(349, 367);
            this.redTriangle03.Name = "redTriangle03";
            this.redTriangle03.Size = new System.Drawing.Size(27, 26);
            this.redTriangle03.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.redTriangle03.TabIndex = 18;
            this.redTriangle03.TabStop = false;
            this.redTriangle03.Visible = false;
            // 
            // btnHidePassword
            // 
            this.btnHidePassword.BackColor = System.Drawing.Color.Transparent;
            this.btnHidePassword.FlatAppearance.BorderSize = 0;
            this.btnHidePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHidePassword.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHidePassword.ForeColor = System.Drawing.Color.Transparent;
            this.btnHidePassword.Image = ((System.Drawing.Image)(resources.GetObject("btnHidePassword.Image")));
            this.btnHidePassword.Location = new System.Drawing.Point(299, 312);
            this.btnHidePassword.Name = "btnHidePassword";
            this.btnHidePassword.Size = new System.Drawing.Size(45, 29);
            this.btnHidePassword.TabIndex = 21;
            this.btnHidePassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHidePassword.UseVisualStyleBackColor = false;
            this.btnHidePassword.Click += new System.EventHandler(this.btnHidePassword_Click_1);
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnShowPassword.FlatAppearance.BorderSize = 0;
            this.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassword.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowPassword.ForeColor = System.Drawing.Color.Transparent;
            this.btnShowPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnShowPassword.Image")));
            this.btnShowPassword.Location = new System.Drawing.Point(299, 312);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(45, 29);
            this.btnShowPassword.TabIndex = 22;
            this.btnShowPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShowPassword.UseVisualStyleBackColor = false;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click_1);
            // 
            // btnShowCPassword
            // 
            this.btnShowCPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnShowCPassword.FlatAppearance.BorderSize = 0;
            this.btnShowCPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCPassword.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCPassword.ForeColor = System.Drawing.Color.Transparent;
            this.btnShowCPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnShowCPassword.Image")));
            this.btnShowCPassword.Location = new System.Drawing.Point(299, 391);
            this.btnShowCPassword.Name = "btnShowCPassword";
            this.btnShowCPassword.Size = new System.Drawing.Size(45, 29);
            this.btnShowCPassword.TabIndex = 23;
            this.btnShowCPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShowCPassword.UseVisualStyleBackColor = false;
            this.btnShowCPassword.Click += new System.EventHandler(this.btnShowCPassword_Click);
            // 
            // btnHideCPassword
            // 
            this.btnHideCPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnHideCPassword.FlatAppearance.BorderSize = 0;
            this.btnHideCPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideCPassword.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideCPassword.ForeColor = System.Drawing.Color.Transparent;
            this.btnHideCPassword.Image = ((System.Drawing.Image)(resources.GetObject("btnHideCPassword.Image")));
            this.btnHideCPassword.Location = new System.Drawing.Point(299, 391);
            this.btnHideCPassword.Name = "btnHideCPassword";
            this.btnHideCPassword.Size = new System.Drawing.Size(45, 29);
            this.btnHideCPassword.TabIndex = 24;
            this.btnHideCPassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHideCPassword.UseVisualStyleBackColor = false;
            this.btnHideCPassword.Click += new System.EventHandler(this.btnHideCPassword_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.label2.Location = new System.Drawing.Point(263, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 65);
            this.label2.TabIndex = 28;
            this.label2.Text = ".on";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(496, 580);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnShowCPassword);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.btnHidePassword);
            this.Controls.Add(this.redTriangle03);
            this.Controls.Add(this.redTriangle02);
            this.Controls.Add(this.redTriangle01);
            this.Controls.Add(this.labelCpasswordDoNotMatch);
            this.Controls.Add(this.labelpasswordDoNotMatch);
            this.Controls.Add(this.labelCPasswordWarning);
            this.Controls.Add(this.labelPasswordWarning);
            this.Controls.Add(this.labelUsernameWarning);
            this.Controls.Add(this.haveAccount);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnHideCPassword);
            this.Name = "Form1";
            this.Text = "Booki.on";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTriangle01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTriangle02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redTriangle03)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label haveAccount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelUsernameWarning;
        private System.Windows.Forms.Label labelPasswordWarning;
        private System.Windows.Forms.Label labelCPasswordWarning;
        private System.Windows.Forms.Label labelpasswordDoNotMatch;
        private System.Windows.Forms.Label labelCpasswordDoNotMatch;
        private System.Windows.Forms.PictureBox redTriangle01;
        private System.Windows.Forms.PictureBox redTriangle02;
        private System.Windows.Forms.PictureBox redTriangle03;
        private System.Windows.Forms.Button btnHidePassword;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.Button btnShowCPassword;
        private System.Windows.Forms.Button btnHideCPassword;
        private System.Windows.Forms.Label label2;
    }
}

