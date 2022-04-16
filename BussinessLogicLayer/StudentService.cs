using BussinessLogicLayer.BEnt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DataAccessLayer.Data;
using DataAccessLayer;

namespace BussinessLogicLayer
{
    public class StudentService
    {
        public static List<StudentModel>Get()
        {
            /*   var confiq = new MapperConfiguration(c => { 
                   c.CreateMap<Student,StudentModel>();
               });
               var mapper = new Mapper(confiq);
               var data = mapper.Map<List<StudentModel>>(StudentRepo.Get());
               return data;*/

            var data = StudentRepo.Get();
            List<StudentModel> li = new List<StudentModel>();   

            foreach (var item in data)
            {
                StudentModel st = new StudentModel();
                st.Id = item.Id;
                st.Name = item.Name;
                st.Email = item.Email;
                st.Gender   =   item.Gender;
                li.Add(st);
            }
            return li;
        }
        public static List<String>GetNames()
        {
            var data = StudentRepo.Get().Select(x => x.Name).ToList();
            return data;
        }

        public static void Edit(StudentModel sm)
        {
            Student st = new Student();
            st.Id=sm.Id;
            st.Name = sm.Name;
            st.Email = sm.Email;
            st.Gender=sm.Gender;
            StudentRepo.Edit(st);
        }

    }
}
