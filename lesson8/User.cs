
using System;

namespace lesson8
{
    internal class User
    {
        private string _Fname;

        public string Fname
        {
            get { return _Fname; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("cannot be empty");
                }
                else
                {
                    _Fname = value;
                }
            }
        }

        private string _Lname;

        public string Lname
        {
            get { return _Lname; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("cannot be empty");
                }
                else
                {
                    _Lname = value;
                }
            }
        }

        private int _Age;

        public int Age
        {
            get { return _Age; }
            set
            {
                if (value < 18 || value > 120)
                {
                    Console.WriteLine("Invalid age");
                }
                else
                {
                    _Age = value;
                }
            }
        }

        private int _Id;

        public int Id
        {
            get { return _Id; }
            set
            {
                if (value < 1 || value > 100)
                {
                    Console.WriteLine("ID must be between 1 and 100");
                }
                else
                {
                    _Id = value;
                }
            }
        }

        private int _Grade;

        public int Grade
        {
            get { return _Grade; }
            set
            {
                if (value < 1 || value > 12)
                {
                    Console.WriteLine("Grade must be between 1 and 12");
                }
                else
                {
                    _Grade = value;
                }
            }
        }

        private double _GPA;

        public double GPA
        {
            get { return _GPA; }
            set
            {
                if (value < 0 || value > 4)
                {
                    Console.WriteLine("GPA must be between 0 and 4");
                }
                else
                {
                    _GPA = value;
                }
            }
        }

        private int _Attendance;

        public int Attendance
        {
            get { return _Attendance; }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Attendance must be between 0 and 100");
                }
                else
                {
                    _Attendance = value;
                }
            }
        }

        private string _Nationality;

        public string Nationality
        {
            get { return _Nationality; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Nationality cannot be empty");
                }
                else
                {
                    _Nationality = value;
                }
            }
        }

        private string _Job;

        public string Job
        {
            get { return _Job; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Job cannot be empty");
                }
                else
                {
                    _Job = value;
                }
            }
        }

        private string _City;

        public string City
        {
            get { return _City; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("City cannot be empty");
                }
                else
                {
                    _City = value;
                }
            }
        }
    }
}
