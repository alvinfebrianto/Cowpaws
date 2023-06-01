namespace cowpaws
{
    partial class Pegawai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pegawai));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Gender8 = new System.Windows.Forms.ComboBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.Logout8 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Password8 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Nama8 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Telpon8 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PegawaiDGV8 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnClose8 = new System.Windows.Forms.PictureBox();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.guna2GradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PegawaiDGV8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose8)).BeginInit();
            this.SuspendLayout();
            // 
            // Gender8
            // 
            this.Gender8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Gender8.Font = new System.Drawing.Font("Inter", 12F);
            this.Gender8.FormattingEnabled = true;
            this.Gender8.Items.AddRange(new object[] {
            "Laki-laki",
            "Perempuan"});
            this.Gender8.Location = new System.Drawing.Point(362, 75);
            this.Gender8.Name = "Gender8";
            this.Gender8.Size = new System.Drawing.Size(126, 27);
            this.Gender8.TabIndex = 81;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.Controls.Add(this.pictureBox9);
            this.panel10.Controls.Add(this.Logout8);
            this.panel10.Location = new System.Drawing.Point(0, 438);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(165, 42);
            this.panel10.TabIndex = 30;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(10, 5);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(32, 32);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 1;
            this.pictureBox9.TabStop = false;
            // 
            // Logout8
            // 
            this.Logout8.AutoSize = true;
            this.Logout8.Font = new System.Drawing.Font("Quicksand SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout8.Location = new System.Drawing.Point(50, 9);
            this.Logout8.Name = "Logout8";
            this.Logout8.Size = new System.Drawing.Size(64, 24);
            this.Logout8.TabIndex = 0;
            this.Logout8.Text = "Logout";
            this.Logout8.Click += new System.EventHandler(this.Logout8_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(165, 84);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Inter", 12F);
            this.button1.Location = new System.Drawing.Point(281, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 32);
            this.button1.TabIndex = 77;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(165, 144);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(689, 40);
            this.panel2.TabIndex = 76;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Quicksand SemiBold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(263, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 30);
            this.label10.TabIndex = 19;
            this.label10.Text = "Daftar Pegawai";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(694, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 19);
            this.label4.TabIndex = 68;
            this.label4.Text = "Password";
            // 
            // Password8
            // 
            this.Password8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password8.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Password8.HintForeColor = System.Drawing.Color.Empty;
            this.Password8.HintText = "";
            this.Password8.isPassword = false;
            this.Password8.LineFocusedColor = System.Drawing.Color.Maroon;
            this.Password8.LineIdleColor = System.Drawing.Color.DarkGray;
            this.Password8.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.Password8.LineThickness = 3;
            this.Password8.Location = new System.Drawing.Point(698, 65);
            this.Password8.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Password8.Name = "Password8";
            this.Password8.Size = new System.Drawing.Size(126, 37);
            this.Password8.TabIndex = 67;
            this.Password8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Nama8
            // 
            this.Nama8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Nama8.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nama8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Nama8.HintForeColor = System.Drawing.Color.Empty;
            this.Nama8.HintText = "";
            this.Nama8.isPassword = false;
            this.Nama8.LineFocusedColor = System.Drawing.Color.Maroon;
            this.Nama8.LineIdleColor = System.Drawing.Color.DarkGray;
            this.Nama8.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.Nama8.LineThickness = 3;
            this.Nama8.Location = new System.Drawing.Point(194, 65);
            this.Nama8.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Nama8.Name = "Nama8";
            this.Nama8.Size = new System.Drawing.Size(126, 37);
            this.Nama8.TabIndex = 63;
            this.Nama8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.guna2GradientPanel1.Controls.Add(this.BtnClose8);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(165, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(689, 40);
            this.guna2GradientPanel1.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pegawai";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(526, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 19);
            this.label5.TabIndex = 66;
            this.label5.Text = "No. Telpon";
            // 
            // Telpon8
            // 
            this.Telpon8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Telpon8.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telpon8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Telpon8.HintForeColor = System.Drawing.Color.Empty;
            this.Telpon8.HintText = "";
            this.Telpon8.isPassword = false;
            this.Telpon8.LineFocusedColor = System.Drawing.Color.Maroon;
            this.Telpon8.LineIdleColor = System.Drawing.Color.DarkGray;
            this.Telpon8.LineMouseHoverColor = System.Drawing.Color.Maroon;
            this.Telpon8.LineThickness = 3;
            this.Telpon8.Location = new System.Drawing.Point(530, 65);
            this.Telpon8.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Telpon8.Name = "Telpon8";
            this.Telpon8.Size = new System.Drawing.Size(126, 37);
            this.Telpon8.TabIndex = 65;
            this.Telpon8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(358, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 62;
            this.label2.Text = "Gender";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 480);
            this.panel1.TabIndex = 60;
            // 
            // PegawaiDGV8
            // 
            this.PegawaiDGV8.AllowUserToAddRows = false;
            this.PegawaiDGV8.AllowUserToDeleteRows = false;
            this.PegawaiDGV8.AllowUserToResizeColumns = false;
            this.PegawaiDGV8.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.PegawaiDGV8.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Euclid Circular B", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PegawaiDGV8.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.PegawaiDGV8.ColumnHeadersHeight = 22;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Inter", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PegawaiDGV8.DefaultCellStyle = dataGridViewCellStyle6;
            this.PegawaiDGV8.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PegawaiDGV8.Location = new System.Drawing.Point(171, 188);
            this.PegawaiDGV8.Name = "PegawaiDGV8";
            this.PegawaiDGV8.ReadOnly = true;
            this.PegawaiDGV8.RowHeadersVisible = false;
            this.PegawaiDGV8.Size = new System.Drawing.Size(676, 287);
            this.PegawaiDGV8.TabIndex = 82;
            this.PegawaiDGV8.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PegawaiDGV8.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PegawaiDGV8.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PegawaiDGV8.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PegawaiDGV8.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PegawaiDGV8.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.PegawaiDGV8.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PegawaiDGV8.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.AntiqueWhite;
            this.PegawaiDGV8.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PegawaiDGV8.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Euclid Circular B", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PegawaiDGV8.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PegawaiDGV8.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.PegawaiDGV8.ThemeStyle.HeaderStyle.Height = 22;
            this.PegawaiDGV8.ThemeStyle.ReadOnly = true;
            this.PegawaiDGV8.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.Azure;
            this.PegawaiDGV8.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PegawaiDGV8.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Inter", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PegawaiDGV8.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PegawaiDGV8.ThemeStyle.RowsStyle.Height = 22;
            this.PegawaiDGV8.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PegawaiDGV8.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PegawaiDGV8.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PegawaiDGV8_CellContentClick);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Inter", 12F);
            this.button4.Location = new System.Drawing.Point(644, 112);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 32);
            this.button4.TabIndex = 80;
            this.button4.Text = "Clear";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Inter", 12F);
            this.button3.Location = new System.Drawing.Point(523, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 32);
            this.button3.TabIndex = 79;
            this.button3.Text = "Hapus";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Inter", 12F);
            this.button2.Location = new System.Drawing.Point(402, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 32);
            this.button2.TabIndex = 78;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 84;
            this.label3.Text = "Nama";
            // 
            // BtnClose8
            // 
            this.BtnClose8.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose8.Image")));
            this.BtnClose8.Location = new System.Drawing.Point(660, 10);
            this.BtnClose8.Name = "BtnClose8";
            this.BtnClose8.Size = new System.Drawing.Size(20, 20);
            this.BtnClose8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnClose8.TabIndex = 3;
            this.BtnClose8.TabStop = false;
            this.BtnClose8.Click += new System.EventHandler(this.BtnClose8_Click);
            // 
            // Pegawai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(854, 480);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Gender8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Password8);
            this.Controls.Add(this.Nama8);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Telpon8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PegawaiDGV8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pegawai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pegawai";
            this.Load += new System.EventHandler(this.Pegawai_Load);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PegawaiDGV8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Gender8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label Logout8;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Password8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Nama8;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Telpon8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView PegawaiDGV8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox BtnClose8;
    }
}