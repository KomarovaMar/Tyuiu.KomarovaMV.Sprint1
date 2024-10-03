using Tyuiu.KomarovaMV.Sprint1.Task7.V17.Lib;
namespace Tyuiu.KomarovaMV.Sprint1.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 20;
            var res =ds.Calculate(x, y);
            Assert.AreEqual(-0.447,res);
        }
    }
}