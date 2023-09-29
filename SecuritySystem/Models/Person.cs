using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecuritySystem.Models
{
    public abstract class Person
    {
        public int Id { get; set; }
        protected string Surname { get; set; }
        protected string Name {  get; set; }
        protected int Document {  get; set; }

        //override
        public bool Equals(Person other)
        {
            if (other.Name == this.Name
                & other.Document == this.Document
                & other.Surname == this.Surname)
            {
                return true;
            }
            else { return false; }
        }

        public int GetDocument()
        {
            return this.Document;
        }
    }
}
