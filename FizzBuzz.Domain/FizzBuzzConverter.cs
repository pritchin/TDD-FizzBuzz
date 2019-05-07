namespace FizzBuzz.Domain
{
	public class FizzBuzzConverter
	{
		public string Convert(int number)
		{
			if (number % 3 == 0)
			{
				return "Fizz";
			}

			return number.ToString();
		}
	}
}