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
        public EnumWorkerLevel leve { get; set;  }

        public Worker()
        {
        }

        public Worker(string name, double baseSalary, EnumWorkerLevel leve)
        {
            Name = name;
            BaseSalary = baseSalary;
            this.leve = leve;
        }
    }
}
