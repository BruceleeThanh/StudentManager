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
    public partial class frmTsk_AddStu : DevExpress.XtraEditors.XtraForm {
		private DbDataContext db = new DbDataContext();

		//StudentEn stEN = new StudentEn();

        public frmTsk_AddStu () {
            InitializeComponent();
		}

        public void LoadData () {
            LoadFaculty();
        }

		// LoiNT
		private void btnAdd_Click(object sender, EventArgs e)
		{
			SaveInforStudent();
		}

		private void SaveInforStudent()
		{
			try
			{
                Student stu = new Student();
                stu.Stu_Code = txtStuCode.Text;
                stu.Stu_Name = txtStuName.Text;
                stu.Stu_DateOfBirth = editDate.Value;
                stu.Stu_HomeTown = txtNs.Text;
                stu.Stu_Address = txtAddress.Text;
                stu.Stu_PhoneNumber = txtPhone.Text;
                stu.Stu_Ethnic = txtEth.Text;
                stu.Stu_Religion = txtReligion.Text;

                // xu ly khoa va chuyen nganh
                StudentFaculty stFa = new StudentFaculty();


                //if (cmbFaculty.SelectedItem != null && cmbSpecialization.SelectedItem != null) {


                //    stFa.Stu_Code = stu.Stu_Code;

                //    var q = from m in db.Faculties where m.Fac_Name == cmbFaculty.SelectedItem select m.Fac_Code;

                //    stFa.Fac_Code = Int32.Parse(q.ToString()); // convert from string to int

                //    var p = from m in db.Specializations where m.Spe_Name == cmbSpecialization.SelectedItem select m.Spe_Code;
                //    stFa.Spe_Code = Int32.Parse(p.ToString());

                //}

                stFa.Stu_Code = stu.Stu_Code;
                List<int> CurrentFaculty = db.Faculties.Where(b => b.Fac_Name == cmbFaculty.SelectedValue.ToString()).Select(b => b.Fac_Code).Distinct().ToList();
                List<int> CurrentSpecialization = db.Specializations.Where(b => b.Spe_Name == cmbSpecialization.SelectedValue.ToString()).Select(b => b.Spe_Code).Distinct().ToList();
                stFa.Fac_Code = CurrentFaculty[0];
                stFa.Spe_Code = CurrentSpecialization[0];


				// get data for StudentEN object
				//stEN.setValue(stu);

                if (txtStuCode.Text != "" && txtStuName.Text != "" && txtAddress.Text != "") {
                    db.Students.InsertOnSubmit(stu);
                    db.StudentFaculties.InsertOnSubmit(stFa);
                    db.SubmitChanges();
                    if (db.Students.Count() > 0) {
                        MessageBox.Show("Thêm thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else {
                        MessageBox.Show("Thêm thất bại", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else {

                    MessageBox.Show("Không được để trống mã,tên sinh viên và địa chỉ.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
		}

        private void LoadFaculty () {
            cmbFaculty.SelectedValueChanged += new EventHandler(LoadSpecialization);
            cmbFaculty.DataSource = db.Faculties.Select(b => b.Fac_Name).ToList<string>();
        }

        public void LoadSpecialization (object sender, EventArgs e) {
            List<int> CurrentFaculty = db.Faculties.Where(b => b.Fac_Name == cmbFaculty.SelectedValue.ToString()).Select(b => b.Fac_Code).Distinct().ToList();
            cmbSpecialization.DataSource = db.Specializations.Where(b => b.Fac_Code == CurrentFaculty[0]).Select(b => b.Spe_Name).ToList<string>();
        }
        
    }
}