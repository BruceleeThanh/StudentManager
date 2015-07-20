using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using DataAccess;


namespace BusinessLogic
{
	public class UserBO 
	{
		private DbDataContext db = new DbDataContext();
		
		// Select By All
		public List<User> Select_ByAll()
		{
			try
			{
				return db.Users.OrderByDescending(b => b.Use_Name).ToList<User>();
			}
			catch (Exception ex)
			{
				throw new Exception("UserBO.Select_ByAll" + ex.ToString());
			}
		}
		// Select By Name
		public List<User> Select_ByName(string name)
		{

			try
			{
				return db.Users.Where(b => b.Use_Name == name).ToList<User>();
			}
			catch (Exception ex)
			{
				throw new Exception("UserBO.Select_ByName" + ex.ToString());
			}
		}
		//Select By Name and Password
		public List<User> Select_ByNameAndPass(string name,string pass)
		{
			try
			{
				return db.Users.Where(b => b.Use_Name == name).Where(b=>b.Use_Password == pass).ToList<User>();
			}
			catch (Exception ex)
			{
				throw new Exception("UserBO.Select_ByNameAndPass" + ex.ToString());
			}
		}
		
		// Insert
		public bool Insert(string name, string password)
		{
			try
			{
                string passSHA1;
                passSHA1 = ToSHA1(password);
                var user = db.Users.Where(b => b.Use_Name == name).Where(b => b.Use_Password == passSHA1).ToList<User>();
				if (user.Any())
				{
					return true;
				}
				else
				{
					return false;
				}
				
			}
			catch (Exception ex)
			{
				
				throw new Exception("UserBO.Login" + ex.ToString());
			}
		}
		// Insert -- Register
		public bool Register(User aUser)
		{
			try
			{
				// encrypt password 
                aUser.Use_Password = ToSHA1(aUser.Use_Password);
				db.Users.InsertOnSubmit(aUser);
				db.SubmitChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
				throw new Exception("UserBO.Insert" + ex.ToString());
			}
		}

        // SHA1
        private string ToSHA1 (string pass) {
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(pass);
            bs = sha1.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs) {
                s.Append(b.ToString("x1").ToLower());
            }
            pass = s.ToString();
            return pass;
        }
		
	}
}
