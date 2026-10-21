
using System;

namespace lesson9
{
    internal class Receptionist : Employee
    {
        private string _reg;

        public string Reg
        {
            get { return _reg; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("error");
                }
                else
                {
                    _reg = value;
                }
            }
        }

        int patientsRegistered = 43;
        int bonus = 15;

        public override string PerformDuty()
        {
            return $"{Reg}: registering patients";
        }

        public override int CalculateBonus()
        {
            return bonus * patientsRegistered;
        }

        public override string ShowInfo()
        {
            return $"Name: {FName} {LName}, salary is {Salary} and bonus is {CalculateBonus()}";
        }
    }
}
