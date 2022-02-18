using EntityFrameWorkPractive.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkPractive.Services
{
    internal class GetInfo
    {
        public static Student GetStudentInfo()
        {
            Console.Write("Firstname : ");
            string firstname = Console.ReadLine();

            Console.Write("Lastname : ");
            string lastname = Console.ReadLine();

            Console.Write("Age : ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Email : ");
            string email = Console.ReadLine();

            Console.Write("Password : ");
            string password = Console.ReadLine();
            
            Student student = new Student()
            {
                Firstname = firstname,
                Lastname = lastname,
                Age = age,
                Email = email,
                Password = password
            };

            return student;
        }

        public static int GetId()
        {
            Console.WriteLine("Id ni kiriting");
            int id = int.Parse(Console.ReadLine());

            return id;
        }

        public static Student GetInfoUpdate()
        {
            Console.WriteLine("Yangilamoqchi bolgan studentni id sini kiriting");
            int idUpdate= int.Parse(Console.ReadLine());
            Student st = GetStudentInfo();

            st.Id = idUpdate;

            return st;
        }
    }
}
