using Labpractice.Controllers;
using Labpractice.Model;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace TestProject1
{
    public class Tests
    {
        private EmployeeController employeeController;

        [SetUp]
        public void Setup()
        {
            employeeController = new EmployeeController();
        }

        [Test]
        public void TestMethodForGetEmployee()
        {
            IEnumerable<Employee> result = employeeController.GetEmployee();
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(0));
        }

        [Test]
        public void TestMethodForPostEmployee()
        {
            var Employeepost = new Employee
            {
                Id = 1,
                Name = "Sanjai",
                Role = "Dotnet developer",
                Salary = 14000,
                Worklocation="Virudhunagar"
            };
            var actionResult = employeeController.PostEmployee(Employeepost);
            Assert.That(actionResult, Is.Not.Null);
        }

        [Test]
        public void TestMethodForPostEmployeeNull()
        {
            var newItem = new Employee
            {
                Id = 1,
                Name =null,
                Role = null,
                Salary = 14000,
                Worklocation= null
            };
            var actionResult = employeeController.PostEmployee(newItem);
            Assert.IsNotInstanceOf<BadRequest>(actionResult);
        }


    }
}