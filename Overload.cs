/*
Function overloading to add two number and add two strings
*/

using System;

class Overload
{
	public String add(String left, String right)
	{
		return left + right;
	}
	public int add(int first, int second)
	{
		return first + second;
	}
	static void Main(String[] args)
	{
		Overload overload = new Overload();
		Console.WriteLine("67 + 45 :" + overload.add(67, 45));
		Console.WriteLine("'CS' + 'IT' :" + overload.add("CS", "IT"));
	}
}