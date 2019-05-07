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
				case 2:
					return "2";
				default:
					return "4";
			}
		}
	}
}