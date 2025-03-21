using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infosoft_crash_course
{
    public class Students : Professor
    {
        string firstName { get; set; }
        string lastName { get; set; }
        string year { get; set; }
        string course {  get; set; }
        string section { get; set; }



        public Students(string firstName, string lastName, string year, string course, string section, string professorName, string professorDepartment, float midtermGrade, float finalGrade)
            : base(professorName, professorDepartment, midtermGrade, finalGrade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.year = year;
            this.course = course;
            this.section = section;
            
        }

        public string introduceStudent()
        {   
            return "I am " + firstName
                    + "\n" + lastName
                    + "\n" + year + " Student"
                    + "\n" + "From " + course
                    + "\n" + section;
        }

        public void gradeReport()
        {
            Console.WriteLine("Grade Report.....");
            Console.WriteLine("Student Name: " +  firstName + " " + lastName); 
            Console.WriteLine("Prepared By :" + professorName);
            base.evaluateGrade();
        }
        
        
        
    }
}
