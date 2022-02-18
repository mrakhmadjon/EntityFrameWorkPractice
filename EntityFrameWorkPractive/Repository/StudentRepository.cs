using EntityFrameWorkPractive.Data;
using EntityFrameWorkPractive.IRepository;
using EntityFrameWorkPractive.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkPractive.Repository
{
    internal class StudentRepository : IStudentRepository
    {
        readonly StudentsDbContext  studentDb = new();

        public void Create(Student student)
        {
            try
            {
                studentDb.Students.Add(student);
                studentDb.SaveChanges();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
          

        }

        public void Delete(int _id)
        {
            try
            {
                var delSt = studentDb.Students.FirstOrDefault(p => p.Id == _id);
                studentDb.Remove(delSt);
                studentDb.SaveChanges();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            
        }

        public IList<Student> GetAll()
        {
            try
            {
                return studentDb.Students.ToList();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public Student GetStudent(int id)
        {
            try
            {
                return studentDb.Students.FirstOrDefault(p => p.Id == id);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Student student)
        {
            try
            {
                var st = studentDb.Students.FirstOrDefault(p => p.Id == student.Id);
                st.Firstname = student.Firstname;
                st.Lastname = student.Lastname;
                st.Age = student.Age;
                st.Email = student.Email;
                st.Password = student.Password;

                studentDb.SaveChanges();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
           


        }
    }
}
