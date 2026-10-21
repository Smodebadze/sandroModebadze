using System;
using System.Collections.Generic;
using System.Text;

namespace lesson9
{
    internal class Doctor : Employee
    {

		private string _spec;

		public string Spec
		{
			get { return _spec; }
			set {

				if (string.IsNullOrWhiteSpace(value))
				{
                    Console.WriteLine("error");
				}
                _spec = value;

            }
		}

        public string PerformDuty()
        {
            return $"{Spec}";
        }
        int patientsChecked = 12;
        int bonus = 200;


        public override int CalculateBonus()
        {
            return bonus * patientsChecked;
        }

        public override string ShowInfo()
        {
            return $"Name: {FName} {LName}, salary is {Salary} and bonus is {CalculateBonus()}";
        }

    }
}
