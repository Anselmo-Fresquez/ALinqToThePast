using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Library {
    [TestClass]
    public class BuilderTest {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void BuildIntegerSequenceTest () {
            //arr
            Builder listBuilder = new Builder();

            //act
            var result = listBuilder.BuildIntegerSequence(0, 10);

            //lyz
            foreach (var item in result) {
                TestContext.WriteLine(item.ToString());
            }

            TestContext.WriteLine("???");

            //ert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void BuildAlphabetTest () {
            Builder listBuilder = new Builder();
            var alphabet = listBuilder.BuildAlphabet();

            // Analyze
            foreach (string letter in alphabet) {
                TestContext.WriteLine(letter);
            }

            Assert.AreEqual(alphabet.First(), "A");
            Assert.AreEqual(alphabet.Last(), "Z");
        }

        [TestMethod]
        public void TestRandomNumberGenerator () {
            Builder builder = new Builder();

            var randomNumbers = builder.BuildRandomNumberSequence();

            Assert.IsTrue(Math.Abs(randomNumbers.Average() - 50) < 5);
            TestContext.WriteLine(randomNumbers.Average().ToString());
        }
    }
}
