using Tyuiu.KomarovaMV.Sprint1.Task2.V13.Lib;
namespace Tyuiu.KomarovaMV.Sprint1.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 10;
            var res=ds.ConvertMilesToKm(x);
            Assert.AreEqual(16.093,res);
        }
    }
}