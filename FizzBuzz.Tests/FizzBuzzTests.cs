using NUnit.Framework;

namespace Tests
{
	public class FizzBuzzTests
	{
		[Test]
		public void Convert_1_to_1()
		{
			var number = 1;
			var converter = new FizzBuzzConverter();

			var convertedNumber = converter.Convert(number);
			
			Assert.AreEqual("1", convertedNumber);
		}

		[Test]
		public void Convert_2_to_2()
		{
			var number = 2;
			var converter = new FizzBuzzConverter();

			var convertedNumber = converter.Convert(number);
			
			Assert.AreEqual("2", convertedNumber);
		}
	}
}