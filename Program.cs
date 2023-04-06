using System;


namespace ABSTRACION
{
    //absraction
    class Employee
    {
        public int EmpId;
        public string EmpName;
        public double GrossPay;
        double Tax = .1;
        double Netsalary;

        public Employee(int Eid, string Ename, double EGrossPay)
        {
            this.EmpId = Eid;
            this.EmpName = Ename;
            this.GrossPay = EGrossPay;

        }
        void CalculateSalary()
        {
            if (GrossPay > 30000)
            {
                Netsalary = (GrossPay - Tax * (GrossPay));
                Console.WriteLine("Your salary is : {0}", Netsalary);
            }
            else
            {
                Console.WriteLine("your salary is :{0}", Netsalary);
            }
        }

        public void ShowEmployeeDetails()
        {
            Console.WriteLine("Employee id is :{0} ",this.EmpId);
            Console.WriteLine("Employee Name is :{0} ", this.EmpName);

            this.CalculateSalary();
        }

    }

    //abstraction
    abstract class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string _PhNo;

        public static string InstituteName = "ABC";    //constant

        //properties
        public string PhoneNumber
        {
            set
            {
                this._PhNo = value;
            }
            get
            {
                return this._PhNo;
            }
        }
        //abstract method
        public abstract void PrintDetails();

        public abstract string PName { get; set;}


    }

    class Student : Person
    {
        public int RollNo;
        public int Fees;

        //body of abstract class
        public override void PrintDetails()
        {
            string name = this.FirstName + " " + this.LastName;
            Console.WriteLine("Student name is : {0} ",name);
            Console.WriteLine("Student age is : {0} ", this.Age);
            Console.WriteLine("Student MobileNumber is : {0} ",PhoneNumber);
            Console.WriteLine("Student RollNO is : {0} ", this.RollNo);
            Console.WriteLine("Student Fess is : {0} ", this.Fees);
            Console.WriteLine("Student InstituteName is : {0} ", InstituteName);
        }
        string PrincipalName;
        public override string PName {
            
            set
            { 
                this.PrincipalName=value;
            }
            get
            {
                return PrincipalName;
            } 
        }
    }

    class Teacher : Person
    {
        public string Qualification;
        public int Salary;

        //body of abstract class 
        public override void PrintDetails()
        {
            string name = this.FirstName + " " + this.LastName;
            Console.WriteLine("Teacher name is : {0} ", name);
            Console.WriteLine("Teacher age is : {0} ", this.Age);
            Console.WriteLine("Teacher MobileNumber is : {0} ", PhoneNumber);
            Console.WriteLine("Teacher Qualifications is : {0} ", this.Qualification);
            Console.WriteLine("Teacher Salaryt is : {0} ", this.Salary);
            Console.WriteLine("Teacher InstituteName is : {0} ", InstituteName);
            
        }
        string PrincipalName;
        public override string PName
        {

            set { this.PrincipalName = value; }
            get
            {
                return PrincipalName;
            }
        }
    }


    class Program
    {
       static void Main(string[] args)
        {
            Employee kvi = new Employee(33,"kavita jangir",40000);
            kvi.ShowEmployeeDetails();

            Console.WriteLine("_____________");
            //object of abstact child Class
            Student S1 = new Student();
            S1.FirstName = "Soniya";
            S1.LastName = "Saini";
            S1.Age = 26;
            S1.PhoneNumber = "46738678367";   //accessing through properties
            S1.RollNo = 50;
            S1.Fees = 5000;
            S1.PrintDetails();
            S1.PName = "XYZ";
            Console.WriteLine("Principal name:{0}",S1.PName);
            Console.WriteLine("_____________");

            Teacher T1 = new Teacher();
            T1.FirstName = "Soniya";
            T1.LastName = "Saini";
            T1.Age = 26;
            T1.PhoneNumber = "46789645678"; //accessing through properties
            T1.Qualification = "MSc";
            T1.Salary = 50000;
            S1.PrintDetails();
            T1.PName = "XYZ";
            Console.WriteLine("Principal name: {0}",T1.PName);
            //Console.ReadLine();

            //Assingment

            string test = "Hello";
            int i, j;
            for (i = 0; i < test.Length; i++)
            {
                for (j = i; j < test.Length; j++)
                {
                    Console.Write(test.Substring(i, (j - i) + 1) + " ");

                }
                Console.WriteLine();
            }
        }
    }
}