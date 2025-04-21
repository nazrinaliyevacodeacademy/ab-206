using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Music.Exceptions;
using Music.Models;

namespace Music.Services;

public class PlaylistService
{
    private static int _counter=1;
    private static List<Playlist>_playlists {  get;  } = new List<Playlist>();
    #region Create
    public void AddPlaylist(Playlist playlist)
    {
        playlist.Id = _counter;
        _counter++; 
       _playlists.Add(playlist);
        Console.WriteLine("Playliste elave olundu ");
    }
    #endregion

   

    public Playlist GetPlaylistById(int id)
    {
        foreach(Playlist playlist in _playlists )
        {
            if (playlist.Id == id)
                return playlist; 
        }
        throw new PlaylistException($"{id} id-e sahib playlist tapilmadi");
    }
    public void UpdatePlaylist(int id,Playlist updatedPlaylist)
    {
        foreach (Playlist playlist in _playlists)
        {
           if (playlist.Id == id)
           playlist.Id=updatedPlaylist.Id;
           playlist.PlaylistName = updatedPlaylist.PlaylistName;
           playlist.Songs=updatedPlaylist.Songs;
           return;
        }
        throw new PlaylistException($"{id} id-e sahib playlist tapilmadi.Bu sebeden update olunmadi");
    }

    public void DeletePlaylist(int id)
    {
        foreach (Playlist playlist in _playlists)
        {
            if (playlist.Id == id)
                _playlists.Remove(playlist);
            Console.WriteLine($"Verilmis{id} data silindi");
            return;
        }
        throw new SongException($"{id} id-e sahib mahni tapilmadi");
    }
    public List<Playlist> GetAllPlaylists() 
    { return _playlists;
    } 
    
  /*  public Playlist GetAllPlaylists()
    {
        return _playlists[0];
    }*/
}
