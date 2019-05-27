using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1.Classes
{
    public class Cinema
    {
        public string Name { get; set; }

        public List<int> Halls { get; set; }

        public List<Movie> ListOfMovies { get; set; }

        public Cinema(string name)
        //,int[] halls,Movie[] movies
        {
            name = Name;
           // Halls = halls;
            //ListOfMovies = movies;
        }

        public void MoviePlaying(Movie movi)
        {
            Console.WriteLine($"Watching {movi.Title}");
        }
    }
}
