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
using BusinessLogic;
using SchoolManager.Entity;

namespace SchoolManager.Form_Task
{
	public partial class frmTsk_UpdateTeacher : DevExpress.XtraEditors.XtraForm
	{
		private DbDataContext db = new DbDataContext();
		private TeacherBO aTeacherBO = new TeacherBO();
		private Teacher aTeacher = new Teacher();

		public frmTsk_UpdateTeacher()
		{
			InitializeComponent();
		}

		private void btnDone_Click(object sender, EventArgs e)
		{
			try
			{
				aTeacher.Tea_Name = txtBoxName.Text;
				aTeacher.Tea_DateOfBirth = dateArea.Value;
				aTeacher.Tea_HomeTown = txtHometown.Text;
				aTeacher.Tea_Address = txtAddress.Text;
				aTeacher.Tea_PhoneNumber = txtPhone.Text;
				aTeacher.Tea_Address = txtAddress.Text;
				aTeacher.Tea_Religion = txtRegilion.Text;
				aTeacher.Tea_Ethnic = txtEthnic.Text;

				if (aTeacherBO.Insert(aTeacher))
				{
					MessageBox.Show("Thành Công", "Thành Công", MessageBoxButtons.OK);
				}
				else
				{
					MessageBox.Show("Thất Bại", "Thất Bại", MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "Thất Bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoadText(object sender,EventArgs e)
		{
			try
			{
			
				//chua xong
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "Thất Bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		

		private void frmTsk_UpdateTeacher_Load_1(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'schoolsManagerDataSet1.Teacher' table. You can move, or remove it, as needed.
			this.teacherTableAdapter.Fill(this.schoolsManagerDataSet1.Teacher);

		}

		private void Click_TextArea(object sender, MouseEventArgs e)
		{
			// chua xong
		}
		
	}
}