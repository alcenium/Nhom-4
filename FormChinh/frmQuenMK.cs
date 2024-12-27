using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormChinh
{
    public partial class frmQuenMK : Form
    {
        private frmDangNhap frm;
        public frmQuenMK(frmDangNhap frm)
        {
            this.frm = frm;
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQuenMK_FormClosing(object sender, FormClosingEventArgs e)
        {
            frm.Show();
        }
    }
}
