/*
Example of Book class. Implementation of class
*/

using System;

class Book
{
	public int bookId;
	public String bookName;
	public String authorName;
	public float price;

	public Book()
	{
		bookId = -1;
		bookName = "";
		authorName = "";
		price = 0.0f;
	}
}

class BookMain
{
	static void Main(String[] args)
	{
		Book book = new Book();
		book.bookId = 2345;
		book.bookName = "The wings of fire";
		book.authorName = "A.P.J. Abdul Kalam";
		book.price = 450.0f;

		Console.WriteLine("Book Details");
		Console.WriteLine("******************");
		Console.WriteLine("Book ID: " + book.bookId);
		Console.WriteLine("Book name: " + book.bookName);
		Console.WriteLine("Author name: " + book.authorName);
		Console.WriteLine("Price: Rs." + book.price);
	}
}