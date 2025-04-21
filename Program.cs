
using Music.Exceptions;
using Music.Models;
using Music.Services;

public class Program
{
    static void Main(string[] args)
    {
        PlaylistService playlistService = new PlaylistService();
        Playlist playlist = new Playlist()
        {
            PlaylistName = "Teatr"
        };

        playlistService.AddPlaylist(playlist);
        /*  try
          {
              Playlist playlistById = playlistService.GetPlaylistById(89);
          }
          catch (PlaylistException ex)
          {
              Console.WriteLine("Bu bir Playlist Exceptionidir. Zehmet olmasa playlistle bagli tedbir gorulsun");
              Console.WriteLine(ex.Message);
          }
          catch (Exception ex)
          {
              Console.WriteLine($"problem:{ex.Message}");
          }*/
        /* Datanin ekrana cixarilmasi
         foreach (Playlist p in playlistService.GetAllPlaylists())
         {
             Console.WriteLine($"Id:{p.Id}\nName:{p.PlaylistName}");
         }*/
        SongService songService = new SongService();
        Song song = new Song();
        {
            //ArtistName = "Test Testov "

        };
        songService.AddMusic(song);
       /* try
        {
            Song songById = songService.GetSongById(23);
        }
        catch (SongException ex)
        {
            Console.WriteLine("Bu bir Song Exceptionidir.Zehmet olmasa songla bagli tedbir gorulsun");
            Console.WriteLine($"Problem:{ex.Message}");
        }
        catch ( Exception ex)
        {
            Console.WriteLine(ex.Message);
        }*/
        while (true)
        {
            Console.WriteLine("\n1. Mahnı Əməliyyatları");
            Console.WriteLine("2. Playlist Əməliyyatları");
            Console.WriteLine("0. Çıxış");
            Console.Write("Seçiminizi daxil edin: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":

                    break;
                case "2":

                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Yanlış seçim!");
                    break;
            }
        }
    }
}

