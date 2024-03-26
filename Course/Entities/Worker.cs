using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course.Entities.Enums;

namespace Course.Entities
{
    class Worker
    {

        public string Name { get; set; }
        public  double BaseSalary { get; set; }
        public EnumWorkerLevel Level { get; set;  }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();


        public Worker() { }
        public Worker(string name, double baseSalary, EnumWorkerLevel level, Department department)
        {
            Name = name;
            BaseSalary = baseSalary;
            Level = level;
            Department = department;
           
        }


        public void addContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void removeContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double soma = BaseSalary;

            foreach (HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    soma+= contract.Date.Month;
                }

            }
            return soma;
        }
    }
}
