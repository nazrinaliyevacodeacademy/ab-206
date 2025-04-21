using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Music.Exceptions;
using Music.Models;

namespace Music.Services;

public class SongService
{
    private static int _counter = 1;
    private static List<Song> _songs { get;  } = new List<Song>();
    #region Create
    public void AddMusic(Song song)
    {
        song.Id = _counter;
        _counter++;
        _songs.Add(song);
        Console.WriteLine("Musiqi elave olundu ");
    }
    #endregion

   
    public Song GetSongById(int id ) 
    {
        foreach (Song song in _songs) 
        {
            if(song.Id == id) 
                return song;  
        }
        throw new SongException($"{id} id-e sahib mahni tapilmadi");
    }

    public void UpdateSong(int id,Song updatedSong)
    {

        foreach (Song song in _songs)
        {
            if (song.Id == id)
              song.Id = updatedSong.Id;
            song.SongName = updatedSong.SongName;
            song.ArtistName = updatedSong.ArtistName;
            song.Genre = updatedSong.Genre;
            song.Duration = updatedSong.Duration;
            return;
        }
        throw new PlaylistException($"{id} id-e sahib playlist tapilmadi.Bu sebeden update olunmadi");
    
    }

    public void DeleteSong(int id)
    {
        foreach(Song song in _songs)
        {
            if(song.Id==id)
                _songs.Remove(song);
            Console.WriteLine($"Verilmis{id} data silindi");
            return;
        }
        throw new SongException($"{id} id-e sahib mahni tapilmadi");
    }
    public List<Song> GetAllSongs()
    {
        return _songs ;
    }
  
}
