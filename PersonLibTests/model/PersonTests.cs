using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonLib.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonLib.model.Tests
{
    




    [TestClass()]
    public class PersonTests
    {
        private Person person;

        [TestInitialize]
        public void BeforeEachTest()
        {
            person = new Person();
        }


        [TestMethod()]
        [DataRow(1000)]
        [DataRow(99999)]
        [DataRow(5000)]
        public void PersonIdOk(int id)
        {
            //Arrange
            //Person person = new Person();
            int expectedId = id;


            //Act
            person.Id = id;

            // Assert
            Assert.AreEqual(expectedId, person.Id);
        }

        [TestMethod()]
        [DataRow(999)]
        [DataRow(100000)]
        [DataRow(-5000)]
        public void PersonIdNotOK(int id)
        {
            //Arrange
            //Person person = new Person();
            int expectedId = id;


            //Act + Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => person.Id = id);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            Assert.Fail();
        }
    }
}