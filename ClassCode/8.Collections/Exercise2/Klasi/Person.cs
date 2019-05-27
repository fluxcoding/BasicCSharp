using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2.Klasi
{
    class Person
    {
        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public Genre FavoriteMusicType { get; set; }

        public List<Song> FavoriteSongs { get; set; }

        // Static ne pisuvame vo klasite

        // samo vo program.cs


        public void GetFavSongs()
        {

        }


    }
}
