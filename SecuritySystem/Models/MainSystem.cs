using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecuritySystem.Models
{
    public class MainSystem
    {
        private List<Person> listPeople = new List<Person>();
        private List<Security> listSecurity = new List<Security>();

        public bool addEmployee(string surname, string name, int document, int fileNumber)
        {
            int id = 1;
            if (listPeople.Count > 0) { id = listPeople.Count + 1; }
            if(this.GetPersonByDocument(document) != null)
            {
                return false;
            }
            Employee employee = new Employee(id, surname, name, document, fileNumber);
            listPeople.Add(employee);
            return true;
        }

        public bool addVisit(string surname, string name, int document, string company)
        {
            int id = 1;
            if (listPeople.Count > 0) { id = listPeople.Count + 1; }
            if (this.GetPersonByDocument(document) != null)
            {
                return false;
            }
            Visit visit = new Visit(id, surname, name, document, company);
            listPeople.Add(visit);
            return true;
        }

        public Person GetPerson(int id)
        {
            return listPeople.Where(x => x.Id == id).FirstOrDefault();
        }
        
        public Person GetPersonByDocument(int document)
        {
            return listPeople.Where(x => x.GetDocument() == document).FirstOrDefault();
        }

        public List<Person> GetListPerson()
        {
            return listPeople;
        }

        public List<Security> GetSecurities(DateTime date, Person person)
        {
            var listSecuritiesByDate = listSecurity.Where(x => x.date.Date == date.Date).ToList();
            return listSecuritiesByDate.Where(x => x.person.Equals(person)).ToList();
        }

        public List<Security> GetSecurities()
        {
            return listSecurity;
        }

        public bool addSecurity(DateTime date, bool entry, Person person)
        {
            try
            {
                Security security = new Security(date, entry, person);
                var listSecurityByPerson = GetSecurities(date, person);
                if (listSecurityByPerson.Count > 0)
                {
                    if (listSecurityByPerson.Any(x => x.date.Hour == date.Hour & x.date.Minute == date.Minute)
                        || listSecurityByPerson.Any(x => x.Enter.Equals(entry)))
                    {
                        throw new Exception("La persona ya ficho");
                    }
                    else
                    {
                        listSecurity.Add(security);
                        return true;
                    }
                }
                else
                {
                    if(person == null)
                    {
                        throw new Exception("La persona no existe");
                    }
                    listSecurity.Add(security);
                    return true;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public List<Security> GetSecurities(DateTime date)
        {
            return listSecurity.Where(x => x.date.Date == date.Date).ToList();
        }
    }
}
