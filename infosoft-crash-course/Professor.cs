using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infosoft_crash_course
{
    public class Professor
    {
        public string professorName { get; set; }
        public string professorDepartment { get; set; }

        public float midtermGrade { get; set; }
        public float finalGrade { get; set; }

        public Professor(string professorName, string professorDepartment, float midtermGrade, float finalGrade)
        {
            this.professorName = professorName;
            this.professorDepartment = professorDepartment;
            this.midtermGrade = midtermGrade;
            this.finalGrade = finalGrade;
        }

        public void evaluateGrade()
        {
            float avgGrade = (midtermGrade + finalGrade) / 2;

            Console.WriteLine("Average Grade: " + avgGrade);

            if (avgGrade < 75)
            {
                Console.WriteLine("Failed");
            }
            else if (avgGrade <= 90)
            {
                Console.WriteLine("Passed");
            }
            else if (avgGrade <= 95)
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


        }
    }
}
