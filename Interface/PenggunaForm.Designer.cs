namespace kasMasjid.Interface
{
    partial class PenggunaForm
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
            this.idTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tutupBtn = new System.Windows.Forms.Button();
            this.batalBtn = new System.Windows.Forms.Button();
            this.hapusBtn = new System.Windows.Forms.Button();
            this.cariTxt = new System.Windows.Forms.TextBox();
            this.penggunaDgv = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.simpanBtn = new System.Windows.Forms.Button();
            this.namaTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.penggunaDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // idTxt
            // 
            this.idTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTxt.Location = new System.Drawing.Point(111, 123);
            this.idTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(645, 23);
            this.idTxt.TabIndex = 54;
            this.idTxt.Visible = false;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(111, 99);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(645, 23);
            this.passwordTxt.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-2, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 51;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-2, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 50;
            this.label3.Text = "Username";
            // 
            // tutupBtn
            // 
            this.tutupBtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tutupBtn.FlatAppearance.BorderSize = 0;
            this.tutupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tutupBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tutupBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tutupBtn.Location = new System.Drawing.Point(595, 150);
            this.tutupBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tutupBtn.Name = "tutupBtn";
            this.tutupBtn.Size = new System.Drawing.Size(159, 40);
            this.tutupBtn.TabIndex = 49;
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
            this.batalBtn.Location = new System.Drawing.Point(399, 150);
            this.batalBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.batalBtn.Name = "batalBtn";
            this.batalBtn.Size = new System.Drawing.Size(167, 40);
            this.batalBtn.TabIndex = 48;
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
            this.hapusBtn.Location = new System.Drawing.Point(200, 150);
            this.hapusBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.hapusBtn.Name = "hapusBtn";
            this.hapusBtn.Size = new System.Drawing.Size(169, 40);
            this.hapusBtn.TabIndex = 47;
            this.hapusBtn.Text = "Hapus";
            this.hapusBtn.UseVisualStyleBackColor = false;
            this.hapusBtn.Click += new System.EventHandler(this.hapusBtn_Click);
            // 
            // cariTxt
            // 
            this.cariTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cariTxt.Location = new System.Drawing.Point(65, 220);
            this.cariTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cariTxt.Name = "cariTxt";
            this.cariTxt.Size = new System.Drawing.Size(690, 23);
            this.cariTxt.TabIndex = 46;
            this.cariTxt.TextChanged += new System.EventHandler(this.cariTxt_TextChanged);
            // 
            // penggunaDgv
            // 
            this.penggunaDgv.AllowUserToAddRows = false;
            this.penggunaDgv.AllowUserToDeleteRows = false;
            this.penggunaDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.penggunaDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nama,
            this.username,
            this.password});
            this.penggunaDgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.penggunaDgv.Location = new System.Drawing.Point(0, 265);
            this.penggunaDgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.penggunaDgv.Name = "penggunaDgv";
            this.penggunaDgv.ReadOnly = true;
            this.penggunaDgv.RowHeadersWidth = 62;
            this.penggunaDgv.RowTemplate.Height = 28;
            this.penggunaDgv.Size = new System.Drawing.Size(756, 217);
            this.penggunaDgv.TabIndex = 45;
            this.penggunaDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.penggunaDgv_CellClick);
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
            // nama
            // 
            this.nama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nama.DataPropertyName = "nama";
            this.nama.HeaderText = "Nama";
            this.nama.MinimumWidth = 8;
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            // 
            // username
            // 
            this.username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "Username";
            this.username.MinimumWidth = 8;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // password
            // 
            this.password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "Password";
            this.password.MinimumWidth = 8;
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 220);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 18);
            this.label2.TabIndex = 44;
            this.label2.Text = "Cari";
            // 
            // simpanBtn
            // 
            this.simpanBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.simpanBtn.FlatAppearance.BorderSize = 0;
            this.simpanBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.simpanBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpanBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.simpanBtn.Location = new System.Drawing.Point(1, 150);
            this.simpanBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.simpanBtn.Name = "simpanBtn";
            this.simpanBtn.Size = new System.Drawing.Size(171, 40);
            this.simpanBtn.TabIndex = 43;
            this.simpanBtn.Text = "Simpan";
            this.simpanBtn.UseVisualStyleBackColor = false;
            this.simpanBtn.Click += new System.EventHandler(this.simpanBtn_Click);
            // 
            // namaTxt
            // 
            this.namaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaTxt.Location = new System.Drawing.Point(109, 3);
            this.namaTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.namaTxt.Name = "namaTxt";
            this.namaTxt.Size = new System.Drawing.Size(646, 23);
            this.namaTxt.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-2, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nama";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(109, 51);
            this.usernameTxt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(646, 23);
            this.usernameTxt.TabIndex = 55;
            // 
            // PenggunaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 482);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tutupBtn);
            this.Controls.Add(this.batalBtn);
            this.Controls.Add(this.hapusBtn);
            this.Controls.Add(this.cariTxt);
            this.Controls.Add(this.penggunaDgv);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.simpanBtn);
            this.Controls.Add(this.namaTxt);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PenggunaForm";
            this.Text = "PenggunaForm";
            this.Load += new System.EventHandler(this.PenggunaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.penggunaDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button tutupBtn;
        private System.Windows.Forms.Button batalBtn;
        private System.Windows.Forms.Button hapusBtn;
        private System.Windows.Forms.TextBox cariTxt;
        private System.Windows.Forms.DataGridView penggunaDgv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button simpanBtn;
        private System.Windows.Forms.TextBox namaTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
    }
}