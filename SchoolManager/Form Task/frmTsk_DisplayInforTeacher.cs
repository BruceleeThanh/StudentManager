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

namespace SchoolManager.Form_Task
{
	public partial class frmTsk_DisplayInforTeacher : DevExpress.XtraEditors.XtraForm
	{
		public frmTsk_DisplayInforTeacher()
		{
			InitializeComponent();
		}

		private void frmTsk_DisplayInforTeacher_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'schoolsManagerDataSet.Teacher' table. You can move, or remove it, as needed.
			this.teacherTableAdapter.Fill(this.schoolsManagerDataSet.Teacher);

		}
	}
}