using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using SchoolManager.Entity;
using SchoolManager.Form_Task;

namespace SchoolManager.Design {
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm {
        public Main () {
            InitializeComponent();
        }
		// LoiNT 
		// Add Student button
		private void barBtnAddStudent_ItemClick(object sender, ItemClickEventArgs e)
		{
			frmTsk_AddStu frmAdd = new frmTsk_AddStu();
            frmAdd.LoadData();
			frmAdd.Show();
            
		}

        private void Main_FormClosed (object sender, FormClosedEventArgs e) {
            
        }
		// Update Student Button
        private void barBtnUpdateStu_ItemClick (object sender, ItemClickEventArgs e) {
            frmTsk_UpdStu frmUpd = new frmTsk_UpdStu();
            frmUpd.Show();
		}
		// LoiNT
		// Add Teacher Button
		private void barBtnAddTeacher_ItemClick(object sender, ItemClickEventArgs e)
		{
			frmTsk_AddTeacher aFrmTask = new frmTsk_AddTeacher();
			aFrmTask.Show();

        }
		
    }
}