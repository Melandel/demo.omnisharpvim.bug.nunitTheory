using NUnit.Framework;

namespace demo.omnisharpvim.bug.nunitTheory
{
	public enum Color { Blue, White, Red } // Like NZ's flag
	public class Tests
	{

		[Theory]
		public void Test1(Color color)
		{
			Assert.That(new[] { "Blue", "White", "Red" }, Does.Contain(color.ToString()));
		}
	}
}
