using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    delegate string Assignments(string answer);

    class Program
    {
        event Assignments status;
                public string Check(string x)
        {
            
            string ans = "no";
            while (ans != "Yes")
            {
                Console.ReadLine();
            }
            return "yes";
        }
        static void Main(string[] args)
        {
            Program obj1 = new Program();
            string result = obj1.status("yes");
            Console.WriteLine(result);
            
        }
    }
}
