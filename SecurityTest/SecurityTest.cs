using SecuritySystem.Models;

namespace SecurityTest
{
    public class SecurityTest
    {
        private readonly MainSystem _service;

        public SecurityTest()
        {
            _service = new MainSystem();
        }

        [Fact]
        public void AddSecurity()
        {
            _service.addVisit("Molina", "Rocio", 22222222, "UNLa");
            var result = _service.addSecurity(new DateTime(2021, 08, 26, 07, 50, 00), true, _service.GetPerson(1));

            Assert.True(result);
        }
    }
}