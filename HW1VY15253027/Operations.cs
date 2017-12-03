using System;
namespace HW1VY15253027
{
    public class Operations<T>
    {
       
		public  string InnerTrim(string input)
		{
			return input.Trim().Replace(" ", string.Empty);
		}

		public string InnerTrim2(string input)
		{
			return input.Trim().Replace(",", string.Empty);
		}

		public string InnerTrim3(string input)
		{
			return input.Trim().Replace(".", string.Empty);
		}
	}
}
