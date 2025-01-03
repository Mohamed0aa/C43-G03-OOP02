namespace assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1 : Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
            //Person[] persons = new Person[3];
            //persons[0]=new Person();
            //persons[0].name = "mohamed";
            //persons[0].age = 21;
            //persons[1]=new Person();
            //persons[1].name = "ahmed";
            //persons[1].age = 19;
            //persons[2] = new Person();
            //persons[2].name = "mahmoud";
            //persons[2].age = 18;
            //for (int i = 0; i < persons.Length; i++)
            //{
            //    Console.WriteLine($"{i+1}:");
            //    Console.WriteLine($"{persons[i]}");
            //}
            #endregion

            #region q2 : Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
            //Point p1 = new Point();
            //p1.x=int.Parse(Console.ReadLine());
            //p1.y = int.Parse(Console.ReadLine());
            //Point p2 = new Point();
            //p2.x = int.Parse(Console.ReadLine());
            //p2.y = int.Parse(Console.ReadLine());

            //Console.WriteLine(Math.Sqrt((Math.Pow(p2.x - p1.x, 2)+ Math.Pow(p2.y - p1.y, 2))));


            #endregion

            #region q3 :Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
            //Person[] persons = new Person[3];

            //for(int i=0;i<persons.Length;i++)
            //{
            //    persons[i].name = Console.ReadLine();
            //    persons[i].age=int.Parse(Console.ReadLine());
            //}
            //int mx = 0,mxIn=0;
            //for (int i = 0; i < persons.Length; i++)
            //{
            //    if (persons[i].age>=mx)
            //    {
            //        mx = persons[i].age;
            //        mxIn = i;
            //    }
            //}
            //Console.WriteLine($"OLDEST_PERSON IS {persons[mxIn].name}");
            #endregion

            #region q4 : Design and implement a Class for the employees in a company:
            //employee em1 = new employee();
            //em1.ID = 1;
            //em1.salary = 5000;
            //em1.gender = 't';//=> [R]
            //em1.security_level = 0;
            //em1.Name = "Test";
            //em1.Hire_date =DateTime.Now;
            //Console.WriteLine(em1);
            #endregion

            #region q5: Develop a Class to represent the Hiring Date Data:
            //Date date = new Date(2003,11,1);
            //Console.WriteLine(date);
            #endregion

            #region q6 : Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)
            //employee[] Emp = new employee[3];
            //Emp[0] = new employee(1, "DBA Employee", Security_level.DBA, 100000, DateTime.Now, 'M');
            //Emp[1] = new employee(1, "DBA Employee", Security_level.guest, 100000, DateTime.Now, 'M');
            //Emp[2] = new employee(1, "DBA Employee", Security_level.secretary, 100000, DateTime.Now, 'M');

            //for (int i = 0; i < Emp.Length; i++)
            //{
            //    Console.WriteLine(Emp[i]);
            //}
            #endregion

            #region q7 :  
            //employee[] Emp = new employee[3];
            //Emp[0] = new employee(1, "DBA Employee", Security_level.DBA, 100000, new DateTime(2003, 11, 11), 'M');
            //Emp[1] = new employee(1, "DBA Employee", Security_level.guest, 100000, new DateTime(2003, 11, 2), 'M');
            //Emp[2] = new employee(1, "DBA Employee", Security_level.secretary, 100000, new DateTime(2003, 1, 3), 'M');

            //for (int i = 0; i < Emp.Length - 1; i++)
            //{
            //    for (int j = 0; j < Emp.Length - i - 1; j++)
            //    {
            //        if (Emp[j].Hire_date > Emp[j + 1].Hire_date)
            //        {
            //            employee temp = Emp[j];
            //            Emp[j] = Emp[j + 1];
            //            Emp[j + 1] = temp;
            //        }

            //    }
            //}

            //for (int i = 0; i < Emp.Length; i++)
            //{
            //    Console.WriteLine(Emp[i]);
            //}
            //0 boxing  0 unboxing 
            #endregion
        }
    }
}
