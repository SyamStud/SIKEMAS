namespace kasMasjid.Interface
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.penggunaBtn = new System.Windows.Forms.Button();
            this.pengeluaranBtn = new System.Windows.Forms.Button();
            this.pemasukanBtn = new System.Windows.Forms.Button();
            this.kategoriBtn = new System.Windows.Forms.Button();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.contentPnl = new System.Windows.Forms.Panel();
            this.headerTxt = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 601);
            this.panel1.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(69)))), ((int)(((byte)(105)))));
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.penggunaBtn);
            this.panel5.Controls.Add(this.pengeluaranBtn);
            this.panel5.Controls.Add(this.pemasukanBtn);
            this.panel5.Controls.Add(this.kategoriBtn);
            this.panel5.Controls.Add(this.dashboardBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 186);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(190, 415);
            this.panel5.TabIndex = 2;
            // 
            // penggunaBtn
            // 
            this.penggunaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(69)))), ((int)(((byte)(105)))));
            this.penggunaBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.penggunaBtn.FlatAppearance.BorderSize = 0;
            this.penggunaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.penggunaBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penggunaBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.penggunaBtn.Image = ((System.Drawing.Image)(resources.GetObject("penggunaBtn.Image")));
            this.penggunaBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.penggunaBtn.Location = new System.Drawing.Point(0, 200);
            this.penggunaBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.penggunaBtn.Name = "penggunaBtn";
            this.penggunaBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.penggunaBtn.Size = new System.Drawing.Size(190, 50);
            this.penggunaBtn.TabIndex = 4;
            this.penggunaBtn.Text = "  Pengguna";
            this.penggunaBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.penggunaBtn.UseVisualStyleBackColor = false;
            this.penggunaBtn.Click += new System.EventHandler(this.penggunaBtn_Click);
            // 
            // pengeluaranBtn
            // 
            this.pengeluaranBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(69)))), ((int)(((byte)(105)))));
            this.pengeluaranBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pengeluaranBtn.FlatAppearance.BorderSize = 0;
            this.pengeluaranBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pengeluaranBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pengeluaranBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pengeluaranBtn.Image = ((System.Drawing.Image)(resources.GetObject("pengeluaranBtn.Image")));
            this.pengeluaranBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pengeluaranBtn.Location = new System.Drawing.Point(0, 150);
            this.pengeluaranBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pengeluaranBtn.Name = "pengeluaranBtn";
            this.pengeluaranBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.pengeluaranBtn.Size = new System.Drawing.Size(190, 50);
            this.pengeluaranBtn.TabIndex = 3;
            this.pengeluaranBtn.Text = "  Pengeluaran";
            this.pengeluaranBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pengeluaranBtn.UseVisualStyleBackColor = false;
            this.pengeluaranBtn.Click += new System.EventHandler(this.pengeluaranBtn_Click);
            // 
            // pemasukanBtn
            // 
            this.pemasukanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(69)))), ((int)(((byte)(105)))));
            this.pemasukanBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pemasukanBtn.FlatAppearance.BorderSize = 0;
            this.pemasukanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pemasukanBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pemasukanBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pemasukanBtn.Image = ((System.Drawing.Image)(resources.GetObject("pemasukanBtn.Image")));
            this.pemasukanBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pemasukanBtn.Location = new System.Drawing.Point(0, 100);
            this.pemasukanBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pemasukanBtn.Name = "pemasukanBtn";
            this.pemasukanBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.pemasukanBtn.Size = new System.Drawing.Size(190, 50);
            this.pemasukanBtn.TabIndex = 2;
            this.pemasukanBtn.Text = "  Pemasukan";
            this.pemasukanBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pemasukanBtn.UseVisualStyleBackColor = false;
            this.pemasukanBtn.Click += new System.EventHandler(this.pemasukanBtn_Click);
            // 
            // kategoriBtn
            // 
            this.kategoriBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(69)))), ((int)(((byte)(105)))));
            this.kategoriBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.kategoriBtn.FlatAppearance.BorderSize = 0;
            this.kategoriBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kategoriBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategoriBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.kategoriBtn.Image = ((System.Drawing.Image)(resources.GetObject("kategoriBtn.Image")));
            this.kategoriBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.kategoriBtn.Location = new System.Drawing.Point(0, 50);
            this.kategoriBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.kategoriBtn.Name = "kategoriBtn";
            this.kategoriBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.kategoriBtn.Size = new System.Drawing.Size(190, 50);
            this.kategoriBtn.TabIndex = 1;
            this.kategoriBtn.Text = "  Kategori";
            this.kategoriBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.kategoriBtn.UseVisualStyleBackColor = false;
            this.kategoriBtn.Click += new System.EventHandler(this.kategoriBtn_Click);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(69)))), ((int)(((byte)(105)))));
            this.dashboardBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardBtn.FlatAppearance.BorderSize = 0;
            this.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.dashboardBtn.Image = ((System.Drawing.Image)(resources.GetObject("dashboardBtn.Image")));
            this.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.Location = new System.Drawing.Point(0, 0);
            this.dashboardBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.dashboardBtn.Size = new System.Drawing.Size(190, 50);
            this.dashboardBtn.TabIndex = 0;
            this.dashboardBtn.Text = "  Dashboard";
            this.dashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dashboardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dashboardBtn.UseVisualStyleBackColor = false;
            this.dashboardBtn.Click += new System.EventHandler(this.dashboardBtn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(69)))), ((int)(((byte)(105)))));
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(190, 186);
            this.panel4.TabIndex = 1;
            // 
            // contentPnl
            // 
            this.contentPnl.Location = new System.Drawing.Point(210, 82);
            this.contentPnl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contentPnl.Name = "contentPnl";
            this.contentPnl.Size = new System.Drawing.Size(766, 503);
            this.contentPnl.TabIndex = 1;
            // 
            // headerTxt
            // 
            this.headerTxt.AutoSize = true;
            this.headerTxt.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerTxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.headerTxt.Location = new System.Drawing.Point(16, 20);
            this.headerTxt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.headerTxt.Name = "headerTxt";
            this.headerTxt.Size = new System.Drawing.Size(110, 22);
            this.headerTxt.TabIndex = 5;
            this.headerTxt.Text = "Dashboard";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.headerTxt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(190, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 64);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(69)))), ((int)(((byte)(105)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(0, 365);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "  Keluar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 601);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.contentPnl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button pemasukanBtn;
        private System.Windows.Forms.Button kategoriBtn;
        private System.Windows.Forms.Button pengeluaranBtn;
        private System.Windows.Forms.Button penggunaBtn;
        private System.Windows.Forms.Panel contentPnl;
        private System.Windows.Forms.Label headerTxt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}