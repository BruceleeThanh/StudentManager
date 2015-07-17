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

        // Insert new
    }
}
