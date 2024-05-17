using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace section4
{
    public class Employee
    {
        int Eno;
        double Salary;
        string Ename, Job, Dname, Location;
        public Employee(int eno, string enmae, string job, double salary, string dname, string location)
        {
            Eno = eno;
            Salary = salary;
            Ename = enmae;
            Job = job;
            Dname = dname;
            Location = location;
        }
        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return this.Eno;
                else if (index == 1)
                    return this.Ename;
                else if (index == 2)
                    return this.Job;
                else if (index == 3)
                    return this.Salary;
                else if (index == 4)
                    return this.Dname;
                else if (index == 5)
                    return this.Location;
                else
                    return null;
            }
            set
            {
                    if (index == 0)
                        this.Eno = Convert.ToInt32(value);
                    else if (index == 1)
                        this.Ename =(string)value;
                    else if (index == 2)
                        this.Job = (string)value;
                    else if (index == 3)
                        this.Salary = (double)value;
                    else if (index == 4)
                        this.Dname = (string)value;
                    else if (index == 5)
                        this.Location = (string)value;
            }
        }
        public object this[string index]
        {
            get
            {
                if (index.ToUpper() == "ENO")
                    return this.Eno;
                else if (index.ToUpper() == "ENAME")
                    return this.Ename;
                else if (index.ToUpper() == "JOB")
                    return this.Job;
                else if (index.ToUpper() == "SALARY" )
                    return this.Salary;
                else if (index.ToUpper() == "DNAME")
                    return this.Dname;
                else if (index.ToUpper() == "LOCATION")
                    return this.Location;
                else
                    return null;
            }
            set
            {
                if (index.ToUpper() == "ENO")
                    this.Eno = (int)value;
                else if (index.ToUpper() == "ENAME")
                    this.Ename = (string)value;
                else if (index.ToUpper() == "JOB")
                    this.Job = (string)value;
                else if (index.ToUpper() == "SALARY")
                    this.Salary = (double)value;
                else if (index.ToUpper() == "DNAME")
                    this.Dname = (string)value;
                else if (index.ToUpper() == "LOCATION")
                    this.Location = (string)value;
            }
        }
    }
}
