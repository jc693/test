
namespace UI_New
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.close_button = new FontAwesome.Sharp.IconButton();
            this.UserIcon_pbox = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon_pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.UserIcon_pbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 471);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.label3.Location = new System.Drawing.Point(110, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 27);
            this.label3.TabIndex = 15;
            this.label3.Text = "Login to Your Account";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.button2.Location = new System.Drawing.Point(235, 331);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 29);
            this.button2.TabIndex = 14;
            this.button2.Text = "Forgot Password";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(78, 280);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(276, 28);
            this.txtPassword.TabIndex = 13;
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(75, 260);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(78, 220);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(276, 28);
            this.txtUsername.TabIndex = 11;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(75, 201);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Username";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.checkBox1.Location = new System.Drawing.Point(78, 312);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(117, 21);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Remember me";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(78, 365);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.close_button);
            this.panel2.Location = new System.Drawing.Point(272, 10);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(152, 21);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // close_button
            // 
            this.close_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.close_button.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.close_button.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.close_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.close_button.IconSize = 60;
            this.close_button.Location = new System.Drawing.Point(133, 0);
            this.close_button.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(19, 21);
            this.close_button.TabIndex = 2;
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.close_button_MouseClick);
            // 
            // UserIcon_pbox
            // 
            this.UserIcon_pbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(220)))));
            this.UserIcon_pbox.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserIcon_pbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.UserIcon_pbox.IconChar = FontAwesome.Sharp.IconChar.CircleUser;
            this.UserIcon_pbox.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.UserIcon_pbox.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.UserIcon_pbox.IconSize = 150;
            this.UserIcon_pbox.Location = new System.Drawing.Point(0, 0);
            this.UserIcon_pbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserIcon_pbox.Name = "UserIcon_pbox";
            this.UserIcon_pbox.Size = new System.Drawing.Size(433, 150);
            this.UserIcon_pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.UserIcon_pbox.TabIndex = 2;
            this.UserIcon_pbox.TabStop = false;
            this.UserIcon_pbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.UserIcon_pbox_MouseDown);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 471);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserIcon_pbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton close_button;
        private FontAwesome.Sharp.IconPictureBox UserIcon_pbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
    }
}