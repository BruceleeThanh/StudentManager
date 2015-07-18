using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
		//  Login
		// Check username and password of user is correct
		public bool Login(string name, string password)
		{
			try
			{
				var user = db.Users.Where(b => b.Use_Name == name).Where(b => b.Use_Password == password).ToList<User>();
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
				return false;
				throw new Exception("UserBO.Login" + ex.ToString());
			}
		}
		// Insert -- Register
		public bool Insert(User aUser)
		{
			try
			{
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
	}
}
