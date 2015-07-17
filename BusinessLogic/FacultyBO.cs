﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;


namespace BusinessLogic
{
	public class FacultyBO
	{
		private DbDataContext db = new DbDataContext();
		
		// select all Faculty from DB
		public List<Faculty> Select_All()
		{
			try
			{
				return db.Faculties.OrderByDescending(b => b.Fac_Code).ToList<Faculty>();
			}
			catch (Exception ex)
			{
				throw new Exception("FacultyBO.Select_All" + ex.ToString());
			}
		}
		// select Faculty by ID
		public List<Faculty> Select_ById(int id)
		{
			try
			{
				return db.Faculties.Where(b => b.Fac_Code == id).ToList<Faculty>();
			}
			catch (Exception ex)
			{
				throw new Exception("FacultyBO.Select_ById" + ex.ToString());
			}
		}
		// select Faculty by Name
		public List<Faculty> Select_ByName(string name)
		{
			try
			{
				return db.Faculties.Where(b => b.Fac_Name == name).ToList<Faculty>();
			}
			catch (Exception ex)
			{
				throw new Exception("FacultyBO.Select_ByID" + ex.ToString());
			}
		}

		// insert new Faculty 
		public bool Insert(Faculty aFaculty)
		{
			try
			{
				db.Faculties.InsertOnSubmit(aFaculty);
				db.SubmitChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
				throw new Exception("FacultyBO.Insert: " + ex.ToString());
			}
		}

		// update Faculty

		public bool Update(Faculty aFaculty)
		{
			try
			{
				var obj = from m in db.Faculties
							where m.Fac_Code == aFaculty.Fac_Code
							select m;
				foreach (var oFa in obj)
				{
					oFa.Fac_Name = aFaculty.Fac_Name;
				}
				db.SubmitChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
				throw new Exception("FacultyBO.Update: " + ex.ToString());
			}
		}

		// delete Faculty
		public bool Delete(Faculty aFaculty)
		{
			try
			{
				var obj = from m in db.Faculties
						  where m.Fac_Code == aFaculty.Fac_Code
						  select m;
				foreach (var oFa in obj)
				{
					db.Faculties.DeleteOnSubmit(oFa);
				}
				db.SubmitChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
				throw new Exception("FacultyBO.Update: " + ex.ToString());
			}
		}
	}
}