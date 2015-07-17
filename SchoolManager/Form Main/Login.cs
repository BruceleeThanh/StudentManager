using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataAccess;

namespace SchoolManager.Design {
    public partial class Login : DevExpress.XtraEditors.XtraForm {
		private DbDataContext db = new DbDataContext();
        public Login () {
            InitializeComponent();
        }
		
		private void btnLogin_Click(object sender, EventArgs e)
		{
			var q = from m in db.Users
					where m.Use_Name == txtUserName.Text && m.Use_Password == txtPassword.Text
					select m;

			if (q.Any())
			{
				Main aMain = new Main();
                aMain.Show();
				this.Visible = false;
			}
			else
			{
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

        private void MatchingEnterPress (object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                var q = from m in db.Users
                        where m.Use_Name == txtUserName.Text && m.Use_Password == txtPassword.Text
                        select m;

                if (q.Any()) {
                    Main aMain = new Main();
                    aMain.Show();
                    this.Visible = false;
                }
                else {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
      
    }
}