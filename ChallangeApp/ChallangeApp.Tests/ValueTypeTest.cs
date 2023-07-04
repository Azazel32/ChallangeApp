namespace ChallangeApp.Tests
{
    public class ValueTypeTest
    {
        [Test]
        public void WhenNumbersValueAreTheSame_SchouldReturnCorrect()
        {
            int num1 = 12;
            int num2 = 12;
            Assert.AreEqual(num1, num2);
        }
        [Test]
        public void WhenNumbersSumIsBiggerThan12_SchouldReturnCorrect()
        {
            int num1 = 12;
            int num2 = 15;
            
            Assert.Greater(num1 + num2, 12);
        }
    }
}
