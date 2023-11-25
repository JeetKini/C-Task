using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorld
{

    
    internal class Program
    {
     
        
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World");
            decimal d = 5.6m;
            double dd = 55.5;
            float f = 90.9f;

            //Type Conversion
            byte b = 5;
            int i = b;
            Console.WriteLine( i);

            int j = 100;
            byte k = (byte)j;
            Console.WriteLine( k);

            //operators
            int o = 5;
            int so = ++o;
            Console.WriteLine(so);

            Console.WriteLine(o);

            //   String s = "12";
            //  int a = Convert.ToInt32(s);
            //  int i = int.Parse(s);
            //  Console.WriteLine(i);

            Person   class1 = new Person(); 
            class1.FirstName = "Jeet";
            class1.LastName="Kini";
            class1.Introduce();

            Calculator calculator=new Calculator();
            Console.WriteLine(calculator.Add(2, 3));



        }
    }
}
