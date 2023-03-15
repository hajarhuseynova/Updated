﻿using Task14Mart.Services;
StudentService studentService=new StudentService();
TeacherService teacherService=new TeacherService();

Console.WriteLine("0-left");
Console.WriteLine("1-Create student");
Console.WriteLine("2-Create teacher");

Console.WriteLine("3-Delete Student");
Console.WriteLine("4-Delete Teacher");
Console.WriteLine("5-Show Student");

Console.WriteLine("6-Show Teacher");
Console.WriteLine("7-GetById Student");
Console.WriteLine("8-GetById Teacher");
Console.WriteLine("9-Update Student");
Console.WriteLine("10-Update Teacher");
string request = Console.ReadLine();


while (request!="0")
{
    switch (request)
    {
        case "1":studentService.Create();
            break;
        case "2":teacherService.Create();
            break;
        case"3":studentService.Delete();
            break;
        case"4": teacherService.Delete();
            break;
        case "5":studentService.Show();
            break;
        case "6":teacherService.Show();
            break;
        case "7":studentService.GetById();
            break;
        case "8":teacherService.GetById();
            break;
        case "9":
            studentService.Update();
            break;
        case "10":
            teacherService.Update();
            break;
        default:
            Console.WriteLine("You write only 0,1,2,3,4,5,6,7,8,9,10");
            break;
    }

    Console.WriteLine("0-left");
    Console.WriteLine("1-Create student");
    Console.WriteLine("2-Create teacher");

    Console.WriteLine("3-Delete Student");
    Console.WriteLine("4-Delete Teacher");
    Console.WriteLine("5-Show Student");

    Console.WriteLine("6-Show Teacher");
    Console.WriteLine("7-GetById Student");
    Console.WriteLine("8-GetById Teacher");
    Console.WriteLine("9-Update Student");
    Console.WriteLine("10-Update Teacher");

    request = Console.ReadLine();

}