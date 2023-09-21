using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecuritySystem.Models
{
    public class Employee : Person
    {
        private int FileNumber {  get; set; }

        public Employee(int id, string surname, string name, int document, int fileNumber)
        {
            Id = id;
            Surname = surname;
            Name = name;
            FileNumber = fileNumber;
            Document = document;
        }

        public override string ToString()
        {
            return "Id:" + this.Id + " Name:" + this.Name + " Surname:" + this.Surname + " Document:" + this.Document
                + " FileNumber:" + this.FileNumber;
        }
    }
}
