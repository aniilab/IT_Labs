import { Resolver, Query, Mutation, Arg } from 'type-graphql';
import { Artist } from '../models/Artist';
import { Song } from '../models/Song';
import { lana, maneskin, weeknd } from '../fixtures/artists';
import { song1, song2, song3, song4 } from '../fixtures/songs';

const artists: Artist[] = [weeknd, lana, maneskin];

const songs: Song[] = [song1, song2, song3, song4];

lana.songs.push(song3);
weeknd.songs.push(song1, song2);
maneskin.songs.push(song4);

@Resolver()
export class SongResolver {
  @Query(() => [Song])

  async viewArtistSongs(@Arg("authorId") authorId: string): Promise<Song[]> {

    const artist = artists.find((a) => a.id === authorId);

    if (!artist) {
      throw new Error('Artist not found');
    }

    const artistSongs = songs.filter((song) =>
      song.author === artist
    );

    return artistSongs;
  }
  @Query(() => [Song])
  async viewSongs(): Promise<Song[]> {
      return songs;
  }
  @Query(() => [Artist])
  async viewArtists(): Promise<Artist[]> {
    return artists;
  }
  @Query(() => [Artist])
  async viewArtist(@Arg("artistId") artistId: string): Promise<Artist> {
    const artist = artists.find((a) => a.id === artistId);

    if (!artist) {
      throw new Error('Artist not found');
    }

    return artist;
  }
  
  @Mutation(() => Song)
  async createSong(@Arg("songId") songId: string, @Arg("title")  title: string, @Arg("year") year: number, @Arg("duration") duration: number, @Arg("artistId") artistId: string): Promise<Song> {
    let artist =  artists.find((a) => a.id == artistId);
    if (!artist) {
      throw new Error('Artist not found');
    }
    
    const newSong = new Song(title, songId, year, duration, artist);
    artist.songs.push(newSong);
    songs.push(newSong);
    return newSong;
  }
  @Mutation(() => Song)
  async createArtist(@Arg("artistId") artistId: string, @Arg("fullName")  fullName: string, @Arg("pseudoName") pseudoName: string, @Arg("contry") country: string): Promise<Artist> {   
    const newArtist = new Artist(fullName, pseudoName, artistId, country);
    artists.push(newArtist);
    return newArtist;
  }
}