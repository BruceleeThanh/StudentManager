using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using BusinessLogic;


namespace SchoolManager.Form_Main
{
	
	public partial class Register : Form
	{
		private DbDataContext db = new DbDataContext();
		private UserBO aUserBO = new UserBO();
	

		public Register()
		{
			InitializeComponent();
		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			User aUser = new User();
			// Check Username is exits
			// If db is not exits then register success, otherwise register fail
			if (aUserBO.CheckName(txtUserName.Text))
			{
				aUser.Use_Name = txtUserName.Text;
				aUser.Use_Password = txtUserName.Text;
				
				if (aUserBO.Register(aUser))
				{
					MessageBox.Show("Thành Công","Thành Công",MessageBoxButtons.OK);
				}
				else
				{
					MessageBox.Show("Tài khoản đã tồn tại.","Thất Bại",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}

			}
		}
		private void EnterRegister(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				User aUser = new User();
				// Check Username is exits
				// If db is not exits then register success, otherwise register fail
				if (aUserBO.CheckName(txtUserName.Text))
				{
					aUser.Use_Name = txtUserName.Text;
					aUser.Use_Password = txtUserName.Text;

					if (aUserBO.Register(aUser))
					{
						MessageBox.Show("Thành Công", "Thành Công", MessageBoxButtons.OK);
					}
					else
					{
						MessageBox.Show("Tài khoản đã tồn tại.", "Thất Bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}

				}
			}
		}
		
	}
}
