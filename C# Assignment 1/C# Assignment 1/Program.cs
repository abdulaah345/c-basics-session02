using static System.Net.Mime.MediaTypeNames;

namespace C__Assignment_1
{
    public class Book
    {
      
        public string Title;
        public int Pages;
    }
    public class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Book book = new Book { Title = "Route", Pages = 652 };
            object obj = book;
            Console.WriteLine(obj);


            #endregion


            #region Q2

            Console.WriteLine(book.ToString());
            Console.WriteLine(book.Equals(book));
            Console.WriteLine(book.GetHashCode());
            Console.WriteLine(book.GetType());


            #endregion



            #region Q3

            //  int pages = "464";  //compile-time error 

            int pages = 464;   //Solve

            #endregion

            #region Q4

            try
            {
                int z = 10;
                int y = 0;
                Console.WriteLine(z / y);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");

            }
            finally
            {
                Console.WriteLine("Done");
            }






            #endregion


            #region Q5

            int page = 300;
            double x = page; //implicit


            #endregion


            #region Q6

            double price = 49.99;
            int v = (int)price;
            #endregion

            #region Q7

            string pagesText = "464";
            int d = Convert.ToInt32(pagesText);

            #endregion

            #region Q8

            string yearText = "2023";
            int year = int.Parse(yearText);

            string Text = "abc";
            if(!int.TryParse(Text, out d))
                Console.WriteLine("invalid number");

            #endregion


            #region Q9

            int t = 464;
            string s= t.ToString();
            Console.WriteLine(s);

            #endregion

            #region Q10

            int copies = 100;
            object boxed = copies;

            int unboxed=(int)boxed;

            Console.WriteLine(boxed);
            Console.WriteLine(unboxed);



            #endregion

        }
    }
}
