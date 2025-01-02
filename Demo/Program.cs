namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region vedio 1
            //point p1;//object  of type point
            //         ////clr will allocate 8 un intailized byts in stack

            ////p1 = new point();//paramter  less constructor =>[defult constructor]

            ////p1 = new point(1,3); //new is initailize constructor

            ////p1.x = 1;
            ////p1.y = 2;
            ////Console.WriteLine(p1.x);
            ////Console.WriteLine(p1.y);
            ////Console.WriteLine(p1.ToString());//=>name space +datatype
            #endregion

            #region vedio 4
            // Employee employee = new Employee(id: 1, name: "mo", age:21);
            // Console.WriteLine(employee);
            //  employee.setid(3);
            // Console.WriteLine(employee.getid());
            #endregion

            #region vedio 5


            PhoneBook note = new PhoneBook(10);
            note.AddPerson(0, 11111, "moali");
            note.AddPerson(1, 22222, "moali2");
            note.AddPerson(2, 33333, "moali3");
            //note.set
            //Console.WriteLine(note["moali"]);
            for (int i = 0; i < note.Size; i++)
            {
                Console.WriteLine(note[i]);
            }
            #endregion
        }
    }
}
