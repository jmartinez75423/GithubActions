namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Martinez()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Martinez()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Martinez()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
	}

 	[TestMethod]
    public void Subtract_Valid_Martinez()
    {
        Assert.AreEqual(5, Program.Subtract("10", "5"));
        Assert.AreEqual(5, Program.Subtract("10", "5"));
        Assert.AreEqual(0, Program.Subtract("3", "3"));
        Assert.AreEqual(-2, Program.Subtract("5", "7"));
    }

    	[TestMethod]
    public void Multiply_Valid_Martinez()
    {
        Assert.AreEqual(6, Program.Multiply("2", "3"));
        Assert.AreEqual(0, Program.Multiply("0", "5"));
        Assert.AreEqual(-14, Program.Multiply("-2", "7"));
    }

    	[TestMethod]
    public void Divide_Valid_Martinez()
    {
        Assert.AreEqual(5, Program.Divide("10", "2"));
        Assert.AreEqual(1, Program.Divide("3", "3"));
        Assert.AreEqual(2.5, Program.Divide("5", "2"));
    }

        [TestMethod]
    public void Power_Valid_Martinez()
    {
        Assert.AreEqual(8, Program.Power("2", "3"));
        Assert.AreEqual(5, Program.Power("5", "1"));
        Assert.AreEqual(25, Program.Power("5", "2"));
    }

    	[TestMethod]
    public void Invalid_Input_Martinez()
    {
        Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "5"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("1", "b"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("c", "3"));
        Assert.ThrowsException<FormatException>(() => Program.Power("d", "2"));
    }

    	[TestMethod]
    public void Null_Input_Martinez()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "5"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "3"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power("2", null));
    }
}
