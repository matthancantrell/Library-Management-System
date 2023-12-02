using System;
namespace Author_and_Book_Management_System
{
    public class Author
    {
        private string authorName;
        private int birthYear;
        private string nationality;
        //private List<Book> books = new List<Book>();
        private Book[] books = new Book[4];
        int i;


        //public Author()
        //{

        //}
        public Author(string authorName, int birthYear, string nationality)
        {
            this.authorName = authorName;
            this.birthYear = birthYear;
            this.nationality = nationality;
        }

        public string getAuthorName() => authorName;

        public int getAuthorBirthYear() => birthYear;

        public string AuthorNationality() => nationality;
        
            


        public string displayAuthorInfo()=> $"Author Information: \n" +
                                            $"Name: {this.authorName}\n" +
                                            $"Birth Year: {this.birthYear}\n" +
                                            $"Nationality: {this.nationality}";


        //-------------------------------------
        public void AddBook(string Btitle, int BpublicationYear, string Bgenre)
        {
           for ( i = 0; i <books.Count() ; i++)
            {
                if (i==0 || i <= books.Count())
                {
                    books[i]= new Book(Btitle, BpublicationYear, Bgenre);
                }
                else
                {
                    Console.WriteLine($"You can't add more books for{this.authorName} now.");
                }
            }
        }

        //public void AddBook(Book book)
        //{
        //    books.Add(book);
        //}


         public void DisplayAuthorBooks()
         {
             for (int i = 0; i < books.Length; i++)
             {
                books[i].displayBookInfo();
                //return $"Displaying Books for J.K. Rowling: \n" +
                //    $"{books[i].displayBookInfo}";
             }
         }


    }

}

