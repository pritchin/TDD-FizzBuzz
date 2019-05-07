using FizzBuzz.Domain;
using NUnit.Framework;

namespace FizzBuzzTests
{
	public class FizzBuzzTests
	{
		[Test]
		public void Convert_1_to_1()
		{
			Assert.AreEqual("1", ToFizzBuzz(1));
		}

		[Test]
		public void Convert_2_to_2()
		{
			Assert.AreEqual("2", ToFizzBuzz(2));
		}

		[Test]
		public void Convert_4_to_4()
		{
			Assert.AreEqual("4", ToFizzBuzz(4));
		}

		private static string ToFizzBuzz(int number)
		{
			var converter = new FizzBuzzConverter();

			var convertedNumber = converter.Convert(number);
			return convertedNumber;
		}
	}
}