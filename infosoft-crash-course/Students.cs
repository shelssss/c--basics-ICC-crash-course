using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infosoft_crash_course
{
    public class Students
    {
        string firstName,
               lastName,
               year,
               course,
               section;
        float midtermGrade, finalGrade;

        public Students(string firstName, string lastName, string year, string course, string section, float midtermGrade, float finalGrade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.year = year;
            this.course = course;
            this.section = section;
            this.midtermGrade = midtermGrade;
            this.finalGrade = finalGrade;
        }

        public string introduceStudent()
        {   
            return "I am " + firstName
                    + "\n" + lastName
                    + "\n" + year + " Student"
                    + "\n" + "From " + course
                    + "\n" + section;
        }
        
        public string evaluateGrade(float midtermGrade, float finalGrade)
        {
            float avgGrade = (midtermGrade + finalGrade)/2;

            Console.WriteLine("Average Grade: " + avgGrade);

            if (avgGrade < 75)
            {
                Console.WriteLine("Failed");
            }
            else if (avgGrade <= 90)
            {
                Console.WriteLine("Passed");
            }
            else if(avgGrade <= 95)
            {
                Console.WriteLine("with Honors");
            }
            else if (avgGrade <= 98)
            {
                Console.WriteLine("with High Honors");
            }
            else if (avgGrade <= 100)
            {
                Console.WriteLine("with Highest Honors");
            }
            else
            {
                Console.WriteLine("Abnormal na grado");
            }

   
                return "" + avgGrade;
           
        }
    }
}
