using System;
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
    internal class TeacherService : IService,ITeacherService
    {
        Teacher[] teachers = { };
        public void Create()
        {

            Teacher teacher = new Teacher();

            Array.Resize(ref teachers, teachers.Length + 1);


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
            teacher.Name = name;
            teacher.Surname = surname;
            teacher.GroupNo = groupNo;
            teachers[teachers.Length - 1] = teacher;
        }

        

        public void Delete()
        {
            Console.WriteLine("Enter Id");
            int Id=int.Parse(Console.ReadLine());   
            for(int i=0;i<teachers.Length;i++)
            {

                if(Id == teachers[i].Id)
                {
                    int index=Array.IndexOf(teachers,teachers[i]);
                    teachers = ArrayRemove(ref teachers, teachers.Length - 1, index);
                }
                else if (i == teachers.Length - 1)
                {
                    Console.WriteLine("There is no teacher in this id");
                }
            }
            if (teachers.Length == 0)
            {
                Console.WriteLine("Empty");
            }
        }
        


      
        public void GetById()
        {

            Console.WriteLine("Enter Id:");
            int Id=int.Parse(Console.ReadLine());

            for (int i = 0; i < teachers.Length; i++)
            {
               
                if (teachers[i].Id == Id)
                {
                    Console.WriteLine(teachers[i]);
                    break;
                }
                else if (i == teachers.Length - 1)
                {
                    Console.WriteLine("There is no teacher in this id");
                }
            }
            if(teachers.Length == 0)
            {
                Console.WriteLine("Empty");
            }
        }

        public void Show()
        {
            foreach (Teacher teacher in teachers)
            {
                if (teacher != null)
                {
                    Console.WriteLine(teacher.ToString());
                }
            }
            if (teachers.Length == 0)
            {
                Console.WriteLine("Now,there is no teacher");
            }
        }

        public void Update()
        {

            Console.WriteLine("Enter Id");
            int Id = int.Parse(Console.ReadLine());

            for (int i = 0; i < teachers.Length; i++)
            {

                if (Id == teachers[i].Id)
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
                    teachers[i].Name = name;
                    teachers[i].Surname = surname;
                    teachers[i].GroupNo = groupNo;

                }
                else if (i == teachers.Length - 1)
                {
                    Console.WriteLine("There is no teacher in this id");
                }
            }
            if (teachers.Length == 0)
            {
                Console.WriteLine("Empty");
            }
        }
        

        Teacher[] ArrayRemove(ref Teacher[] array,int newSize,int index)
        {
            Teacher[] newArray = new Teacher[newSize];
            int i2 = 0;
            for(int i = 0; i < array.Length; i++)
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
