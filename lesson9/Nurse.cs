
using System;

namespace lesson9
{
    internal class Nurse : Employee
    {
        private string _dep;

        public string Dep
        {
            get { return _dep; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("error");
                }
                else
                {
                    _dep = value;
                }
            }
        }

        int shiftsDone = 3;
        int bonus = 500;

        public override string PerformDuty()
        {
            return $"{Dep}: helping patients";
        }

        public override int CalculateBonus()
        {
            return bonus * shiftsDone;
        }

        public override string ShowInfo()
        {
            return $"Name: {FName} {LName}, salary is {Salary} and bonus is {CalculateBonus()}";
        }
    }
}
