using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace De02
{
    public partial class frmSanpham : Form
    {
        QLSanphamEntities me = new QLSanphamEntities();

        public frmSanpham()
        {
            InitializeComponent();
        }

        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            loadData();
            loadCMB();
            btLuu.Visible = false;
            btKLuu.Visible = false;
        }

        void loadData()
        {
            var n = me.Sanphams.ToList();
            dgvSanpham.DataSource = n;
        }

        void loadCMB()
        {
            var loaiSPList = me.LoaiSPs.ToList();

            // Gán dữ liệu vào ComboBox
            cboLoaiSP.DataSource = loaiSPList;
            cboLoaiSP.DisplayMember = "TenLoai";  // Hiển thị tên loại sản phẩm
            cboLoaiSP.ValueMember = "MaLoai";
        }

        private void dgvSanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Lấy dòng hiện tại từ DataGridView
                DataGridViewRow row = dgvSanpham.Rows[e.RowIndex];

                // Gán dữ liệu của dòng đó vào các TextBox và ComboBox
                txtMaSP.Text = row.Cells["MaSP"].Value.ToString();  // Hiển thị Mã sản phẩm
                txtTenSP.Text = row.Cells["TenSP"].Value.ToString();  // Hiển thị Tên sản phẩm
                dtNgaynhap.Value = Convert.ToDateTime(row.Cells["Ngaynhap"].Value);  // Hiển thị Ngày nhập

                // Gán loại sản phẩm vào ComboBox theo MaLoai
                cboLoaiSP.SelectedValue = row.Cells["MaLoai"].Value.ToString();  // Chọn MaLoai trong ComboBox
            }
        }

        private void frmSanpham_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {// Hiện nút Lưu và Không lưu
            btLuu.Visible = true;
            btKLuu.Visible = true;

            // Ẩn các nút khác
            btThem.Visible = false;
            btSua.Visible = false;
            btXoa.Visible = false;

            // Xóa dữ liệu trên form để nhập dữ liệu mới
            txtMaSP.Clear();
            txtTenSP.Clear();
            dtNgaynhap.Value = DateTime.Now;
            cboLoaiSP.SelectedIndex = 0;
        }

           
        private void btSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có sản phẩm nào được chọn để sửa không
            if (string.IsNullOrEmpty(txtMaSP.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiện nút Lưu và Không lưu
            btLuu.Visible = true;
            btKLuu.Visible = true;

            // Ẩn các nút khác
            btThem.Visible = false;
            btSua.Visible = false;
            btXoa.Visible = false;
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có sản phẩm nào được chọn để xóa không
            if (string.IsNullOrEmpty(txtMaSP.Text))
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị thông báo xác nhận xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    // Lấy Mã sản phẩm để tìm sản phẩm cần xóa
                    string maSP = txtMaSP.Text.Trim();

                    // Tìm sản phẩm trong CSDL dựa trên MaSP
                    var sp = me.Sanphams.FirstOrDefault(x => x.MaSP == maSP);
                    if (sp != null)
                    {
                        // Xóa sản phẩm khỏi CSDL
                        me.Sanphams.Remove(sp);
                        me.SaveChanges(); // Lưu thay đổi vào CSDL

                        // Cập nhật lại DataGridView
                        loadData();

                        // Thông báo thành công
                        MessageBox.Show("Xóa sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Xóa dữ liệu trên form để nhập dữ liệu mới
                        txtMaSP.Clear();
                        txtTenSP.Clear();
                        dtNgaynhap.Value = DateTime.Now;
                        cboLoaiSP.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("Sản phẩm không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            // Lấy giá trị tìm kiếm từ TextBox
            string searchText = txtTim.Text.Trim();

            // Tìm kiếm sản phẩm theo tên sản phẩm
            var filteredList = me.Sanphams
                .Where(sp => sp.TenSP.Contains(searchText)) // Tìm sản phẩm có tên chứa searchText
                .ToList();

            // Cập nhật lại DataGridView với danh sách đã lọc
            dgvSanpham.DataSource = filteredList;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy Mã sản phẩm để kiểm tra nếu đang sửa
                string maSP = txtMaSP.Text.Trim();
                string tenSP = txtTenSP.Text.Trim();
                DateTime ngayNhap = dtNgaynhap.Value;
                string maLoai = cboLoaiSP.SelectedValue.ToString();

                // Kiểm tra nếu các trường không được để trống
                if (string.IsNullOrEmpty(tenSP))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Kiểm tra xem có đang sửa hay thêm sản phẩm
                var existingProduct = me.Sanphams.FirstOrDefault(x => x.MaSP == maSP);

                if (existingProduct != null)
                {
                    // Nếu sản phẩm đã tồn tại, thực hiện cập nhật
                    existingProduct.TenSP = tenSP;
                    existingProduct.Ngaynhap = ngayNhap;
                    existingProduct.MaLoai = maLoai;

                    // Lưu thay đổi vào CSDL
                    me.SaveChanges();

                    // Cập nhật lại DataGridView
                    loadData();

                    // Thông báo thành công
                    MessageBox.Show("Sửa thông tin sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Nếu sản phẩm không tồn tại, thực hiện thêm mới
                    Sanpham newProduct = new Sanpham
                    {
                        MaSP = maSP,
                        TenSP = tenSP,
                        Ngaynhap = ngayNhap,
                        MaLoai = maLoai
                    };

                    // Thêm sản phẩm vào CSDL
                    me.Sanphams.Add(newProduct);
                    me.SaveChanges();

                    // Cập nhật lại DataGridView
                    loadData();

                    // Thông báo thành công
                    MessageBox.Show("Thêm sản phẩm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Xóa dữ liệu trên form để nhập dữ liệu mới
                txtMaSP.Clear();
                txtTenSP.Clear();
                dtNgaynhap.Value = DateTime.Now;
                cboLoaiSP.SelectedIndex = 0;

                // Ẩn nút Lưu và Không lưu
                btLuu.Visible = false;
                btKLuu.Visible = false;

                // Hiện lại các nút khác
                btThem.Visible = true;
                btSua.Visible = true;
                btXoa.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btKLuu_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            dtNgaynhap.Value = DateTime.Now;
            cboLoaiSP.SelectedIndex = 0;

            // Ẩn nút Lưu và Không lưu
            btLuu.Visible = false;
            btKLuu.Visible = false;

            // Hiện lại các nút khác
            btThem.Visible = true;
            btSua.Visible = true;
            btXoa.Visible = true;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
