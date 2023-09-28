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
        public void AddVisit()
        {
            var result = _service.addVisit("Molina", "Rocio", 22222222, "UNLa");

            Assert.True(result);
        }
    }
}