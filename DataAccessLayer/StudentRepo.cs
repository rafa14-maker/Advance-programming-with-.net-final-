using DataAccessLayer.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class StudentRepo
    {
        public static List<Student>Get()
        {
            Entities db = new Entities();
            return db.Students.ToList();
        }

        public static Student Get(int id)
        {
            Entities db = new Entities();
            return db.Students.FirstOrDefault(s => s.Id == id);
        }

        public static void Edit(Student s)
        {
            Entities db = new Entities();
            var ds = (from e in db.Students where e.Id == s.Id select e).FirstOrDefault();
            db.Entry(ds).CurrentValues.SetValues(s);
            db.SaveChanges();
        }

        public static void Delete(int id)
        {
            Entities db = new Entities();
            var ds = db.Students.FirstOrDefault(e => e.Id == id);
            db.Students.Remove(ds);
            db.SaveChanges() ;
        }
    }
}
