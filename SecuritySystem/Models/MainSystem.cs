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
            Employee employee = new Employee(id, surname, name, document, fileNumber);
            listPeople.Add(employee);
            return true;
        }

        public bool addVisit(string surname, string name, int document, string company)
        {
            int id = 1;
            if (listPeople.Count > 0) { id = listPeople.Count + 1; }
            Visit visit = new Visit(id, surname, name, document, company);
            listPeople.Add(visit);
            return true;
        }

        public Person GetPerson(int id)
        {
            return listPeople.Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Person> GetListPerson()
        {
            return listPeople;
        }

        public List<Security> GetSecurities(DateTime date, Person person)
        {
            var listSecuritiesByDate = listSecurity.Where(x => x.date == date).ToList();
            return listSecuritiesByDate.Where(x => x.person.Equals(person)).ToList();
        }

        public bool addSecurity(DateTime date, DateTime hour, bool entry, Person person)
        {
            Security security = new Security(date, hour, entry, person);
            var listSecurityByPerson = GetSecurities(date, person);
            if(listSecurityByPerson.Count > 0)
            {
                if(listSecurityByPerson.Any(x => x.hour == hour))
                {
                    //la persona ya ficho
                    return false;
                }
                else
                {
                    listSecurity.Add(security);
                    return true;
                }
            }
            else
            {
                listSecurity.Add(security);
                return true;
            }
        }

        public List<Security> GetSecurities(DateTime date)
        {
            return listSecurity.Where(x => x.date == date).ToList();
        }
    }
}
