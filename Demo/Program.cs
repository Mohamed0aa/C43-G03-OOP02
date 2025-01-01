namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region vedio 1
            point p1;//object  of type point
            //clr will allocate 8 un intailized byts in stack

            p1 = new point();//paramter  less constructor =>[defult constructor]

            p1 = new point(1,3); //new is initailize constructor

            p1.x = 1;
            p1.y = 2;
            Console.WriteLine(p1.x);
            Console.WriteLine(p1.y);
            Console.WriteLine(p1.ToString());//=>name space +datatype
            #endregion
        }
    }
}
