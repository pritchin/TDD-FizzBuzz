namespace FizzBuzz.Domain
{
	public class FizzBuzzConverter
	{
		public string Convert(int number)
		{
			switch (number)
			{
				case 1:
					return "1";
				default:
					return "2";
			}
		}
	}
}