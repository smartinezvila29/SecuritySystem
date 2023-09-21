using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecuritySystem.Models
{
    public class Visit : Person
    {
        private string Company {  get; set; }

        public Visit(int id, string surname, string name, int document, string company)
        {
            Id = id;
            Surname = surname;
            Name = name;
            Document = document;
            Company = company;
        }

        public override string ToString()
        {
            return "Id:" + this.Id + " Name:" + this.Name + " Surname:" + this.Surname + " Document:" + this.Document
                + " Company:" + this.Company;
        }
    }
}
