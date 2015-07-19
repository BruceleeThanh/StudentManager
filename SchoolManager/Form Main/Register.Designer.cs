namespace SchoolManager.Form_Main
{
	partial class Register
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
			this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
			this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
			this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
			this.txtPassword = new DevExpress.XtraEditors.TextEdit();
			this.txtUserName = new DevExpress.XtraEditors.TextEdit();
			this.btnRegister = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureEdit1
			// 
			this.pictureEdit1.EditValue = global::SchoolManager.Properties.Resources.thanglong;
			this.pictureEdit1.Location = new System.Drawing.Point(66, 12);
			this.pictureEdit1.Name = "pictureEdit1";
			this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
			this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.pictureEdit1.Size = new System.Drawing.Size(99, 165);
			this.pictureEdit1.TabIndex = 15;
			// 
			// pictureEdit3
			// 
			this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
			this.pictureEdit3.Location = new System.Drawing.Point(237, 108);
			this.pictureEdit3.Name = "pictureEdit3";
			this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.pictureEdit3.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
			this.pictureEdit3.Properties.Appearance.Options.UseForeColor = true;
			this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.pictureEdit3.Size = new System.Drawing.Size(33, 33);
			this.pictureEdit3.TabIndex = 19;
			// 
			// pictureEdit2
			// 
			this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
			this.pictureEdit2.Location = new System.Drawing.Point(237, 70);
			this.pictureEdit2.Name = "pictureEdit2";
			this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.pictureEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
			this.pictureEdit2.Properties.Appearance.Options.UseForeColor = true;
			this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.pictureEdit2.Size = new System.Drawing.Size(33, 33);
			this.pictureEdit2.TabIndex = 18;
			// 
			// txtPassword
			// 
			this.txtPassword.EditValue = "";
			this.txtPassword.Location = new System.Drawing.Point(286, 112);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
			this.txtPassword.Properties.NullValuePrompt = "******";
			this.txtPassword.Properties.NullValuePromptShowForEmptyValue = true;
			this.txtPassword.Properties.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(198, 20);
			this.txtPassword.TabIndex = 17;
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(286, 78);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Properties.Appearance.BackColor = System.Drawing.Color.White;
			this.txtUserName.Properties.Appearance.Options.UseBackColor = true;
			this.txtUserName.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003;
			this.txtUserName.Size = new System.Drawing.Size(198, 20);
			this.txtUserName.TabIndex = 16;
			// 
			// btnRegister
			// 
			this.btnRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnRegister.Image")));
			this.btnRegister.Location = new System.Drawing.Point(360, 151);
			this.btnRegister.Name = "btnRegister";
			this.btnRegister.Size = new System.Drawing.Size(124, 26);
			this.btnRegister.TabIndex = 20;
			this.btnRegister.Text = "Đăng Kí";
			this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
			// 
			// Register
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(509, 244);
			this.Controls.Add(this.btnRegister);
			this.Controls.Add(this.pictureEdit3);
			this.Controls.Add(this.pictureEdit2);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.pictureEdit1);
			this.Name = "Register";
			this.Text = "Đăng Kí";
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PictureEdit pictureEdit1;
		private DevExpress.XtraEditors.PictureEdit pictureEdit3;
		private DevExpress.XtraEditors.PictureEdit pictureEdit2;
		private DevExpress.XtraEditors.TextEdit txtPassword;
		private DevExpress.XtraEditors.TextEdit txtUserName;
		private DevExpress.XtraEditors.SimpleButton btnRegister;
	}
}