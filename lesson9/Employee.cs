
namespace lesson9
{
    internal abstract class Employee
    {
        private string _fName;



        public string FName
        {
            get { return _fName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Can not be empty");
                }
                else
                {
                    _fName = value;
                }
            }
        }


        private string _lName;

        public string LName
        {
            get { return _lName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Can not be empty");
                }
                else
                {
                    _lName = value;
                }
            }
        }

        private int _sal;
        
        public int Salary
        {
            get { return _sal; }
            set
            {
                if (value >= 0)
                {
                    _sal = value;
                }
                else
                {
                    Console.WriteLine("Salary cannot be negative");
                }
            }
        }

        public virtual string ShowInfo()
        {
            return $"Name: {FName} {LName}, salary is {Salary}, bonus is {CalculateBonus()}";
        }

        public abstract string PerformDuty();

        public abstract int CalculateBonus();
    }
}
