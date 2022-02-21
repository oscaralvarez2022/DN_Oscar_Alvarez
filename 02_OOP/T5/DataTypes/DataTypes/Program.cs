using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "This is a string";
            int age = 35;
            DateTime now = DateTime.Now;
            double amount = 0;

            string string2 = text + " a second string " + age + now + amount;

            string string3 = string.Format("The age is {0}, the time is {1}, and the amount is {2}", age, now, amount);

            string string4 = $"The age is {age}, the time is {now}, and the amount is {amount}";

            char simpleChar = 'C';

            char[] arrayChar = string4.ToCharArray();


            /*for (int i=0; i<arrayChar.Length; i++)
            {
                Console.WriteLine(arrayChar[i]);
            }*/

            /*for (int i = 0; i < string4.Length; i++)
            {
                Console.WriteLine(arrayChar[i]);
            }*/

            /*amount = (double)10 / (double)3;
            Console.WriteLine(amount.ToString());*/

            /*DateTime dateTime = new DateTime(2000, 1, 1);
            TimeSpan timeStamp1 = now - dateTime;
            Console.WriteLine(timeStamp1.TotalMilliseconds);*/

            /*string test = "15";
            age = int.Parse(test);*/

            string booleanValue = "True";
            bool isTrue =bool.Parse(booleanValue);



            // Console.WriteLine(simpleChar);

            Console.ReadKey();
        }
    }
}
