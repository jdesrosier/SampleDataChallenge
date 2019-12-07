using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SampleDataChallenge
{
    class SampleData
    {
        private Random random = new Random();
        private string[] firstNames = File.ReadAllLines(@"Data\FirstNames.txt");
        private string[] surnames = File.ReadAllLines(@"Data\Surnames.txt");

        public int GetRandomNumber(int min=0, int max=9)
        {
            return random.Next(min, max);
        }

        private long GetNumbers(int total)
        {
            string integers = "";
            for(int i=0;i<total;i++)
            {
                integers += GetRandomNumber();
            }

            return long.Parse(integers);
        }

        public string GetFirstName()
        {
            int index = GetRandomNumber(0, firstNames.Length);

            return firstNames[index];
        }

        public string GetLastName()
        {
            int index = GetRandomNumber(0, surnames.Length);

            return surnames[index];
        }

        public string GetFullName()
        {
            return GetFirstName() + " " + GetLastName();
        }

        public bool GetBoolean()
        {
            return Convert.ToBoolean(random.Next(2));
        }

        // Bonus Challenge

        //Double
        public double GetDouble(int min=0, int max=10)
        {
            return random.NextDouble();
        }

        //PhoneNumber
        public string GetPhoneNumber()
        {
            return GetCustom("(###) ##-####");
        }

        //ZipCode
        public string GetZipCode()
        {
            return GetCustom("#####-####");
        }

        //Custom
        public string GetCustom(string pattern)
        {
            int digitCount = 0;
            char[] chars = pattern.ToCharArray();
            for(int i=0; i<chars.Length; i++)
            {
                if(chars[i].Equals('#'))
                {
                    digitCount++;
                }
            }

            string customPattern = "{0:" + pattern + "}";

            return String.Format(customPattern, GetNumbers(digitCount));
        }
    }
}
