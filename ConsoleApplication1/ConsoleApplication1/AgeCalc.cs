using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class AgeCalc
    {
        private String input;
        private DateTime birthdate;
        public AgeCalc(String input)
        {
            this.input = input;
            
        }

        // checks if input is date
        public Boolean check()
        {
            Boolean date = false;

            try
            {
                birthdate = DateTime.Parse(input);
                date = true;

                calculateAge();

            }
            catch { 
            date =  false;
                Console.WriteLine("invalid date");
        }
            return date;
        }

        public void calculateAge()
        {
            DateTime dt = DateTime.Today;

            int age = (int) dt.Subtract(birthdate).TotalDays/365;

            TimeSpan timespan = dt.Subtract(birthdate);



            Console.WriteLine(age);

            //Console.WriteLine(dt.Subtract(birthdate)+"is the age");
            Console.ReadLine();
            

              

        }


    }
}
