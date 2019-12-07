using System;

namespace SampleDataChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleData sd = new SampleData();

            Console.WriteLine("Full Name: {0}", sd.GetFullName());

            Console.WriteLine("Single Random Number (0-9): {0}", sd.GetRandomNumber());

            Console.WriteLine("Single Random Number (0-100): {0}", sd.GetRandomNumber(0,100));

            Console.WriteLine("Boolean: {0}", sd.GetBoolean());

            Console.WriteLine("SSN: {0}", sd.GetCustom("###-##-####"));

            Console.WriteLine("Phone Number: {0}", sd.GetPhoneNumber());

            Console.WriteLine("Zip Code: {0}", sd.GetZipCode());


        }
    }
}
