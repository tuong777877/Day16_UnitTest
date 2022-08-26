namespace ExampleUTest
{
    [TestClass]
    public class UnitTest1
    {
        private const string Expected = "Hello, World!";
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.Main();

                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
        [TestMethod]
        public void TestMethod2()
        {
            float number1 = 4;
            float number2 = 5;
            float expected = 9;
            float actual = number1 + number2;
            Assert.AreEqual(expected, actual);
        }
        Calculation cal = new Calculation();
        [TestMethod]
        public void TestAddition()
        {
            
            float number1 = 4;
            float number2 = 5;
            float expected = 9;
            float actual = cal.Addition(number1,number2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestSubtraction()
        {
            float number1 = 4;
            float number2 = 5;
            float expected = -1;
            float actual = cal.Subtraction(number1, number2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMultiplication()
        {
            float number1 = 4;
            float number2 = 5;
            float expected = 20;
            float actual = cal.Multiplication(number1, number2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestDivision()
        {
            float number1 = 1;
            float number2 = 2;
            double expected = 0.5;
            double actual = cal.Division(number1, number2);
            Assert.AreEqual(expected, actual);
        }
    }
}