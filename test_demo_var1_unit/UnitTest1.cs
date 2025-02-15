using WSUniversalLib;

namespace test_demo_var1_unit
{
    [TestClass]
    public class UnitTest1
    {
        Calculation calc = new Calculation();

        #region простые_тесты
        [TestMethod]
        public void TestFromSession2()
        {
            int excepted = 114147;
            int actual = calc.GetQuantityForProduct(3, 1, 15, 20, 45);
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void TestHard3()
        {
            int excepted = 2781747;
            int actual = calc.GetQuantityForProduct(1, 1, 400, (float)76.57, (float)82.32);
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void TestNotEqual()
        {
            int expected = -1;
            int actual = calc.GetQuantityForProduct(1, 1, 10, 10, 10);
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void TestIsNull()
        {
            int? result = null;

            try
            {
                result = calc.GetQuantityForProduct(0, 0, -1, -1, -1);
            }
            catch
            {
            }

            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestNotNull()
        {
            int actual = calc.GetQuantityForProduct(1, 1, 10, 10, 10);
            Assert.IsNotNull(actual);
        }

        [TestMethod]
        public void TestProductTypeMax()
        {
            int result = calc.GetQuantityForProduct(3, 1, 10, 10, 10);
            Assert.IsTrue(result > 0);
        }

        [TestMethod]
        public void TestEasy15()
        {
            int excepted = 221793;
            int actual = calc.GetQuantityForProduct(3, 1, 31, (float)28.3, (float)29.9);
            Assert.IsFalse(excepted != actual);
        }

        [TestMethod]
        public void TestEasy17()
        {
            int excepted = 4007;
            int actual = calc.GetQuantityForProduct(2, 2, 48, (float)2.9, (float)11.5);
            Assert.AreEqual(excepted, actual);
        }

        [TestMethod]
        public void TestMaterialTypeMin()
        {
            int result = calc.GetQuantityForProduct(1, 1, 10, 10, 10);
            Assert.IsInstanceOfType(result, typeof(int));
        }

        [TestMethod]
        public void TestMaterialTypeMax()
        {
            int result = calc.GetQuantityForProduct(1, 2, 10, 10, 10);
            Assert.IsNotInstanceOfType(result, typeof(string));
        }
        #endregion

        #region сложные_тесты
        [TestMethod]
        public void TestThrowsException()
        {
            Assert.ThrowsException<Exception>(() => calc.GetQuantityForProduct(4, 1, 10, 10, 10));
        }

        [TestMethod]
        public void TestWrongMaterialType()
        {
            Assert.ThrowsException<Exception>(() => calc.GetQuantityForProduct(1, 3, 10, 10, 10));
        }

        [TestMethod]
        public void TestIncorrectCount()
        {
            Assert.ThrowsException<Exception>(() => calc.GetQuantityForProduct(1, 1, -5, 10, 10));
        }

        [TestMethod]
        public void TestIncorrectWidth()
        {
            Assert.ThrowsException<Exception>(() => calc.GetQuantityForProduct(1, 1, 10, 0, 10));
        }

        [TestMethod]
        public void TestPutZeros()
        {
            Assert.ThrowsException<Exception>(() => calc.GetQuantityForProduct(1, 1, 0, 0, 0));
        }
        #endregion
    }
}