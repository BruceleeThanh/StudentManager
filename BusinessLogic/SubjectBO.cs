﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace BusinessLogic {
    public partial class SubjectBO {
        private DbDataContext db = new DbDataContext();

        // Select all Subject
        public List<Subject> Select_All () {
            try {
                return db.Subjects.OrderByDescending(b => b.Sub_Code).ToList<Subject>();
            }
            catch (Exception ex) {
                throw new Exception("SubjectBO.Select_All:" + ex.ToString());
            }
        }

        // Select all Subject by ID
        public List<Subject> Select_ById (string Id) {
            try {
                return db.Subjects.Where(b => b.Sub_Code == Id).ToList<Subject>();
            }
            catch (Exception ex) {
                throw new Exception("SubjectBO.Select_ById" + ex.ToString());
            }
        }

        // Select all Subject by Name
        public List<Subject> Select_ByName (string Name) {
            try {
                return db.Subjects.Where(b => b.Sub_Name == Name).ToList<Subject>();
            }
            catch (Exception ex) {
                throw new Exception("SubjectBO.Select_ByName" + ex.ToString());
            }
        }

        // Select all Subject by Type
        public List<Subject> Select_ByType (bool Type) {
            try {
                return db.Subjects.Where(b => b.Sub_Type == Type).ToList<Subject>();
            }
            catch (Exception ex) {
                throw new Exception("SubjectBO.Select_ByType" + ex.ToString());
            }
        }

        // Select all Subject by Faculty
        public List<Subject> Select_ByFaculty (int FacultyCode) {
            try {
                return db.Subjects.Where(b => b.Sub_FacultyCode == FacultyCode).ToList<Subject>();
            }
            catch (Exception ex) {
                throw new Exception("SubjectBO.Select_ByFaculty" + ex.ToString());
            }
        }

        // Select all Subject by Specialization
        public List<Subject> Select_BySpecialization (int Specialization) {
            try {
                return db.Subjects.Where(b => b.Sub_SpecializationCode == Specialization).ToList<Subject>();
            }
            catch (Exception ex) {
                throw new Exception("SubjectBO.Select_BySpecialization" + ex.ToString());
            }
        }

        // Insert new Subject
        public bool Insert (Subject aSubject) {
            try {
                db.Subjects.InsertOnSubmit(aSubject);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) {
                return false;
                throw new Exception("SubjectBO.Insert" + ex.ToString());
            }
        }

        // Update Subject
        public bool Update (Subject aSubject) {
            try {
                var editObj = db.Subjects.Where(b => b.Sub_Code == aSubject.Sub_Code).ToList<Subject>();
                foreach (Subject temp in editObj) {
                    temp.Sub_Code = aSubject.Sub_Code;
                    temp.Sub_Name = aSubject.Sub_Name;
                    temp.Sub_Credits = aSubject.Sub_Credits;
                    temp.Sub_Type = aSubject.Sub_Type;
                    temp.Sub_FacultyCode = aSubject.Sub_FacultyCode;
                    temp.Sub_SpecializationCode = aSubject.Sub_SpecializationCode;
                    temp.Sub_Coefficient = aSubject.Sub_Coefficient;
                }
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) {
                return false;
                throw new Exception("SubjectBO.Update" + ex.ToString());
            }
        }

        // Delete Subject
        public bool Delete (string Id) {
            try {
                var DeleteObj = db.Subjects.Where(b => b.Sub_Code == Id).ToList<Subject>();
                db.Subjects.DeleteAllOnSubmit(DeleteObj);
                db.SubmitChanges();
                return true;
            }
            catch (Exception ex) {
                return false;
                throw new Exception("SubjectBO.Delete" + ex.ToString());
            }
        }
    }
}
