namespace CustomPower.Tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;
    public UnitTest1()
    {
        _test = new Class1();
    }
    [TestMethod]
    public void TestMethod1()
    {
        double x = 2.0;
        int n = 10;
        var result = _test.MyPow(x, n);
        Assert.AreEqual(1024.0, result);
    } 
    
    [TestMethod]
    public void TestMethod2()
    {
        double x = 2.1;
        int n = 3;
        var result = _test.MyPow(x, n);
        Assert.AreEqual(9.261000000000001, result);
    }
    
    [TestMethod]
    public void TestMethod3()
    {
        double x = 2.0;
        int n = -2;
        var result = _test.MyPow(x, n);
        Assert.AreEqual(0.25000, result);
    }
    
    [TestMethod]
    public void TestMethod4()
    {
        double x = 1.0;
        int n = -2147483648;
        var result = _test.MyPow(x, n);
        Assert.AreEqual(1.0, result);
    }
}