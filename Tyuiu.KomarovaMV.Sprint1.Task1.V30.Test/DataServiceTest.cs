using Tyuiu.KomarovaMV.Sprint1.Task1.V30.Lib;
namespace Tyuiu.KomarovaMV.Sprint1.Task1.V30.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidExpression()
    {
        DataService ds= new DataService ();
        double x = 10;
        var res=ds.Calculate(x);
        Assert.AreEqual(6, res);

    }
}