
namespace UI_New
{
    partial class EnterNewUserForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.close_button = new FontAwesome.Sharp.IconButton();
            this.maximize_button = new FontAwesome.Sharp.IconButton();
            this.minimize_button = new FontAwesome.Sharp.IconButton();
            this.EnterClient_txt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label31 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.option_panel = new System.Windows.Forms.Panel();
            this.editUser_button = new FontAwesome.Sharp.IconButton();
            this.newUser_button = new FontAwesome.Sharp.IconButton();
            this.report_button = new FontAwesome.Sharp.IconButton();
            this.edit_button = new FontAwesome.Sharp.IconButton();
            this.input_button = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.remove_button = new FontAwesome.Sharp.IconButton();
            this.add_button = new FontAwesome.Sharp.IconButton();
            this.perm_listbox = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.option_panel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.EnterClient_txt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 48);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.panel2.Controls.Add(this.close_button);
            this.panel2.Controls.Add(this.maximize_button);
            this.panel2.Controls.Add(this.minimize_button);
            this.panel2.Location = new System.Drawing.Point(600, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 26);
            this.panel2.TabIndex = 4;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // close_button
            // 
            this.close_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.close_button.IconChar = FontAwesome.Sharp.IconChar.RectangleXmark;
            this.close_button.IconColor = System.Drawing.Color.Gainsboro;
            this.close_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.close_button.IconSize = 60;
            this.close_button.Location = new System.Drawing.Point(175, 0);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(25, 26);
            this.close_button.TabIndex = 2;
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.close_button_MouseClick);
            // 
            // maximize_button
            // 
            this.maximize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.maximize_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.maximize_button.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.maximize_button.IconColor = System.Drawing.Color.Gainsboro;
            this.maximize_button.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.maximize_button.IconSize = 25;
            this.maximize_button.Location = new System.Drawing.Point(147, -3);
            this.maximize_button.Name = "maximize_button";
            this.maximize_button.Size = new System.Drawing.Size(25, 26);
            this.maximize_button.TabIndex = 1;
            this.maximize_button.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.maximize_button.UseVisualStyleBackColor = true;
            this.maximize_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.maximize_button_MouseClick);
            // 
            // minimize_button
            // 
            this.minimize_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.minimize_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimize_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.minimize_button.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.minimize_button.IconColor = System.Drawing.Color.Gainsboro;
            this.minimize_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.minimize_button.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.minimize_button.Location = new System.Drawing.Point(116, -3);
            this.minimize_button.Name = "minimize_button";
            this.minimize_button.Size = new System.Drawing.Size(25, 26);
            this.minimize_button.TabIndex = 0;
            this.minimize_button.UseVisualStyleBackColor = false;
            this.minimize_button.MouseClick += new System.Windows.Forms.MouseEventHandler(this.minimize_button_MouseClick);
            // 
            // EnterClient_txt
            // 
            this.EnterClient_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.EnterClient_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EnterClient_txt.Dock = System.Windows.Forms.DockStyle.Top;
            this.EnterClient_txt.Font = new System.Drawing.Font("Lato", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterClient_txt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.EnterClient_txt.Location = new System.Drawing.Point(0, 0);
            this.EnterClient_txt.Name = "EnterClient_txt";
            this.EnterClient_txt.Size = new System.Drawing.Size(800, 48);
            this.EnterClient_txt.TabIndex = 101;
            this.EnterClient_txt.Text = "Enter New User";
            this.EnterClient_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EnterClient_txt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EnterClient_txt_MouseDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(220)))));
            this.panel3.Controls.Add(this.label31);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.textBox4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 228);
            this.panel3.TabIndex = 1;
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Gabriola", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(79, 12);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(202, 55);
            this.label31.TabIndex = 65;
            this.label31.Text = "User Information";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textBox2.Location = new System.Drawing.Point(228, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(205, 25);
            this.textBox2.TabIndex = 64;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textBox1.Location = new System.Drawing.Point(228, 109);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 25);
            this.textBox1.TabIndex = 63;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textBox4.Location = new System.Drawing.Point(228, 71);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(205, 25);
            this.textBox4.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.label3.Location = new System.Drawing.Point(85, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Employee ID:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.label2.Location = new System.Drawing.Point(84, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.label1.Location = new System.Drawing.Point(84, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // option_panel
            // 
            this.option_panel.Controls.Add(this.editUser_button);
            this.option_panel.Controls.Add(this.newUser_button);
            this.option_panel.Controls.Add(this.report_button);
            this.option_panel.Controls.Add(this.edit_button);
            this.option_panel.Controls.Add(this.input_button);
            this.option_panel.Location = new System.Drawing.Point(89, 294);
            this.option_panel.Name = "option_panel";
            this.option_panel.Size = new System.Drawing.Size(192, 267);
            this.option_panel.TabIndex = 2;
            // 
            // editUser_button
            // 
            this.editUser_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.editUser_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.editUser_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editUser_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(220)))));
            this.editUser_button.IconChar = FontAwesome.Sharp.IconChar.None;
            this.editUser_button.IconColor = System.Drawing.Color.Black;
            this.editUser_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.editUser_button.Location = new System.Drawing.Point(0, 212);
            this.editUser_button.Name = "editUser_button";
            this.editUser_button.Size = new System.Drawing.Size(192, 53);
            this.editUser_button.TabIndex = 4;
            this.editUser_button.Text = "Edit User";
            this.editUser_button.UseVisualStyleBackColor = false;
            this.editUser_button.Click += new System.EventHandler(this.editUser_button_Click);
            // 
            // newUser_button
            // 
            this.newUser_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.newUser_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.newUser_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newUser_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(220)))));
            this.newUser_button.IconChar = FontAwesome.Sharp.IconChar.None;
            this.newUser_button.IconColor = System.Drawing.Color.Black;
            this.newUser_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.newUser_button.Location = new System.Drawing.Point(0, 159);
            this.newUser_button.Name = "newUser_button";
            this.newUser_button.Size = new System.Drawing.Size(192, 53);
            this.newUser_button.TabIndex = 3;
            this.newUser_button.Text = "Create New User";
            this.newUser_button.UseVisualStyleBackColor = false;
            this.newUser_button.Click += new System.EventHandler(this.newUser_button_Click);
            // 
            // report_button
            // 
            this.report_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.report_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.report_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.report_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(220)))));
            this.report_button.IconChar = FontAwesome.Sharp.IconChar.None;
            this.report_button.IconColor = System.Drawing.Color.Black;
            this.report_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.report_button.Location = new System.Drawing.Point(0, 106);
            this.report_button.Name = "report_button";
            this.report_button.Size = new System.Drawing.Size(192, 53);
            this.report_button.TabIndex = 2;
            this.report_button.Text = "Generate Reports";
            this.report_button.UseVisualStyleBackColor = false;
            this.report_button.Click += new System.EventHandler(this.report_button_Click);
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.edit_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.edit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edit_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(220)))));
            this.edit_button.IconChar = FontAwesome.Sharp.IconChar.None;
            this.edit_button.IconColor = System.Drawing.Color.Black;
            this.edit_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.edit_button.Location = new System.Drawing.Point(0, 53);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(192, 53);
            this.edit_button.TabIndex = 1;
            this.edit_button.Text = "Edit Client";
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // input_button
            // 
            this.input_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.input_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.input_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.input_button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(220)))));
            this.input_button.IconChar = FontAwesome.Sharp.IconChar.None;
            this.input_button.IconColor = System.Drawing.Color.Black;
            this.input_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.input_button.Location = new System.Drawing.Point(0, 0);
            this.input_button.Name = "input_button";
            this.input_button.Size = new System.Drawing.Size(192, 53);
            this.input_button.TabIndex = 0;
            this.input_button.Text = "Input New Client";
            this.input_button.UseVisualStyleBackColor = false;
            this.input_button.Click += new System.EventHandler(this.input_button_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.remove_button);
            this.panel4.Controls.Add(this.add_button);
            this.panel4.Location = new System.Drawing.Point(370, 347);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(123, 159);
            this.panel4.TabIndex = 3;
            // 
            // remove_button
            // 
            this.remove_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.remove_button.IconChar = FontAwesome.Sharp.IconChar.None;
            this.remove_button.IconColor = System.Drawing.Color.Black;
            this.remove_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.remove_button.Location = new System.Drawing.Point(0, 106);
            this.remove_button.Name = "remove_button";
            this.remove_button.Size = new System.Drawing.Size(123, 53);
            this.remove_button.TabIndex = 1;
            this.remove_button.Text = "Remove";
            this.remove_button.UseVisualStyleBackColor = true;
            this.remove_button.Click += new System.EventHandler(this.remove_button_Click);
            // 
            // add_button
            // 
            this.add_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.add_button.IconChar = FontAwesome.Sharp.IconChar.None;
            this.add_button.IconColor = System.Drawing.Color.Black;
            this.add_button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.add_button.Location = new System.Drawing.Point(0, 0);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(123, 53);
            this.add_button.TabIndex = 0;
            this.add_button.Text = "Add";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // perm_listbox
            // 
            this.perm_listbox.FormattingEnabled = true;
            this.perm_listbox.ItemHeight = 16;
            this.perm_listbox.Location = new System.Drawing.Point(562, 294);
            this.perm_listbox.Name = "perm_listbox";
            this.perm_listbox.Size = new System.Drawing.Size(179, 260);
            this.perm_listbox.TabIndex = 4;
            // 
            // EnterNewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(800, 595);
            this.Controls.Add(this.perm_listbox);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.option_panel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnterNewUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnterNewUserForm";
            this.Load += new System.EventHandler(this.EnterNewUserForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.option_panel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox EnterClient_txt;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton close_button;
        private FontAwesome.Sharp.IconButton maximize_button;
        private FontAwesome.Sharp.IconButton minimize_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Panel option_panel;
        private FontAwesome.Sharp.IconButton editUser_button;
        private FontAwesome.Sharp.IconButton newUser_button;
        private FontAwesome.Sharp.IconButton report_button;
        private FontAwesome.Sharp.IconButton edit_button;
        private FontAwesome.Sharp.IconButton input_button;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton remove_button;
        private FontAwesome.Sharp.IconButton add_button;
        private System.Windows.Forms.ListBox perm_listbox;
    }
}