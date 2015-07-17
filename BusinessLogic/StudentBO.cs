using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic {
    public partial class StudentBO {

        private DbDataContext db = new DbDataContext();
        
        // Select all Student from DB 
        public List<Student> Select_All () {
            try {
                return db.Students.OrderByDescending(b => b.Stu_Code).ToList<Student>();
            }
            catch (Exception ex){
                throw new Exception("StudentBO.Select_All:" + ex.ToString());
            }
        }

        // Select all Student by Student Code
        public List<Student> Select_ById (string id) {
            try {
                return db.Students.Where(b => b.Stu_Code == id).ToList<Student>();
            }
            catch (Exception ex){
                throw new Exception("StudentBO.Select_ById:" + ex.ToString());
            }
        }

        // Select all Student by Student Name
        public List<Student> Select_ByName (string Name) {
            try {
                return db.Students.Where(b => b.Stu_Name == Name).ToList<Student>();
            }
            catch (Exception ex){
                throw new Exception("StudentBO.Select_ByName:" + ex.ToString());
            }
        }

        // Select all Student by Religion
        public List<Student> Select_ByReligion (string Religion) {
            try {
                return db.Students.Where(b => b.Stu_Religion == Religion).ToList<Student>();
            }
            catch (Exception ex){
                throw new Exception("StudentBO.Select_ByReligion:" + ex.ToString());
            }
        }

        // Select all Student by Ethnic
        public List<Student> Select_ByEthnic (string Ethnic) {
            try {
                return db.Students.Where(b => b.Stu_Ethnic == Ethnic).ToList<Student>();
            }
            catch (Exception ex) {
                throw new Exception("StudentBO.Select_ByEthnic:" + ex.ToString());
            }
        }

        // Insert new Student
        public bool Insert (Student aStudent) {
            try {
                db.Students.InsertOnSubmit(aStudent);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) {
                return false;
                throw new Exception("StudentBO.Insert:" + ex.ToString());
            }
        }

        // Update Student
        public bool Update (Student aStudent) {
            try {
                var editObj = db.Students.Where(b => b.Stu_Code == aStudent.Stu_Code).ToList<Student>();
                foreach (Student temp in editObj) {
                    temp.Stu_Name = aStudent.Stu_Name;
                    temp.Stu_DateOfBirth = aStudent.Stu_DateOfBirth;
                    temp.Stu_HomeTown = aStudent.Stu_HomeTown;
                    temp.Stu_Address = aStudent.Stu_Address;
                    temp.Stu_PhoneNumber = aStudent.Stu_PhoneNumber;
                    temp.Stu_Religion = aStudent.Stu_Religion;
                    temp.Stu_Ethnic = aStudent.Stu_Ethnic;
                }
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) {
                return false;
                throw new Exception("StudentBO.Update:" + ex.ToString());
            }
        }

        // Delete Student
        public bool Delete (string Id) {
            try {
                var deleteObj = db.Students.Where(b => b.Stu_Code == Id).ToList<Student>();
                db.Students.DeleteAllOnSubmit(deleteObj);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) {
                return false;
                throw new Exception("StudentBO.Delete:" + ex.ToString());
            }
        }
    }
}
