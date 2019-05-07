using FizzBuzz.Domain;
using NUnit.Framework;

namespace FizzBuzzTests
{
	public class FizzBuzzTests
	{
		[Test]
		public void Convert_1_to_1()
		{
			var convertedNumber = ToFizzBuzz(1);

			Assert.AreEqual("1", convertedNumber);
		}

		[Test]
		public void Convert_2_to_2()
		{
			var convertedNumber = ToFizzBuzz(2);
			
			Assert.AreEqual("2", convertedNumber);
		}

		private static string ToFizzBuzz(int number)
		{
			var converter = new FizzBuzzConverter();

			var convertedNumber = converter.Convert(number);
			return convertedNumber;
		}
	}
}