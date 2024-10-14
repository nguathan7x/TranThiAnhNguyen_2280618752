namespace De02
{
    partial class frmSanpham
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
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btThem = new System.Windows.Forms.Button();
            this.dgvSanpham = new System.Windows.Forms.DataGridView();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.btKLuu = new System.Windows.Forms.Button();
            this.btThoat = new System.Windows.Forms.Button();
            this.btTim = new System.Windows.Forms.Button();
            this.cboLoaiSP = new System.Windows.Forms.ComboBox();
            this.dtNgaynhap = new System.Windows.Forms.DateTimePicker();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC SẢN PHẨM";
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(124, 84);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(210, 27);
            this.txtTim.TabIndex = 1;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // btThem
            // 
            this.btThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btThem.Location = new System.Drawing.Point(93, 395);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 43);
            this.btThem.TabIndex = 2;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // dgvSanpham
            // 
            this.dgvSanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSanpham.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanpham.Location = new System.Drawing.Point(124, 117);
            this.dgvSanpham.Name = "dgvSanpham";
            this.dgvSanpham.RowHeadersWidth = 51;
            this.dgvSanpham.RowTemplate.Height = 24;
            this.dgvSanpham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanpham.Size = new System.Drawing.Size(485, 272);
            this.dgvSanpham.TabIndex = 3;
            this.dgvSanpham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanpham_CellContentClick);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(187, 395);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(75, 43);
            this.btSua.TabIndex = 2;
            this.btSua.Text = "Sửa";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(297, 395);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(75, 43);
            this.btXoa.TabIndex = 2;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(399, 395);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(75, 43);
            this.btLuu.TabIndex = 2;
            this.btLuu.Text = "Lưu";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // btKLuu
            // 
            this.btKLuu.Location = new System.Drawing.Point(494, 395);
            this.btKLuu.Name = "btKLuu";
            this.btKLuu.Size = new System.Drawing.Size(75, 43);
            this.btKLuu.TabIndex = 2;
            this.btKLuu.Text = "K.Lưu";
            this.btKLuu.UseVisualStyleBackColor = true;
            this.btKLuu.Click += new System.EventHandler(this.btKLuu_Click);
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(591, 395);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(75, 43);
            this.btThoat.TabIndex = 2;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btTim
            // 
            this.btTim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.btTim.Location = new System.Drawing.Point(369, 80);
            this.btTim.Name = "btTim";
            this.btTim.Size = new System.Drawing.Size(75, 31);
            this.btTim.TabIndex = 2;
            this.btTim.Text = "Tìm";
            this.btTim.UseVisualStyleBackColor = true;
            // 
            // cboLoaiSP
            // 
            this.cboLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.cboLoaiSP.FormattingEnabled = true;
            this.cboLoaiSP.Location = new System.Drawing.Point(741, 270);
            this.cboLoaiSP.Name = "cboLoaiSP";
            this.cboLoaiSP.Size = new System.Drawing.Size(121, 28);
            this.cboLoaiSP.TabIndex = 9;
            // 
            // dtNgaynhap
            // 
            this.dtNgaynhap.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.dtNgaynhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtNgaynhap.Location = new System.Drawing.Point(741, 237);
            this.dtNgaynhap.Name = "dtNgaynhap";
            this.dtNgaynhap.Size = new System.Drawing.Size(243, 22);
            this.dtNgaynhap.TabIndex = 8;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtTenSP.Location = new System.Drawing.Point(741, 199);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(200, 27);
            this.txtTenSP.TabIndex = 6;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.txtMaSP.Location = new System.Drawing.Point(741, 157);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(100, 27);
            this.txtMaSP.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(685, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mã SP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(680, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tên SP:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(659, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày nhập:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(678, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Loại SP:";
            // 
            // frmSanpham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboLoaiSP);
            this.Controls.Add(this.dtNgaynhap);
            this.Controls.Add(this.txtTenSP);
            this.Controls.Add(this.txtMaSP);
            this.Controls.Add(this.dgvSanpham);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btKLuu);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.btSua);
            this.Controls.Add(this.btTim);
            this.Controls.Add(this.btThem);
            this.Controls.Add(this.txtTim);
            this.Controls.Add(this.label1);
            this.Name = "frmSanpham";
            this.Text = "QUAN LY SAN PHAM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSanpham_FormClosing);
            this.Load += new System.EventHandler(this.frmQuanLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanpham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.DataGridView dgvSanpham;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.Button btKLuu;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btTim;
        private System.Windows.Forms.ComboBox cboLoaiSP;
        private System.Windows.Forms.DateTimePicker dtNgaynhap;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

