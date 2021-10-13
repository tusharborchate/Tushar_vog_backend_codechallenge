using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace VogCodeChallenge.ConsoleApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            QuestionClass.Iterate(0);
            Console.ReadLine();
        }
        public static class QuestionClass
        {
            static List<string> NamesList = new List<string>()
                    {
                    "Jimmy",
                    "Jeffrey",
                    "John",
                    };


            public static void Iterate(int i)
            {
                if(i>=NamesList.Count)
                {
                    return;
                }
                Console.WriteLine(NamesList[i]);
                Iterate(i + 1);
            }
           

    }

}
}
