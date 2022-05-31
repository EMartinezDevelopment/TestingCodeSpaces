using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestingCodeSpacesTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    { 
        Console.WriteLine("Testing now beginning...");
        var car = new Car("jim2");
        Assert.AreEqual("beep", car.Honk());
    }
}