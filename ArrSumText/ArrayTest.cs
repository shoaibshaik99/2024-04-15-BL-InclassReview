using ArryaProbForMSTest;

namespace ArrSumTest
{
    [TestClass]
    public class ArrayTests
    {
        [TestMethod]
        public void CheckArrSumTest()
        {
            //Arrange
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 9, 4, 3, 2, 1 };

            //Act
            bool desiredOutput = false;
            bool actualOutput = Arrays.CheckArrSum(arr1, arr2);

            //Assert
            Assert.AreEqual(desiredOutput, actualOutput);
        }
    }
}