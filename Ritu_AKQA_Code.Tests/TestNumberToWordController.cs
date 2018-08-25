using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ritu_AKQA_Code.Models;
using Ritu_AKQA_Code.Controllers;
using System.Web.Http.Results;
using Moq;
using System.Net.Http;
using System.Net;
using Ritu_AKQA_Code.Repository;

namespace Ritu_AKQA_Code.Tests
{
    [TestClass]
    public class TestNumberToWordController
    {

        [TestMethod]
        public void GetPerson_ShouldReturnCorrectPerson()
        {
            var mockRepository = new Mock<IPersonRepository>();
            var testPerson = GetTestPerson();
            mockRepository
        .Setup(x => x.GetPerson(testPerson))
        //This will only succeed if I have the Returns property here,
        //but isn't that just bypassing the actual "test" of whether or
        //not this works?
        .Returns(testPerson);

            NumberToWordController controller = new NumberToWordController(mockRepository.Object);

            var response = controller.GetPerson(testPerson) as OkNegotiatedContentResult<Person>;

          
            Assert.IsNotNull(response);
            Assert.AreEqual(testPerson.Name, response.Content.Name );
        }

        //[TestMethod]
        //public async Task GetProductAsync_ShouldReturnCorrectProduct()
        //{
        //    var testProducts = GetTestProducts();
        //    var controller = new SimpleProductController(testProducts);

        //    var result = await controller.GetProductAsync(4) as OkNegotiatedContentResult<Product>;
        //    Assert.IsNotNull(result);
        //    Assert.AreEqual(testProducts[3].Name, result.Content.Name);
        //}


        private Person GetTestPerson()
        {
            var testPerson = new Person();
            testPerson.Name = "Ritu Jain";
            testPerson.Number = "2234.45";
           

            return testPerson;
        }
    }
}
