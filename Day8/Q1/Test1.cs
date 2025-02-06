using Day8Assignment1;

namespace Day8Assignment1MSTesting
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void Add()
        {
            Calculator cal = new Calculator();
            double res = cal.Addition(20, 3);
            Assert.AreEqual(res, 23);
        }
        [TestMethod]
        public void Sub()
        {
            Calculator cal = new Calculator();
            double res = cal.Subtraction(20, 30);
            Assert.AreEqual(res, -10);
        }
        [TestMethod]
        public void Mul()
        {
            Calculator cal = new Calculator();
            double res = cal.Multiplication(10, 4);
            Assert.AreEqual(res, 40);
        }
        [TestMethod]
        public void Div()
        {

            Calculator cal = new Calculator();
            double res = cal.Division(30, 3);
            Assert.AreEqual(10, res);

        }
        [TestMethod]
        public void DivbyZero()
        {
            Calculator cal = new Calculator();
            Assert.ThrowsException<DivideByZeroException>(() => cal.Division(10, 0));
        }

    }
}
