using System;
using System.Collections.Generic;

namespace CSharpOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Student theStudent = new Student("Test", "McTest");
            Classroom theRoom = new Classroom(101);

            Teacher theTeacher = new Teacher("Teacher", "McTest", theRoom);

           

            //theRoom.RoomNumber
            //theTeacher.Room.RoomNumber
            theStudent.DoHomework();
            Console.WriteLine(theStudent);
            theStudent.DoHomework();
            Console.WriteLine(theStudent);
            theStudent.Eat();
            Console.WriteLine(theStudent);



        }


    }
}
