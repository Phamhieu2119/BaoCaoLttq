using connectdatabase;
using Guna.Charts.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
namespace BCVlxd
{
    public partial class Doanhthu : UserControl
    {
        ProcessDataBase pd = new ProcessDataBase();
        private Main mainForm;
        public Doanhthu()
        {
            InitializeComponent();
        }
        public Doanhthu(Main mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            pd.capNhat("update TienNhapKhoHang set TongTienNhap = a.Tien from TienNhapKhoHang as t join (select distinct month(n.Ngaynhap) as Thang,  sum(n.TongTien) as Tien from Nhapkho as n group by month(n.Ngaynhap)) as a on t.Thang = a.Thang");
            pd.capNhat("update TienXuatKhoHang set TongTienXuat = a.Tien from TienXuatKhoHang as t join (select distinct month(n.Ngayxuat) as Thang,  sum(n.TongTien) as Tien from Xuatkho as n group by month(n.Ngayxuat)) as a on t.Thang = a.Thang");

        }

        private void Doanhthu_Load(object sender, EventArgs e)
        {

        }
    }
}
