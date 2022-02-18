using EntityFrameWorkPractive.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkPractive.IRepository
{
    internal interface IStudentRepository
    {
        void Create(Student student);

        void Update(Student student);

        void Delete(int id);

        Student GetStudent(int id);

        IList<Student> GetAll();
    }

}
