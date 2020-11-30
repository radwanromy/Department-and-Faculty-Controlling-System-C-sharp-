using System;

namespace Department_Faculty
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Department d = new Department("CSE", "001");
            Faculty f = new Faculty("HH", "121");
            Faculty f2 = new Faculty("HHsd", "122");
            Faculty f3 = new Faculty("HHdrfg", "123");
            Faculty f4 = new Faculty("HHssdrfd", "124");
            d.AddFaculty(f, f2,f3,f4);
            d.ShowAllFaculty();
         //   d.RemoveFaculty(f2);
          //  d.SearchFaculty("123");

            Console.WriteLine();
            d.ShowAllFaculty();

        }
    }
}
