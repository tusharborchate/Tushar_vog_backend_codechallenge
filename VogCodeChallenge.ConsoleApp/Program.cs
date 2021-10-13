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
            QuestionClass.TESTModule(1);
            QuestionClass.TESTModule(5);
            QuestionClass.TESTModule(1.0f);
            QuestionClass.TESTModule(6.0f);
            QuestionClass.TESTModule("test");
            QuestionClass.TESTModule(new string[] { });
            QuestionClass.TESTModule(-1);


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
            public static object TESTModule(object input)
            {
                var typeCode = Type.GetTypeCode(input.GetType());
                object result = null;
                switch (typeCode)
                {
                    case TypeCode.Int32:
                        int i = (int)input;
                        if(i>=1 && i<=4)
                        {
                            result= i * 2;
                        }
                        else if (i > 4)
                        {
                            result = i * 3;
                        }
                        else
                        {
                            throw new Exception("provided negative value");
                        }
                        break;

                    case TypeCode.Single:
                        float f= (float)input;
                        if (f == 1.0f || f == 2.0f)
                        {
                            result = 3.0f;
                        }
                        
                        break;

                    case TypeCode.String:
                        result = input.ToString().ToUpper();
                        break;
                    default:
                        result = input;
                        break;
                }
                Console.WriteLine(result);
                return result;
            }

    }

}
}
