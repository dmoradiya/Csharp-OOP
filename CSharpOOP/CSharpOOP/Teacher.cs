using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
    class Teacher : Person
    {
        // When teachers sleep, energy level goes up by 25, stress goes down by 20.

        public List<Student> Class { get; set; }

        public Classroom Room { get; set; }

        public void AssignHomework()
        {
            foreach (Student student in Class)
            {
                student.DoHomework();
            }
        }

        public override void Sleep()
        {
            EnergyLevel += 25;
            StressLevel -= 20;
        }

        public Teacher(string firstName, string lastName, Classroom room)
        {
            FirstName = firstName;
            LastName = lastName;

            Class = new List<Student>();
            Room = room;
        }
    }
}