using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Classes
{
    public class Movie
    {
        public string Title { get; set; }

        public Genre Genre { get; set; }

        public int Rating { get; set; }

        public double TicketPrice { get; set; }

        public Movie(string title ,Genre genre,int rating,double ticketprice)
        {
            Title = title;
            Genre = genre;

            try
            {
                 if (rating > 5 || rating < 1)
                {
                    throw new Exception("The rating is invalid!");
                }

                Console.WriteLine("The rating is fine");

            }
            catch (FormatException isItInt)
            {
                Console.WriteLine($"The rating should be number!{isItInt.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"There was an error: {ex.Message}");
                
            }

            Rating = rating;
            TicketPrice = ticketprice;
           
        }
    }
}
