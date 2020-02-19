using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sputify.Models
{
    public class DbInitializer
    {
        //this class is for seeding testdata to Db for testing purposes - rid for production
        public static void Initialize(SputifyContext context)
        {
            context.Database.EnsureCreated();

            if (context.Songs.Any())
            {
                return;
            }
            var albums = new Album[]
            {
                 new Album{AlbumTitle ="Harvest"},
                 new Album{AlbumTitle="Conversation Pieces"}
            };
            foreach (Album a in albums)
            {
                context.Add(a);
            }
            context.SaveChanges();

            var songs = new Song[]
           {
                 new Song{SongName="Out on the weekend", SongPath="C:\\music\\Out on the weekend.mp3", TrackNumber=1 },
                 new Song{SongName="Harvest", SongPath="C:\\music\\Harvest.mp3", TrackNumber=2 },
                 new Song{SongName="A man needs a maid", SongPath="C:\\music\\A man needs a maid.mp3", TrackNumber=3 },
                 new Song{SongName="You'll never be lonely again", SongPath="C:\\music\\Ull never be lonely again 360.mp3", TrackNumber=1 }
           };
            foreach (Song b in songs)
            {
                context.Add(b);
            }
            context.SaveChanges();

            var playlists = new Playlist[]
           {
                 new Playlist{PlaylistName="default playlist"},
                 new Playlist{PlaylistName="favorites"}
           };
            foreach (Playlist c in playlists)
            {
                context.Add(c);
            }
            context.SaveChanges();


            var collections = new Collection[]
           {
                 new Collection{ PlayOrder=1},
                 new Collection{ PlayOrder=3},
                 new Collection{ PlayOrder=1},
                 new Collection{ PlayOrder=2},
                 new Collection{ PlayOrder=2},
                 new Collection{ PlayOrder=3}
           };
            foreach (Collection d in collections)
            {
                context.Add(d);
            }
            context.SaveChanges();



        }
    }
}
