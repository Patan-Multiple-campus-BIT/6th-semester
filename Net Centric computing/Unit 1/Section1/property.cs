using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section1
{
    public class Employee
    {
        int Eno;
        double salary;
        string Ename, Job, Dname, Location;
        public Employee(int Eno,string Ename,string Job,double Salary,string Dname,string Location)
        {
            this.Eno = Eno;
            this.salary = Salary; this.Ename = Ename;
            this.Job = Job;this.Dname = Dname;this.Location = Location;
        }
        public object this[int i]
        {
            get
            {
                if (i == 1)
                    return Eno;
                else if (i == 2)
                    return Ename;
                else if (i == 3)
                    return Job;
                else if (i == 4)
                    return salary;
                else if (i == 5)
                    return Dname;
                else if (i == 6)
                    return Location;
                else
                    return null;
            }
            set
            {
                if (i == 1)
                    Eno = (int)value;
                else if (i == 2)
                    Ename = (string)value;
                else if (i == 3)
                    Job = (string)value;
                else if (i == 4)
                    salary = (double)value;
                else if (i == 5)
                    Dname = (string)value;
                else if (i == 6)
                    Location = (string)value;
            }
        }
    }
    public class TestEmployee
    {
        static void Main(string[] args)
        {
            Employee Emp = new Employee(1001, "Scoot", "Manager", 20000.00, "sales", "Mumbai");
            Emp[1] = 1001;
            Emp[2] = "Keshab Aryal";
            Emp[3] = "Director";

            Console.ReadKey();
        }
    }
}