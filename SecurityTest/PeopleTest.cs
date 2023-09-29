using SecuritySystem.Models;

namespace SecurityTest
{
    public class PeopleTest
    {
        private readonly MainSystem _service;

        public PeopleTest()
        {
            _service = new MainSystem();
        }

        [Fact]
        public void AddVisit_Result_True()
        {
            var result = _service.addVisit("Molina", "Rocio", 22222222, "UNLa");

            Assert.True(result);
        }
        
        [Fact]
        public void AddEmployee_Result_True()
        {
            var result = _service.addEmployee("Lopez", "Martin", 33333333, 3829);

            Assert.True(result);
        }

        [Fact]
        public void GetPerson_Result_True()
        {
            _service.addVisit("Molina", "Rocio", 22222222, "UNLa");
            _service.addEmployee("Lopez", "Martin", 33333333, 3829);
            _service.addVisit("Martino", "Marcelo", 44444444, "COOP Tic");
            _service.addEmployee("Rodriguez", "Lucia", 11111111, 3840);

            var result = _service.GetPerson(1).ToString();

            Assert.Equal("Id:1 Name:Rocio Surname:Molina Document:22222222 Company:UNLa", result);
        }

        [Fact]
        public void AddEmployeeDuplicated_Result_False()
        {
            _service.addEmployee("Lopez", "Martin", 33333333, 3829);
            var result = _service.addEmployee("Lopez", "Martin", 33333333, 3829);

            Assert.False(result);
        }

        [Fact]
        public void AddVisitDuplicated_Result_False()
        {
            _service.addVisit("Martino", "Marcelo", 44444444, "COOP Tic");
            var result = _service.addVisit("Martino", "Marcelo", 44444444, "COOP Tic");

            Assert.False(result);
        }
    }
}