using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpOOP
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private int _energyLevel;
        public int EnergyLevel
        {
            get
            {
                return _energyLevel;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Insufficient energy to perform that action.");
                }
                _energyLevel = value;
            }
        }
        private int _stressLevel;
        public int StressLevel
        {
            get
            {
                return _stressLevel;
            }
            set
            {
                if (value > 100)
                {
                    throw new Exception("Too much stress to perform that action.");
                }
                _stressLevel = value;
            }
        }

        public void DoHomework()
        {
            EnergyLevel -= 20;
            StressLevel += 25;
        }

        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            EnergyLevel = 100;
            StressLevel = 0;
        }
    }
}