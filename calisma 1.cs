


using System;


class GFG
{

	
	static bool isPowerOfTwo(int n)
	{

		if (n == 0)
			return false;

		return (int)(Math.Ceiling((Math.Log(n) /
								Math.Log(2)))) ==
			(int)(Math.Floor(((Math.Log(n) /
								Math.Log(2)))));
	}


	public static void Main()
	{
		if (isPowerOfTwo(51))
			Console.WriteLine("Yes");
		else
			Console.WriteLine("No");

		if (isPowerOfTwo(16))
			Console.WriteLine("Yes");
		else
			Console.WriteLine("No");
	}
}


