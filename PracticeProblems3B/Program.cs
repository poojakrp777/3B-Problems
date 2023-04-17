using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static PracticeProblems3B.Interfaceclass;

namespace PracticeProblems3B
{
    public class Program
    {
        static void Main(string[] args)
        {
            // call Default constructor
            Employee e1 = new Employee();
            Employee e2 = new Employee();

            Employee e3 = new Employee(101, "Pooja", 90000);
            Employee e4 = new Employee(102, "Mahesh", 90000);
            e3.display();
            e4.display();

            Pig myPig = new Pig();  // Create a Pig object
            myPig.animalSound();

            var publicAccessSpecifiers = new AccessModifiers();
            publicAccessSpecifiers.Value = 10;
            var result = publicAccessSpecifiers.IncrementValue(publicAccessSpecifiers.Value);
            Console.WriteLine(result);
            Console.ReadLine();

            // Private Access Modifier
            var account = new BankAccount();
            account.Deposit(500);
            var balance = account.GetBalance();
            Console.WriteLine(balance);
            Console.ReadLine();

            // Protected Access Modifier
            var rectangle = new Rectangle(10, 5);
            var area = rectangle.GetArea();
            Console.WriteLine(area);
            Console.ReadLine();

            // Internal Access Modifier
            var logger = new Logger();
            var messageLog = logger.LogMessage("This is a message");
            Console.WriteLine(messageLog);
            Console.ReadLine();
        }
    }
   


}
