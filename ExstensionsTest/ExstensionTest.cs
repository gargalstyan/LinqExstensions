using LinqExstensions;

namespace ExstensionsTest
{
    [TestClass]
    public class ExstensionTest
    {
        [TestMethod]
        public void MySkipWhileTest()
        {
            //Assign
            List<int> numbers1 = new List<int>() { -4, 5, 1, 4, -5, 12, 5, 123, 2, 4 };
            //Act
            List<int> numbers = numbers1.MySkipWhile(i => i < 11).ToList();
            //Assert
            CollectionAssert.AreEqual(new List<int> { 12, 5, 123, 2, 4 }, numbers);
        }
        [TestMethod]
        public void MyExceptTest()
        {
            //Assign 
            List<int> numbers1 = new List<int>() { 1, 2, 2, 2, -4, -4, -2, 12,12,12, 13, -1, 3, -5 };
            List<int> numbers2 = new List<int>() { 1, 2, -4, 6, 7, 8, 9, 10, 11 };

            //Act
            List<int> numbers = numbers1.Except(numbers2).ToList();
            //Assert
            CollectionAssert.AreEqual(new List<int> { -2, 12, 13, -1, 3, -5 }, numbers);
        }
        [TestMethod]
        public void MySingleTest()
        {
            //Assign
            List<int> numbers = new List<int>() { 1, 3, 5, 6, -4, 5, 12, 12, 13 };
            List<int> numbers1 = new List<int>();
            List<int> numbers2 = new List<int>() { 1, 12, 12, 13, 14 };
            //Act
            int number = numbers.MySingle(i => i > 12);
            //Assert
            Assert.AreEqual(13, number);
            Assert.ThrowsException<InvalidOperationException>(()=> numbers1.MySingle(i => i > 12));
            Assert.ThrowsException<InvalidOperationException>(() => numbers2.MySingle(i => i > 12));

        }
        [TestMethod]
        public void MyAllTest()
        {
            //Assign
            List<int> numbers = new List<int>() { 1, 3, 5, 6, -4, 5, 12, 12, 13 };
            List<int> numbers1 = new List<int>();
            //Act
            bool first = numbers.All(i => i > -5);
            bool second = numbers.All(i => i > -4);
            bool third = numbers1.All(i => i > -4);
            //Assert
            Assert.IsFalse(second);
            Assert.IsTrue(first && third);

        }
    }
}