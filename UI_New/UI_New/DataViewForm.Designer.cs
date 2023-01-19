
namespace UI_New
{
    partial class DataViewForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.close_button = new FontAwesome.Sharp.IconButton();
            this.maximize_button = new FontAwesome.Sharp.IconButton();
            this.minimize_button = new FontAwesome.Sharp.IconButton();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.searchTxt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1503, 76);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.close_button);
            this.panel2.Controls.Add(this.maximize_button);
            this.panel2.Controls.Add(this.minimize_button);
            this.panel2.Location = new System.Drawing.Point(1289, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(202, 26);
            this.panel2.TabIndex = 2;
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
            this.close_button.Location = new System.Drawing.Point(177, 0);
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
            // searchTxt
            // 
            this.searchTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.searchTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTxt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchTxt.Font = new System.Drawing.Font("Lato", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.searchTxt.Location = new System.Drawing.Point(0, 28);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(1503, 48);
            this.searchTxt.TabIndex = 1000;
            this.searchTxt.Text = "Search Results";
            this.searchTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchTxt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EnterClient_txt_MouseDown);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.iconButton1);
            this.panel3.Controls.Add(this.dataGridView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1503, 889);
            this.panel3.TabIndex = 2;
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(215)))), ((int)(((byte)(216)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(104)))), ((int)(((byte)(121)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.FileCsv;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(1301, 783);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(199, 103);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Export";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 50;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1503, 889);
            this.dataGridView.TabIndex = 1;
            // 
            // DataViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1503, 965);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataViewForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton close_button;
        private FontAwesome.Sharp.IconButton maximize_button;
        private FontAwesome.Sharp.IconButton minimize_button;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}