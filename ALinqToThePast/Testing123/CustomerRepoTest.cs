using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ALinqToThePast;
using System.Linq;

namespace Testing123 {
    [TestClass]
    public class CustomerRepoTest {
        [TestMethod]
        public void FindCustomerTest() {
            CustomerRepository TestRepo = new CustomerRepository();
            Customer ShouldBeBilbo = TestRepo.Find(TestRepo.Retrieve(), 2);

            Assert.IsNotNull(ShouldBeBilbo);
            Assert.AreEqual(2, ShouldBeBilbo.CustomerId);
            Assert.AreEqual(ShouldBeBilbo.FirstName, "Bilbo");
            Assert.AreEqual(ShouldBeBilbo.LastName, "Baggins");
        }

        [TestMethod]
        public void SortByNameTest () {
            //arr
            CustomerRepository testRepo = new CustomerRepository(); // repo
            var customerList = testRepo.Retrieve(); // list of all customers

            //act
            var result = testRepo.SortByName(customerList, false); // sorted list

            Assert.IsNotNull(result);
            Assert.AreEqual(result.First().CustomerId, 2);
            Assert.AreEqual(result.First().FirstName, "Bilbo");
            Assert.AreEqual(result.First().LastName, "Baggins");
        }

    }
}
