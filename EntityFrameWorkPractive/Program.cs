using EntityFrameWorkPractive.Data;
using EntityFrameWorkPractive.Models;
using EntityFrameWorkPractive.Repository;
using EntityFrameWorkPractive.Services;
using System;
using System.Collections.Generic;

namespace EntityFrameWorkPractive
{
    internal class Program
    {


        static void Main(string[] args)
        {
            StudentRepository repo = new StudentRepository();

            Start:
            Console.WriteLine("1 Create Student\n2 Update Student\n3 Get a Student\n4 Get All\n5 Delete");
            string option = Console.ReadLine();

            if (option == "1")
            {

                #region Create
                repo.Create(GetInfo.GetStudentInfo());
                #endregion
                goto Start;
            }

            else if (option == "2")
            {
                #region Update
                repo.Update(GetInfo.GetInfoUpdate());
                #endregion
                goto Start;
            }
            else if (option == "3")
            {
                #region Get

                Student std = repo.GetStudent(GetInfo.GetId());
                Console.WriteLine($"{std.Id}  {std.Firstname}  {std.Lastname}   {std.Age}  {std.Email}  {std.Password}");

                #endregion
                goto Start;
            }

            else if (option == "4")
            {
                #region GetAll
                IList<Student> students = repo.GetAll();
                foreach (Student std in students)
                {
                    Console.WriteLine($"{std.Id}  {std.Firstname}  {std.Lastname}   {std.Age}  {std.Email}  {std.Password}");

                }
                #endregion
                goto Start;
            }

            else if (option == "5")
            {
                #region Delete
                repo.Delete(GetInfo.GetId());
                #endregion
                goto Start;
            }

            else
            {   Console.Clear(); 
                goto Start; }


        }
    }
}
