using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecuritySystem.Models
{
    public class Security
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public DateTime hour { get; set; }
        public bool Enter {  get; set; }
        public Person person { get; set; }

        public Security(DateTime date, bool enter, Person person)
        {
            this.date = date;
            this.Enter = enter;
            this.person = person;
        }
        public override string ToString()
        {
            return "Id: " + this.Id + " Date: " + this.date.ToString() + " Entry: " + 
                this.Enter + "\n Person: " + this.person.ToString();
        }
    }
}
