using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




/*
 * 
            Song holiday = new Song("Holiday", "Green day", 200);
            Song kashmir = new Song("Kashmir", "Led zeppelin", 150);





            Console.WriteLine(Song.songCount);
            Console.WriteLine(kashmir.artist);
 * */
namespace Giraffe
{
    internal class Song
    {

        public string title;
        public string artist;
        public int duration;
        public static int songCount = 0;


        public Song(string aTitle, string aArtist, int aDuration)
        {
        
            title = aTitle;
            artist = aArtist;
            duration = aDuration;

            songCount++;

        }
    
            public int getSongCount()
        {

            return songCount;
        }
    
    }
}
