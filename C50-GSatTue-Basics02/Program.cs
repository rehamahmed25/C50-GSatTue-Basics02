namespace C50_GSatTue_Basics02
{
    class Book
    {
        string title;
        int pages;

    }

    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question1
            //Q01.  Create a Book class with a Title (string) and Pages (int). Create a Book object and store it in a
            // variable of type object.Print it.

            Book book = new Book();
            object objt = book;
            Console.WriteLine(objt);
            #endregion
        }
    }
}
