using NUnit.Framework;
using TestTestingGit.Services;

namespace TestProject {
    public class Tests {
        private Calc Calc;
        [SetUp]
        public void Setup() {
            Calc = new Calc();
        }

        [TestCase(2, 3)]
        public void Test1(int first, int second) {
            Assert.AreEqual(Calc.Sum(first, second), 5);
        }
    }
}