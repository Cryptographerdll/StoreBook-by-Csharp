using System.Collections.Generic; 
using System;

namespace ArrLisTabDic.cs
{
    class Program
    {
       // static bool isShopping = true;
        static void Main(string[] args)
        {
            bool isShopping = true;
            List<Book> myBooks = new List<Book>();

            while (isShopping)
            {
                Book purchasedbook = new Book();

                Console.WriteLine("Welcome to the book store sir ! what book you would like to buy ");
                purchasedbook.Title = Console.ReadLine();

                Console.Write("enter the book price in $\n");
                purchasedbook.Price = Convert.ToDouble(Console.ReadLine());

                myBooks.Add(purchasedbook);

                Console.WriteLine("DO you want to remove a book ?");
                var removeBook = Console.ReadLine();

                if (removeBook == "yes")
                {
                    Console.WriteLine("What book you would like to remove");
                    var bookToRemoved = Console.ReadLine();

                    Book actualBook = new Book();

                    foreach(var TobeRemoved in myBooks)
                    {
                        if (TobeRemoved.Title.Contains(bookToRemoved))
                        {
                            actualBook = TobeRemoved;
                        }
                        else
                        {
                            Console.Write("Looks there is no book with that name sir please check again ");
                        }
                    }
                    myBooks.Remove(actualBook);

                }               

                Console.WriteLine("Do you want to keep shopping ?");
                var choice = Console.ReadLine();

                if(choice == "no")
                {
                    var total = 0.00;

                    isShopping = false;
                    foreach(var book in myBooks)
                    {
                        Console.Write("Your book : \t"+"\n" + book.Title + "\n");
                        total += book.Price;
                    }
                    Console.Write($"your total is\n ${total}");
                }
            }
            
            Console.ReadKey();
        }
    }
    class Book
    {
        public string Title { get; set; }
        public double Price { get; set; }
    }

}
