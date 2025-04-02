namespace SomeTest;

public class Tests
{
    [Test]
    public void Test1()
    {
        var element = new SomeClass.SomeClass(1);

        Assert.That(element.Data, Is.EqualTo(1));

        element.Data = 2;

        Assert.That(element.Data, Is.EqualTo(2));
    }
}
