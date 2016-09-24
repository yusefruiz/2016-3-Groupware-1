using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    static public class GenerateHelloWorld
    {
        static public string GenerateHelloWorldMessage(string userName)
        {
            string result;
            result = "Hello World, " + userName;
            return (result);
        }

        static public string GenerateSecondHelloWorldMessage(
            string userName, string dayOfWeek)
        {
            string result;
            result = "Hello World, " + userName + ". Happy " + dayOfWeek;
            return (result);
        }

    }
}
