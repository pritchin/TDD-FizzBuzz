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
	}

	public class FizzBuzzConverter
	{
		public string Convert(int number)
		{
			return "1";
		}
	}
}