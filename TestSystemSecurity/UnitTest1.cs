using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using SecuritySystem.Models;

namespace TestSystemSecurity
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestAddVisit()
        {
            MainSystem system = new MainSystem();
            var result = system.addVisit("Molina", "Rocio", 22222222, "UNLa");
            
        }

        //[Test]
        //public void TestAddEmployee(string surname, string name, int document,int fileNumber)
        //{
        //    system.addVisit("Molina", "Rocio", 22222222, "UNLa");
        //    system.addEmployee("Lopez", "Martin", 33333333, 3829);
        //    system.addVisit("Martino", "Marcelo", 44444444, "COOP Tic");
        //    system.addEmployee("Rodriguez", "Lucia", 11111111, 3840);
        //    Assert.True();
        //}


        //[Test]
        //public void TestGetPerson()
        //{
        //    Console.WriteLine(system.GetPerson(1).ToString());
        //}

        //[Test]
        //public void TestAddSecurity()
        //{

        //}
        
        //[Test]
        //public void TestGetSecurityByPersonAndDate()
        //{

        //}
    }
}
