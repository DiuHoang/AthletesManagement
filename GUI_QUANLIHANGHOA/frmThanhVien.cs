using BUS_QUANLIHANGHOA;
using DTO_QUANLIHANGHOA;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI_QUANLIHANGHOA
{
    public partial class frmThanhVien : Form
    {
        BUS_ThanhVien busThanhVien = new BUS_ThanhVien();


        public frmThanhVien()
        {
            InitializeComponent();
        }

        private void LoadThanhVien()
        {
            dgvThanhVien.DataSource = busThanhVien.GetThanhVien();

            int j = 1;
            foreach (DataGridViewRow i in dgvThanhVien.Rows)
            {
                if (i != null)
                {
                    i.Cells[0].Value = j;
                    j += 1;
                }
            }
        }

        private void frmThanhVien_Load(object sender, EventArgs e)
        {
            LoadThanhVien();
            dgvThanhVien.Rows[0].Selected = false;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                int gt;
                if (cboGioiTinh.SelectedIndex == 1)
                {
                    gt = 1;
                }
                else
                {
                    gt = 0;
                }
                DTO_ThanhVien DTO_ThanhVien = new DTO_ThanhVien()
                {
                    MaThanhVien = txtMaThanhVien.Text,
                    HoTen = txtTenThanhVien.Text,
                    NgaySinh = dtpNgaySinh.Value,
                    GioiTinh = gt,
                    SoThich = txtSoThich.Text,
                    DiaChi = txtDiaChi.Text
                };
                busThanhVien.ThemThanhVien(DTO_ThanhVien);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            txtMaThanhVien.Clear();
            txtTenThanhVien.Clear();
            txtSoThich.Clear();
            txtDiaChi.Clear();
            cboGioiTinh.SelectedIndex = -1;
            frmThanhVien_Load(sender, e);
        }
    }
}
