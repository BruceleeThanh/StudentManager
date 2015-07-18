using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic
{
	public class StudentFacultyBO
	{
		private DbDataContext db = new DbDataContext();
		// Select All
		public List<StudentFaculty> Select_All()
		{
			try
			{
				return db.StudentFaculties.OrderByDescending(b => b.Fac_Code).ToList<StudentFaculty>();
			}
			catch (Exception ex)
			{
				throw new Exception("StudentFacultyBO.Select_All" + ex.ToString());
			}
		}
		// Select by Student Id

		public List<StudentFaculty> Select_ByIDStudent(string idStu)
		{
			try
			{
				return db.StudentFaculties.Where(b => b.Stu_Code == idStu).ToList<StudentFaculty>();
			}
			catch (Exception ex)
			{
				throw new Exception("StudentFacultyBO.Select_ByIDStudent" + ex.ToString());
			}
		}

		// Select by Specialization ID
		public List<StudentFaculty> Select_ByIDSpecialization(int idSpec)
		{
			try
			{
				return db.StudentFaculties.Where(b=>b.Spe_Code == idSpec).ToList<StudentFaculty>();
			}
			catch (Exception ex)
			{
				throw new Exception("StudentFacultyBO.Select_ByIDSpecialization" + ex.ToString());
			}
		}

		// Insert
		public bool Insert(StudentFaculty aStudentFaculty)
		{
			try
			{
				db.StudentFaculties.InsertOnSubmit(aStudentFaculty);
				db.SubmitChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
				throw new Exception("StudentFacultyBO.Insert" + ex.ToString());
			}
		}
		// Update
		public bool Update(StudentFaculty aStudentFaculty)
		{
			try
			{
				var obj = from m in db.StudentFaculties
						  where m.Stu_Code == aStudentFaculty.Stu_Code && m.Fac_Code == aStudentFaculty.Fac_Code && m.Spe_Code == aStudentFaculty.Spe_Code
						  select m;
				foreach (var cur in obj)
				{
					cur.Stu_Code = aStudentFaculty.Stu_Code;
					cur.Spe_Code = aStudentFaculty.Spe_Code;
					cur.Fac_Code = aStudentFaculty.Fac_Code;
				}
				db.SubmitChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
				throw new Exception("StudentFacultyBO.Update" + ex.ToString());
			}
		}
		//Delete 
		public bool Delete(StudentFaculty aStudentFaculty)
		{
			try
			{
				var obj = from m in db.StudentFaculties
						  where m.Stu_Code == aStudentFaculty.Stu_Code && m.Fac_Code == aStudentFaculty.Fac_Code && m.Spe_Code == aStudentFaculty.Spe_Code
						  select m;
				foreach (var cur in obj)
				{
					db.StudentFaculties.DeleteOnSubmit(cur);
				}
				db.SubmitChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
				throw new Exception("StudentFacultyBO.Delete" + ex.ToString());
			}
		}
	}

	
	
}
