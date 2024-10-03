using Tyuiu.KomarovaMV.Sprint1.Task6.V13.Lib;
namespace Tyuiu.KomarovaMV.Sprint1.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string str = "ABCD";
            Assert.AreEqual(true,ds.CheckWordsAlphabet(str));
        }
    }
}