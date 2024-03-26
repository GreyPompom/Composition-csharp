using System;
using System.Globalization;
using Course.Entities.Enums;
using Course.Entities;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter department's name:"  );
            string dptName = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");
            Console.WriteLine("Name ");
            string name = Console.ReadLine();

            Console.WriteLine("Level Junior/MidLevel/Senior");
            //Conversão string para enum
            EnumWorkerLevel lebel= Enum.Parse<EnumWorkerLevel>(Console.ReadLine());
            Console.WriteLine( "Base Salary:");
            double baseSalary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture );
            //instaciando 
            Department dept = new Department(dptName);
            Worker worker = new Worker(name, baseSalary,lebel, dept);

            Console.WriteLine("How many contracts: ");
                int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter #"+i+" contract:");
                Console.WriteLine("Date (DD/MM/YYYY):");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour: R$");
                double valuePerHour = Double.Parse(Console.ReadLine());
                Console.WriteLine("Duration (hours):");
                int hours = int.Parse(Console.ReadLine());
                //instaciando
                HourContract contract = new HourContract(date, valuePerHour, hours);
                //adiocionando contrato ao trabalhador, passando o contrato como parametro
                worker.addContract(contract);
            }


            Console.WriteLine("Enter month and year to calculate income (MM/YYYY):");
            string mouthAndYear = Console.ReadLine();
            //substring para pegar apenas o mês
            int mouth =int.Parse( mouthAndYear.Substring(0, 2));
            int year = int.Parse(mouthAndYear.Substring(3));

            Console.WriteLine( "Name: "+  worker.Name);
            Console.WriteLine("Department "+ worker.Department.Name);
            Console.WriteLine("Income for "+mouthAndYear+": "+worker.Income(year,mouth));




        }
    }
}
