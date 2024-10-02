using Tyuiu.KomarovaMV.Sprint1.Task4.V28.Lib;
namespace Tyuiu.KomarovaMV.Sprint1.Task4.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds=new DataService();
            double x = 2;
            double y = 10;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0,res);
        }
    }
}