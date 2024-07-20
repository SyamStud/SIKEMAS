namespace kasMasjid.Interface
{
    partial class KategoriForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.namaTxt = new System.Windows.Forms.TextBox();
            this.simpanBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.kategoriDgv = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cariTxt = new System.Windows.Forms.TextBox();
            this.hapusBtn = new System.Windows.Forms.Button();
            this.batalBtn = new System.Windows.Forms.Button();
            this.tutupBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tipeCmb = new System.Windows.Forms.ComboBox();
            this.idTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // namaTxt
            // 
            this.namaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaTxt.Location = new System.Drawing.Point(64, 24);
            this.namaTxt.Margin = new System.Windows.Forms.Padding(2);
            this.namaTxt.Name = "namaTxt";
            this.namaTxt.Size = new System.Drawing.Size(690, 23);
            this.namaTxt.TabIndex = 1;
            // 
            // simpanBtn
            // 
            this.simpanBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.simpanBtn.FlatAppearance.BorderSize = 0;
            this.simpanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.simpanBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpanBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.simpanBtn.Location = new System.Drawing.Point(0, 128);
            this.simpanBtn.Margin = new System.Windows.Forms.Padding(2);
            this.simpanBtn.Name = "simpanBtn";
            this.simpanBtn.Size = new System.Drawing.Size(171, 40);
            this.simpanBtn.TabIndex = 2;
            this.simpanBtn.Text = "Simpan";
            this.simpanBtn.UseVisualStyleBackColor = false;
            this.simpanBtn.Click += new System.EventHandler(this.simpanBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-3, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cari";
            // 
            // kategoriDgv
            // 
            this.kategoriDgv.AllowUserToAddRows = false;
            this.kategoriDgv.AllowUserToDeleteRows = false;
            this.kategoriDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kategoriDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nama,
            this.tipe});
            this.kategoriDgv.Location = new System.Drawing.Point(0, 233);
            this.kategoriDgv.Margin = new System.Windows.Forms.Padding(2);
            this.kategoriDgv.Name = "kategoriDgv";
            this.kategoriDgv.ReadOnly = true;
            this.kategoriDgv.RowHeadersWidth = 62;
            this.kategoriDgv.RowTemplate.Height = 28;
            this.kategoriDgv.Size = new System.Drawing.Size(754, 250);
            this.kategoriDgv.TabIndex = 5;
            this.kategoriDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kategoriDgv_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 150;
            // 
            // nama
            // 
            this.nama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nama.DataPropertyName = "nama";
            this.nama.HeaderText = "Nama";
            this.nama.MinimumWidth = 8;
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            // 
            // tipe
            // 
            this.tipe.DataPropertyName = "tipe";
            this.tipe.HeaderText = "Tipe";
            this.tipe.MinimumWidth = 8;
            this.tipe.Name = "tipe";
            this.tipe.ReadOnly = true;
            this.tipe.Width = 150;
            // 
            // cariTxt
            // 
            this.cariTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cariTxt.Location = new System.Drawing.Point(64, 194);
            this.cariTxt.Margin = new System.Windows.Forms.Padding(2);
            this.cariTxt.Name = "cariTxt";
            this.cariTxt.Size = new System.Drawing.Size(690, 23);
            this.cariTxt.TabIndex = 6;
            this.cariTxt.TextChanged += new System.EventHandler(this.cariTxt_TextChanged);
            // 
            // hapusBtn
            // 
            this.hapusBtn.BackColor = System.Drawing.Color.Brown;
            this.hapusBtn.FlatAppearance.BorderSize = 0;
            this.hapusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hapusBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapusBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hapusBtn.Location = new System.Drawing.Point(200, 128);
            this.hapusBtn.Margin = new System.Windows.Forms.Padding(2);
            this.hapusBtn.Name = "hapusBtn";
            this.hapusBtn.Size = new System.Drawing.Size(169, 40);
            this.hapusBtn.TabIndex = 7;
            this.hapusBtn.Text = "Hapus";
            this.hapusBtn.UseVisualStyleBackColor = false;
            this.hapusBtn.Click += new System.EventHandler(this.hapusBtn_Click);
            // 
            // batalBtn
            // 
            this.batalBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.batalBtn.FlatAppearance.BorderSize = 0;
            this.batalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.batalBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batalBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.batalBtn.Location = new System.Drawing.Point(397, 128);
            this.batalBtn.Margin = new System.Windows.Forms.Padding(2);
            this.batalBtn.Name = "batalBtn";
            this.batalBtn.Size = new System.Drawing.Size(167, 40);
            this.batalBtn.TabIndex = 8;
            this.batalBtn.Text = "Batal";
            this.batalBtn.UseVisualStyleBackColor = false;
            this.batalBtn.Click += new System.EventHandler(this.batalBtn_Click);
            // 
            // tutupBtn
            // 
            this.tutupBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tutupBtn.FlatAppearance.BorderSize = 0;
            this.tutupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tutupBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutupBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tutupBtn.Location = new System.Drawing.Point(593, 128);
            this.tutupBtn.Margin = new System.Windows.Forms.Padding(2);
            this.tutupBtn.Name = "tutupBtn";
            this.tutupBtn.Size = new System.Drawing.Size(161, 40);
            this.tutupBtn.TabIndex = 9;
            this.tutupBtn.Text = "Tutup";
            this.tutupBtn.UseVisualStyleBackColor = false;
            this.tutupBtn.Click += new System.EventHandler(this.tutupBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-3, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tipe";
            // 
            // tipeCmb
            // 
            this.tipeCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipeCmb.FormattingEnabled = true;
            this.tipeCmb.Items.AddRange(new object[] {
            "Pemasukan",
            "Pengeluaran"});
            this.tipeCmb.Location = new System.Drawing.Point(64, 73);
            this.tipeCmb.Margin = new System.Windows.Forms.Padding(2);
            this.tipeCmb.Name = "tipeCmb";
            this.tipeCmb.Size = new System.Drawing.Size(690, 24);
            this.tipeCmb.TabIndex = 12;
            // 
            // idTxt
            // 
            this.idTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxt.Location = new System.Drawing.Point(64, 50);
            this.idTxt.Margin = new System.Windows.Forms.Padding(2);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(690, 23);
            this.idTxt.TabIndex = 13;
            this.idTxt.Visible = false;
            // 
            // KategoriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 483);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.tipeCmb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tutupBtn);
            this.Controls.Add(this.batalBtn);
            this.Controls.Add(this.hapusBtn);
            this.Controls.Add(this.cariTxt);
            this.Controls.Add(this.kategoriDgv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.simpanBtn);
            this.Controls.Add(this.namaTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KategoriForm";
            this.Text = "KategoriForm";
            this.Load += new System.EventHandler(this.KategoriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kategoriDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox namaTxt;
        private System.Windows.Forms.Button simpanBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView kategoriDgv;
        private System.Windows.Forms.TextBox cariTxt;
        private System.Windows.Forms.Button hapusBtn;
        private System.Windows.Forms.Button batalBtn;
        private System.Windows.Forms.Button tutupBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox tipeCmb;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipe;
    }
}