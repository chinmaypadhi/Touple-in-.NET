using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Touple
{

    class toupleClass
    {
        //Touple method retuurn type
        public (int,string) add()
        {
            return (12, "chinmay");

        }
        public (int a, string b) addNew()
        {
            return (12, "chinmay");

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            //inline touple variable declaretion
            (int, string) mydata = (12, "chinmay");
            Console.WriteLine(mydata.Item1);
            Console.WriteLine(mydata.Item2);

            //Calling touple returntype method
            toupleClass obj = new toupleClass();
            var x = obj.add();
            Console.WriteLine(x.Item1);
            Console.WriteLine(x.Item2);
            ///////////////////////////////////////////////
            toupleClass obj1 = new toupleClass();
           (int a,string b) = obj.add();
            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.Read();

        }
    }
}
