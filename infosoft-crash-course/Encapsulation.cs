using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infosoft_crash_course
{
    public class Encapsulation
    {
        //Automatic Properties
        //Note: Automatic properties cannot have conditions unlike manually created attritbutes or properties
        public string name{ get; set; }
        public string status{ get; set; }
        public int age{ get; set; }

       

        public Encapsulation(string name, string status, int age)
        {
            this.name = name;
            this.status = status;
            this.age = age;
        }
    }
}
