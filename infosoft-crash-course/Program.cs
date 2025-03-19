using System;

namespace infosoft_crash_course
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //paired Arrays with while loop
            string[] emails = { "test1@gmail.com", "test2@gmail.com", "test3@gmail.com", "test4@gmail.com", "test5@gmail.com" };
            string[] username = { "test1", "test2", "test3", "test4", "test5"};
            string[] password = { "123", "124", "125", "126", "127"};

            int i = 0;

            while (i < emails.Length)
            {
                Console.WriteLine("ID: " + i + "\n" + 
                    "Email:" + emails[i] + 
                    "\n" + "Username:" + username[i] + 
                    "\n" + "Password:" + password[i]);

                i++;
            }

            //for loop
            for(int x = 0; x < emails.Length; x++)
            {
                Console.WriteLine(emails[x]);
            }

            //foreach
            foreach(string email in emails)
            {
                Console.WriteLine(email);
            }
            


            simpleFunction();
            add(1, 2);

            int num = -1;

            if(num < 0)
            {
                Console.WriteLine("Negative Number");
            }
            else
            {
                Console.WriteLine("Not Nega");
            }




            int[] nums =
            {
                1,2,3,4
            };

          

            //function SUM
            Console.WriteLine(summation(nums));

            //with LINQ SUM
            int result = nums.Sum();

            Console.WriteLine(result);

           
        }
        
        static void simpleFunction()
        {
            Console.WriteLine("Simple Function");
        }

        //function with parameters

        static void add(int a , int b)
        {
            Console.WriteLine(a + b);
        }

        public int sum(int num1, int num2)
        {
           int result = num1 + num2;
           
           return result;
        }

        static int summation(int[]nums)
        {
            int result = 0;

            for(int i =0; i < nums.Length; i++)
            {
                result += nums[i];
               
            }
            return result;
            

        }

    }
}

