namespace smartproperty
{
    partial class login
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
            this.submitlogin = new MetroFramework.Controls.MetroButton();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.forgetpassword = new System.Windows.Forms.LinkLabel();
            this.notregistered = new System.Windows.Forms.LinkLabel();
            this.profilepicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.profilepicture)).BeginInit();
            this.SuspendLayout();
            // 
            // submitlogin
            // 
            this.submitlogin.Location = new System.Drawing.Point(120, 273);
            this.submitlogin.Name = "submitlogin";
            this.submitlogin.Size = new System.Drawing.Size(95, 32);
            this.submitlogin.TabIndex = 2;
            this.submitlogin.Text = "Login";
            this.submitlogin.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.submitlogin.UseSelectable = true;
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.ForeColor = System.Drawing.Color.DarkGray;
            this.username.Location = new System.Drawing.Point(77, 195);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(180, 22);
            this.username.TabIndex = 0;
            this.username.Text = "username";
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.username.Enter += new System.EventHandler(this.userid_Enter);
            this.username.Leave += new System.EventHandler(this.userid_Leave);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.ForeColor = System.Drawing.Color.DarkGray;
            this.password.Location = new System.Drawing.Point(77, 233);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(180, 22);
            this.password.TabIndex = 1;
            this.password.Text = "password";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password.Enter += new System.EventHandler(this.userpass_Enter);
            this.password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userpass_KeyDown);
            this.password.Leave += new System.EventHandler(this.userpass_Leave);
            // 
            // forgetpassword
            // 
            this.forgetpassword.ActiveLinkColor = System.Drawing.SystemColors.ActiveBorder;
            this.forgetpassword.AutoSize = true;
            this.forgetpassword.LinkColor = System.Drawing.Color.White;
            this.forgetpassword.Location = new System.Drawing.Point(117, 315);
            this.forgetpassword.Name = "forgetpassword";
            this.forgetpassword.Size = new System.Drawing.Size(85, 13);
            this.forgetpassword.TabIndex = 3;
            this.forgetpassword.TabStop = true;
            this.forgetpassword.Text = "Forget password";
            // 
            // notregistered
            // 
            this.notregistered.ActiveLinkColor = System.Drawing.SystemColors.ActiveBorder;
            this.notregistered.AutoSize = true;
            this.notregistered.LinkColor = System.Drawing.Color.White;
            this.notregistered.Location = new System.Drawing.Point(117, 334);
            this.notregistered.Name = "notregistered";
            this.notregistered.Size = new System.Drawing.Size(119, 13);
            this.notregistered.TabIndex = 4;
            this.notregistered.TabStop = true;
            this.notregistered.Text = "Dont have any account";
            this.notregistered.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.notregistered_LinkClicked);
            // 
            // profilepicture
            // 
            this.profilepicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profilepicture.Location = new System.Drawing.Point(105, 63);
            this.profilepicture.Name = "profilepicture";
            this.profilepicture.Size = new System.Drawing.Size(120, 120);
            this.profilepicture.TabIndex = 0;
            this.profilepicture.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(340, 375);
            this.Controls.Add(this.notregistered);
            this.Controls.Add(this.forgetpassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.submitlogin);
            this.Controls.Add(this.profilepicture);
            this.MaximizeBox = false;
            this.Name = "login";
            this.Resizable = false;
            this.Text = "Login";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.profilepicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox profilepicture;
        private MetroFramework.Controls.MetroButton submitlogin;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.LinkLabel forgetpassword;
        private System.Windows.Forms.LinkLabel notregistered;
    }
}