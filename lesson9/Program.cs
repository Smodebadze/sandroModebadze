namespace lesson9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor doc = new();
            doc.FName = "Greg";
            doc.LName = "House";
            doc.Salary = 30000;
            doc.Spec = "flawless When it comes to Diagnosis";



            Nurse nurse = new();
            nurse.FName = "Allison";
            nurse.LName = "Cameron";
            nurse.Salary = 15000;
            nurse.Dep = "Great with people";


            Receptionist rec = new();
            rec.FName = "Jordan";
            rec.LName = "Chase";
            rec.Salary = 10000;
            rec.Reg = "Fast typer";

        }
    }
}
