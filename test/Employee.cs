using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    internal class Employee 
    {
        public string Familia { get; set; }
        public string Imail { get; set; }
        public Employee() { }
        public Employee(string familia, string imail)
            
        {
            Familia = familia;
            Imail = imail;
        }   
        public void ReturnInfo()
        {
            Console.WriteLine(Familia);
            Console.WriteLine(Imail);
        }
    }
}
