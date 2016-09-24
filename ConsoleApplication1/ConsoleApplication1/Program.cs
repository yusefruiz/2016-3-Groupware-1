using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        
        static void Main(string[] args)
        {

            string userName;
            Console.WriteLine("Escriba el nombre de usuario: ");
            userName = Console.ReadLine();
            Console.WriteLine(
                GenerateHelloWorld.GenerateHelloWorldMessage(userName));
            Console.ReadLine();

        }
    }
}
