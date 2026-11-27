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

            //Book book = new Book();
            //object objt = book;
            //Console.WriteLine(objt);
            #endregion

            #region Question 2
            //Q02.  Using the Book class above, print the result of calling ToString(), Equals() (compare book with
            //itself), GetHashCode(), and GetType() on book.
            //Console.WriteLine(objt.ToString());
            //Console.WriteLine(objt.Equals("    "));
            //Console.WriteLine(objt.GetHashCode());
            //Console.WriteLine(objt.GetType());
            #endregion

            #region Question 3
            //Q03.  Look at the line below. Is it a compile-time error, a runtime error, or a logical error? Fix it.
            // int pages = "464";
            //solution:
            //compile_time error
            //string pages = Console.ReadLine();
            //bool b = int.TryParse(pages, out int x);
            //Console.WriteLine(b);
            //Console.WriteLine(x);

            #endregion

            #region Question 4
            //            Q04.Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by
            //zero", and then prints "Done" in a finally block.

            //try
            //{
            //    int x = 10, y = 0;
            //    int d = x / y;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Cannot divide by zero");

            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}

            #endregion


            #region Question 5
            //Q05.Declare an int pages = 300; then store it in a double variable without using a cast.
            //int pages = 300;
            //double pagesdouble = pages;
            //Console.WriteLine(pagesdouble);
            #endregion


            #region Question 6
            // Q06.  Declare a double price = 49.99; then convert it into an int using a cast.
            //double price = 49.99;
            //Console.WriteLine((int)price);

            #endregion


            #region Question 7
            // Q07.  Given string pagesText = "464";, convert it into an int using the Convert class.
            //string pagestext = "464";

            //Console.WriteLine(Convert.ToInt32(pagestext));

            #endregion

            #region Question 8
            // Q08.  Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";,
            // use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
            string yearText = "2023";
            int f = int.Parse(yearText);
            Console.WriteLine(f);

            string badText = "abc";
            bool b = int.TryParse(badText, out int x);
            if (b)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine("Invalid number");
            }

            #endregion
        }
    }
}
