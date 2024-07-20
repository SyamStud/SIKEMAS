namespace kasMasjid.Interface
{
    partial class PemasukanForm
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
            this.tutupBtn = new System.Windows.Forms.Button();
            this.batalBtn = new System.Windows.Forms.Button();
            this.hapusBtn = new System.Windows.Forms.Button();
            this.cariTxt = new System.Windows.Forms.TextBox();
            this.pemasukanDgv = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nominal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keterangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.simpanBtn = new System.Windows.Forms.Button();
            this.nominalTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.keteranganTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kategoriCmb = new System.Windows.Forms.ComboBox();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.tanggalPick = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pemasukanDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tutupBtn
            // 
            this.tutupBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tutupBtn.FlatAppearance.BorderSize = 0;
            this.tutupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tutupBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutupBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tutupBtn.Location = new System.Drawing.Point(890, 245);
            this.tutupBtn.Name = "tutupBtn";
            this.tutupBtn.Size = new System.Drawing.Size(238, 62);
            this.tutupBtn.TabIndex = 19;
            this.tutupBtn.Text = "Tutup";
            this.tutupBtn.UseVisualStyleBackColor = false;
            this.tutupBtn.Click += new System.EventHandler(this.tutupBtn_Click);
            // 
            // batalBtn
            // 
            this.batalBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.batalBtn.FlatAppearance.BorderSize = 0;
            this.batalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.batalBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batalBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.batalBtn.Location = new System.Drawing.Point(596, 245);
            this.batalBtn.Name = "batalBtn";
            this.batalBtn.Size = new System.Drawing.Size(250, 62);
            this.batalBtn.TabIndex = 18;
            this.batalBtn.Text = "Batal";
            this.batalBtn.UseVisualStyleBackColor = false;
            this.batalBtn.Click += new System.EventHandler(this.batalBtn_Click);
            // 
            // hapusBtn
            // 
            this.hapusBtn.BackColor = System.Drawing.Color.Brown;
            this.hapusBtn.FlatAppearance.BorderSize = 0;
            this.hapusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hapusBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapusBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hapusBtn.Location = new System.Drawing.Point(297, 245);
            this.hapusBtn.Name = "hapusBtn";
            this.hapusBtn.Size = new System.Drawing.Size(254, 62);
            this.hapusBtn.TabIndex = 17;
            this.hapusBtn.Text = "Hapus";
            this.hapusBtn.UseVisualStyleBackColor = false;
            this.hapusBtn.Click += new System.EventHandler(this.hapusBtn_Click);
            // 
            // cariTxt
            // 
            this.cariTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cariTxt.Location = new System.Drawing.Point(94, 352);
            this.cariTxt.Name = "cariTxt";
            this.cariTxt.Size = new System.Drawing.Size(1033, 30);
            this.cariTxt.TabIndex = 16;
            this.cariTxt.TextChanged += new System.EventHandler(this.cariTxt_TextChanged);
            // 
            // pemasukanDgv
            // 
            this.pemasukanDgv.AllowUserToAddRows = false;
            this.pemasukanDgv.AllowUserToDeleteRows = false;
            this.pemasukanDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pemasukanDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nominal,
            this.kategori,
            this.keterangan,
            this.tanggal});
            this.pemasukanDgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pemasukanDgv.Location = new System.Drawing.Point(0, 414);
            this.pemasukanDgv.Name = "pemasukanDgv";
            this.pemasukanDgv.ReadOnly = true;
            this.pemasukanDgv.RowHeadersWidth = 62;
            this.pemasukanDgv.RowTemplate.Height = 28;
            this.pemasukanDgv.Size = new System.Drawing.Size(1131, 334);
            this.pemasukanDgv.TabIndex = 15;
            this.pemasukanDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pemasukanDgv_CellClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 8;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // nominal
            // 
            this.nominal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nominal.DataPropertyName = "nominal";
            this.nominal.HeaderText = "Nominal";
            this.nominal.MinimumWidth = 8;
            this.nominal.Name = "nominal";
            this.nominal.ReadOnly = true;
            // 
            // kategori
            // 
            this.kategori.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.kategori.DataPropertyName = "nama";
            this.kategori.HeaderText = "Kategori";
            this.kategori.MinimumWidth = 8;
            this.kategori.Name = "kategori";
            this.kategori.ReadOnly = true;
            // 
            // keterangan
            // 
            this.keterangan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.keterangan.DataPropertyName = "keterangan";
            this.keterangan.HeaderText = "Keterangan";
            this.keterangan.MinimumWidth = 8;
            this.keterangan.Name = "keterangan";
            this.keterangan.ReadOnly = true;
            // 
            // tanggal
            // 
            this.tanggal.DataPropertyName = "tanggal";
            this.tanggal.HeaderText = "Tanggal";
            this.tanggal.MinimumWidth = 8;
            this.tanggal.Name = "tanggal";
            this.tanggal.ReadOnly = true;
            this.tanggal.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-6, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cari";
            // 
            // simpanBtn
            // 
            this.simpanBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.simpanBtn.FlatAppearance.BorderSize = 0;
            this.simpanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.simpanBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpanBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.simpanBtn.Location = new System.Drawing.Point(-2, 245);
            this.simpanBtn.Name = "simpanBtn";
            this.simpanBtn.Size = new System.Drawing.Size(256, 62);
            this.simpanBtn.TabIndex = 13;
            this.simpanBtn.Text = "Simpan";
            this.simpanBtn.UseVisualStyleBackColor = false;
            this.simpanBtn.Click += new System.EventHandler(this.simpanBtn_Click);
            // 
            // nominalTxt
            // 
            this.nominalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nominalTxt.Location = new System.Drawing.Point(160, 18);
            this.nominalTxt.Name = "nominalTxt";
            this.nominalTxt.Size = new System.Drawing.Size(967, 30);
            this.nominalTxt.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nominal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 28);
            this.label3.TabIndex = 21;
            this.label3.Text = "Kategori";
            // 
            // keteranganTxt
            // 
            this.keteranganTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keteranganTxt.Location = new System.Drawing.Point(164, 168);
            this.keteranganTxt.Name = "keteranganTxt";
            this.keteranganTxt.Size = new System.Drawing.Size(966, 30);
            this.keteranganTxt.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-6, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 28);
            this.label4.TabIndex = 23;
            this.label4.Text = "Keterangan";
            // 
            // kategoriCmb
            // 
            this.kategoriCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategoriCmb.FormattingEnabled = true;
            this.kategoriCmb.Location = new System.Drawing.Point(164, 92);
            this.kategoriCmb.Name = "kategoriCmb";
            this.kategoriCmb.Size = new System.Drawing.Size(388, 33);
            this.kategoriCmb.TabIndex = 25;
            // 
            // idTxt
            // 
            this.idTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxt.Location = new System.Drawing.Point(164, 203);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(966, 30);
            this.idTxt.TabIndex = 26;
            this.idTxt.Visible = false;
            // 
            // tanggalPick
            // 
            this.tanggalPick.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tanggalPick.Location = new System.Drawing.Point(722, 91);
            this.tanggalPick.Name = "tanggalPick";
            this.tanggalPick.Size = new System.Drawing.Size(408, 30);
            this.tanggalPick.TabIndex = 27;
            this.tanggalPick.ValueChanged += new System.EventHandler(this.tanggalPick_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(590, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 28);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tanggal";
            // 
            // PemasukanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 748);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tanggalPick);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.kategoriCmb);
            this.Controls.Add(this.keteranganTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tutupBtn);
            this.Controls.Add(this.batalBtn);
            this.Controls.Add(this.hapusBtn);
            this.Controls.Add(this.cariTxt);
            this.Controls.Add(this.pemasukanDgv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.simpanBtn);
            this.Controls.Add(this.nominalTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PemasukanForm";
            this.Text = "PemasukanForm";
            this.Load += new System.EventHandler(this.PemasukanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pemasukanDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button tutupBtn;
        private System.Windows.Forms.Button batalBtn;
        private System.Windows.Forms.Button hapusBtn;
        private System.Windows.Forms.TextBox cariTxt;
        private System.Windows.Forms.DataGridView pemasukanDgv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button simpanBtn;
        private System.Windows.Forms.TextBox nominalTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox keteranganTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox kategoriCmb;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.DateTimePicker tanggalPick;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nominal;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn keterangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggal;
    }
}