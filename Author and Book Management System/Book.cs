using System;
namespace Author_and_Book_Management_System
{
	public class Book
	{

		public string title;
		public int publicationYear;
		public string genre;

		//public Book()
		//{

		//}
		public Book(string title, int publicationYear, string genre)
		{
			this.title = title;
			this.publicationYear = publicationYear;
			this.genre = genre;
		}

        public string displayBookInfo() => $"Books Authored by J.K. Rowling: \n" +
											$"Book Tital: {this.title}\n" +
                                            $"Book publication Year: {this.publicationYear}\n" +
                                            $"Book genre: {this.genre}";


		//public string displayAuthorBooks()
		//{
  //          displayBookInfo();

  //      }
    }
	
}

