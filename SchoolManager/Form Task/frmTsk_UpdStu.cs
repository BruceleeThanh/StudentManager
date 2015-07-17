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
using SchoolManager.Entity;
using DataAccess;

namespace SchoolManager.Form_Task {
    public partial class frmTsk_UpdStu : DevExpress.XtraEditors.XtraForm {
        private DbDataContext db = new DbDataContext ( );
        private List<Student> stu = new List<Student> ( );
        StudentEn stuEn = new StudentEn ();       

        public frmTsk_UpdStu( ) {
            InitializeComponent ( );
        }

        private void btnSearch_Click( object sender, EventArgs e ) {
            stu = db.Students.Where ( b => b.Stu_Code == txtCode.Text ).Distinct().ToList<Student> ( );
            if ( stu != null ) {
                txtCode.Enabled = false;
                txtName.Text = stu[0].Stu_Name;
                editDate.Text = stu[0].Stu_DateOfBirth.ToString();
                txtHomeTown.Text = stu[0].Stu_HomeTown;
                txtAddress.Text = stu[0].Stu_Address;
                txtPhone.Text = stu[0].Stu_PhoneNumber;
                txtEthnic.Text = stu[0].Stu_Ethnic;
                txtReligion.Text = stu[0].Stu_Religion;

            } else {
                MessageBox.Show("Không tìm thấy thông tin.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpd_Click( object sender, EventArgs e ) {
            SaveInforStudent ( );
        }

        private void SaveInforStudent( ) {
            try {
                Student stu = new Student ( );
                stu.Stu_Code = txtCode.Text;
                stu.Stu_Name = txtName.Text;
                stu.Stu_DateOfBirth = editDate.Value;
                stu.Stu_HomeTown = txtHomeTown.Text;
                stu.Stu_Address = txtAddress.Text;
                stu.Stu_PhoneNumber = txtPhone.Text;

                stuEn.setValue ( stu );
                db.Students.InsertOnSubmit ( stu );
                db.SubmitChanges ( );
                int temp = db.Students.Count ( );
                if ( db.Students.Count ( ) == temp + 1 )
				{
                    MessageBox.Show ( "Sử thông tin thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    this.Visible = false;
                } else {
                    MessageBox.Show ( "Không thể sửa được thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }

            }
            catch ( Exception ex ) {
                MessageBox.Show ( ex.ToString ( ), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }
        // chon ton giao
        private void comboBoxReligion_SelectedIndexChanged( object sender, EventArgs e ) {

        }

    }
}