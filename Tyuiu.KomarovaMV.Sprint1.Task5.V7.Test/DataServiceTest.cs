using Tyuiu.KomarovaMV.Sprint1.Task5.V7.Lib;
namespace Tyuiu.KomarovaMV.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds= new DataService();
            double x = 150;
            var res = ds.AngleToHoursMinutes(x);
            Assert.AreEqual(5, res);
        }
    }
}