using NUnit.Framework;

public class BubbleSortTest
{
    [Test]
    public void TestEmptyArray()
    {
        int[] res = Bubblesort.Sort(new int[] { });
        Assert.AreEqual(new int[] { }, res);
    }

    [Test]
    public void Test1Element()
    {
        int[] res = Bubblesort.Sort(new int[] { 1 });
        Assert.AreEqual(new int[] { 1 }, res);
    }

    [Test]
    public void TestBubblesort1()
    {
        int[] res = Bubblesort.Sort(new int[] { 1, -5, 6, 3, 10 });
        Assert.AreEqual(new int[] { -5, 1, 3, 6, 10 }, res);
    }

    [Test]
    public void TestBubblesort2()
    {
        int[] res = Bubblesort.Sort(new int[] { -5, 1, 3, 6, 10 });
        Assert.AreEqual(new int[] { -5, 1, 3, 6, 10 }, res);
    }

    [Test]
    public void TestBytes()
    {
        byte[] res = Bubblesort.Sort(new byte[] { 55, 25, 100, 76, 255, 180 });
        Assert.AreEqual(new byte[] { 25, 55, 76, 100, 180, 255 }, res);
    }

    [Test]
    public void TestFloats()
    {
        float[] res = Bubblesort.Sort(new float[] { 55.1f, 25.234f, 100.87f, -76.44f, -255.756f, 180.0008f });
        Assert.AreEqual(new float[] { -255.756f, -76.44f, 25.234f, 55.1f, 100.87f, 180.0008f }, res);
    }
}
