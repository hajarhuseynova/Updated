﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task14Mart.Interfaces;
using Task14Mart.Core.Models;
using Task14Mart.Core.Models.Base;
using Task14Mart.Extensions;



namespace Task14Mart.Services
{
    internal class StudentService : IService, IStudentService
    {
        Student[] students = { };
        public void Create()
        {

            Student student = new Student();

            Array.Resize(ref students, students.Length + 1);
         

            Console.WriteLine("Name:");
            string name = Console.ReadLine();

            Console.WriteLine("SurName:");
            string surname = Console.ReadLine();

            Console.WriteLine("GroupNo:");
            string groupNo = Console.ReadLine();


            while (!name.CheckAll() || !surname.CheckAll() || string.IsNullOrEmpty(groupNo)) {

                Console.WriteLine("It has wrong,Again.");
                Console.WriteLine("Name:");
                name = Console.ReadLine();

                Console.WriteLine("SurName:");
                surname = Console.ReadLine();

                Console.WriteLine("GroupNo:");
                groupNo = Console.ReadLine();
            }
            student.Name = name;
            student.Surname = surname;
            student.GroupNo = groupNo;
            students[students.Length - 1] = student;

        }
        
        public void Delete()
        {
            Console.WriteLine("Enter Id");
            int Id = int.Parse(Console.ReadLine());
            
           for(int i = 0; i < students.Length; i++) 
            {

                if (Id == students[i].Id)
                {
                    int index = Array.IndexOf(students, students[i]);
                    students = ArrayRemove(ref students, students.Length - 1, index);
                }
                else if (i == students.Length - 1)
                {
                    Console.WriteLine("There is no student in this id");
                }
            }
            if (students.Length == 0)
            {
                Console.WriteLine("Empty");
            }


        }


        public void GetById()
        {
            Console.WriteLine("Enter Id:");
            int Id=int.Parse(Console.ReadLine());
          
            for (int i = 0; i < students.Length; i++)
            {


                if (students[i].Id == Id)
                {
                    Console.WriteLine(students[i]);
                    break;
                }
                else if (i == students.Length - 1)
                {
                    Console.WriteLine("There is no student in this id");
                }
            }
            if (students.Length == 0)
            {
                Console.WriteLine("Empty");
            }

        }

        public void Show()
        {
            foreach(Student student in students)
            { 
                if (student != null)
                {
                    Console.WriteLine(student.ToString());
                }
            }
            if (students.Length == 0)
            {
                Console.WriteLine("Now,there is no student");
            }
        }

        public void Update()
        {
            Console.WriteLine("Enter Id");
            int Id = int.Parse(Console.ReadLine());

            for (int i = 0; i < students.Length; i++)
            {

                if (Id == students[i].Id)
                {

                    Console.WriteLine("Name:");
                    string name = Console.ReadLine();

                    Console.WriteLine("SurName:");
                    string surname = Console.ReadLine();

                    Console.WriteLine("GroupNo:");
                    string groupNo = Console.ReadLine();


                    while (!name.CheckAll() || !surname.CheckAll() || string.IsNullOrEmpty(groupNo))
                    {

                        Console.WriteLine("It has wrong,Again.");
                        Console.WriteLine("Name:");
                        name = Console.ReadLine();

                        Console.WriteLine("SurName:");
                        surname = Console.ReadLine();

                        Console.WriteLine("GroupNo:");
                        groupNo = Console.ReadLine();
                    }
                    students[i].Name = name;
                    students[i].Surname = surname;
                    students[i].GroupNo = groupNo;

                }
                else if (i == students.Length - 1)
                {
                    Console.WriteLine("There is no student in this id");
                }
            }
            if (students.Length == 0)
            {
                Console.WriteLine("Empty");
            }

        }


        Student[] ArrayRemove(ref Student[] array, int newSize, int index)
        {
            Student[] newArray = new Student[newSize];
            int i2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == index)
                {
                    continue;
                }
                else
                {
                    newArray[i2] = array[i];
                    i2++;
                }
            }
            return newArray;
        }


    }
}
