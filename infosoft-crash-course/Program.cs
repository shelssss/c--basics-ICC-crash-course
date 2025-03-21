using System;
using System.Security.Cryptography.X509Certificates;

namespace infosoft_crash_course
{
    class Program
    {
        static void Main(string[] args)
        {   
            //March 20 2025

            //class and constructor 
            /* string name;
             int mmr;
             string role;

             Console.Write("Enter Your In Game Name");
             name = Console.ReadLine();
             Console.WriteLine("Enter you MMR");
             mmr = int.Parse(Console.ReadLine());
             Console.Write("Enter your Role");
             role = Console.ReadLine();

             GameProfile GameProfile = new GameProfile(name,mmr,role); */

            /*Students studs = new Students("Test", "Test2", "4th", "IT", "Manga", 88.6f, 90.8f);

            Console.WriteLine(studs.introduceStudent());
            studs.evaluateGrade(100.6f, 108.8f);

            //encapsulation using automatic properties
            Encapsulation encaps = new Encapsulation("name","active",23); */


            //Inheritance 
            Students studs = new Students("Angelo", "Pal", "4th", "IT", "Manga","Sir Mj", "CCE", 88.6f, 90.8f);

            studs.gradeReport();


           
        }
        


      


     


    }
}

