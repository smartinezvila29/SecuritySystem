using SecuritySystem.Models;

namespace SecurityTest
{
    public class SecurityTest
    {
        private readonly MainSystem _service;

        public SecurityTest()
        {
            _service = new MainSystem();
            _service.addVisit("Molina", "Rocio", 22222222, "UNLa");
            _service.addEmployee("Lopez", "Martin", 33333333, 3829);
            _service.addVisit("Martino", "Marcelo", 44444444, "COOP Tic");
            _service.addEmployee("Rodriguez", "Lucia", 11111111, 3840);
        }

        [Fact]
        public void AddSecurity_Result_True()
        {
            var result = _service.addSecurity(new DateTime(2021, 08, 26, 07, 50, 00), true, _service.GetPerson(1));

            Assert.True(result);
        }

        [Fact]
        public void GetSecurities_From_Specific_Date_True()
        {
            _service.addSecurity(new DateTime(2021, 08, 26, 07, 50, 00), true, _service.GetPerson(1));
            _service.addSecurity(new DateTime(2021, 08, 26, 08, 00, 00), true, _service.GetPerson(2));
            _service.addSecurity(new DateTime(2021, 08, 26, 18, 10, 00), false, _service.GetPerson(1));
            _service.addSecurity(new DateTime(2021, 08, 26, 18, 20, 00), false, _service.GetPerson(2));
            _service.addSecurity(new DateTime(2021, 08, 27, 09, 00, 00), true, _service.GetPerson(3));
            _service.addSecurity(new DateTime(2021, 08, 27, 09, 10, 00), true, _service.GetPerson(4));
            _service.addSecurity(new DateTime(2021, 08, 27, 18, 10, 00), false, _service.GetPerson(3));
            _service.addSecurity(new DateTime(2021, 08, 27, 18, 20, 00), false, _service.GetPerson(4));

            var result = _service.GetSecurities(new DateTime(2021, 08, 27, 00, 00, 00), _service.GetPerson(4));
            
            Assert.True(result.Any());
        }
        
        [Fact]
        public void Add_Security_Duplicated_Exit_Result_False()
        {
            _service.addSecurity(new DateTime(2021, 08, 26, 07, 50, 00), true, _service.GetPerson(1));
            _service.addSecurity(new DateTime(2021, 08, 26, 08, 00, 00), true, _service.GetPerson(2));
            _service.addSecurity(new DateTime(2021, 08, 26, 18, 10, 00), false, _service.GetPerson(1));
            _service.addSecurity(new DateTime(2021, 08, 26, 18, 20, 00), false, _service.GetPerson(2));
            _service.addSecurity(new DateTime(2021, 08, 27, 09, 00, 00), true, _service.GetPerson(3));
            _service.addSecurity(new DateTime(2021, 08, 27, 09, 10, 00), true, _service.GetPerson(4));
            _service.addSecurity(new DateTime(2021, 08, 27, 18, 10, 00), false, _service.GetPerson(3));
            _service.addSecurity(new DateTime(2021, 08, 27, 18, 20, 00), false, _service.GetPerson(4));

            var result = _service.addSecurity(new DateTime(2021, 08, 27, 18, 25, 00), false, _service.GetPerson(4));
            
            Assert.False(result);
        }
    }
}