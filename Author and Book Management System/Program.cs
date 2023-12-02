namespace Author_and_Book_Management_System;
class Program
{
    static void Main(string[] args)
    {
        Author author1 = new Author("J.K. Rowling", 1965, "British");
        //Author author2 = new Author("Sabrin ", 1995, "Omani");
        Console.WriteLine("Welcome to the Author and Book Management System!");

        Console.WriteLine(author1.displayAuthorInfo());
        Console.WriteLine();
        //----------------------------------------------------
        int x = 1 , PublicationYear;
        string BookTitle, sPublicationYear, BookGenre;
        do
        {
            Console.WriteLine("Enter Book Title:");
             BookTitle = Console.ReadLine();
            Console.WriteLine("Enter Publication Year:");
            do
            {
                sPublicationYear = Console.ReadLine();

            } while (!int.TryParse(sPublicationYear, out PublicationYear));

            Console.WriteLine("Enter Genre:");
             BookGenre = Console.ReadLine();
            //Book _book = new Book
            author1.AddBook(BookTitle, PublicationYear, BookGenre);
            Console.WriteLine();
            x++;
        } while (x <= 4);
       
        

        Console.WriteLine($"Displaying Books for J.K. Rowling: \n {author1.DisplayAuthorBooks}.");
       // Console.WriteLine(author1.DisplayAuthorBooks());


    }
}

