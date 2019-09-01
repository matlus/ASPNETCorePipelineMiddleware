using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.DomainLayer
{
    public class DomainFacade
    {
        public IEnumerable<Movie> GetAllMovies()
        {
            return GetInMemoryMovies();
        }

        public IEnumerable<Movie> GetMoviesByGenre(Genre genre)
        {
            return GetInMemoryMovies().Where(m => m.Genre == genre);
        }

        private static IEnumerable<Movie> GetInMemoryMovies()
        {
            yield return new Movie("Star Wars Episode IV: A New Hope", Genre.SciFi, 1977, "StarWarsEpisodeIV.jpg");
            yield return new Movie("Star Wars Episode V: The Empire Strikes Back", Genre.SciFi, 1980, "StarWarsEpisodeV.jpg");
            yield return new Movie("Star Wars Episode VI: Return of the Jedi", Genre.SciFi, 1983, "StarWarsEpisodeVI.jpg");
            yield return new Movie("Star Wars: Episode I: The Phantom Menace", Genre.SciFi, 1999, "StarWarsEpisodeI.jpg");
            yield return new Movie("Star Wars Episode II: Attack of the Clones", Genre.SciFi, 2002, "StarWarsEpisodeII.jpg");
            yield return new Movie("Star Wars: Episode III: Revenge of the Sith", Genre.SciFi, 2005, "StarWarsEpisodeIII.jpg");
            yield return new Movie("Olympus Has Fallen", Genre.Action, 2013, "Olympus_Has_Fallen_poster.jpg");
            yield return new Movie("G.I. Joe: Retaliation", Genre.Action, 2013, "GIJoeRetaliation.jpg");
            yield return new Movie("Jack the Giant Slayer", Genre.Action, 2013, "jackgiantslayer4.jpg");
            yield return new Movie("Drive", Genre.Action, 2011, "FileDrive2011Poster.jpg");
            yield return new Movie("Sherlock Holmes", Genre.Action, 2009, "FileSherlock_Holmes2Poster.jpg");
            yield return new Movie("The Girl with the Dragon Tatoo", Genre.Drama, 2011, "FileThe_Girl_with_the_Dragon_Tattoo_Poster.jpg");
            yield return new Movie("Saving Private Ryan", Genre.Action, 1998, "SavingPrivateRyan.jpg");
            yield return new Movie("Schindlers List", Genre.Drama, 1993, "SchindlersList.jpg");
            yield return new Movie("Good Will Hunting", Genre.Drama, 1997, "FileGood_Will_Hunting_theatrical_poster.jpg");
            yield return new Movie("Citizen Kane", Genre.Drama, 1941, "Citizenkane.jpg");
            yield return new Movie("Shawshank Redemption", Genre.Drama, 1994, "FileShawshankRedemption.jpg");
            yield return new Movie("Forest Gump", Genre.Drama, 1994, "ForrestGump.jpg");
            yield return new Movie("We Bought a Zoo", Genre.Drama, 2011, "FileWe_Bought_a_Zoo_Poster.jpg");
            yield return new Movie("A Beautiful Mind", Genre.Drama, 2001, "FileAbeautifulmindposter.jpg");
            yield return new Movie("Avatar", Genre.SciFi, 2009, "Avatar.jpg");
            yield return new Movie("Iron Man", Genre.SciFi, 2008, "IronMan.jpg");
            yield return new Movie("Terminator 2", Genre.SciFi, 1991, "Terminator2.jpg");
            yield return new Movie("The Dark Knight", Genre.SciFi, 2001, "TheDarkKnight.jpg");
            yield return new Movie("The Matrix", Genre.SciFi, 1999, "TheMatrix.jpg");
            yield return new Movie("Transformers", Genre.SciFi, 2007, "Transformers.jpg");
            yield return new Movie("Revenge Of The Fallen", Genre.SciFi, 2009, "TransformersRevengeOfTheFallen.jpg");
            yield return new Movie("The Dark of the Moon", Genre.SciFi, 2011, "TransformersTheDarkoftheMoon.jpg");
            yield return new Movie("X-Men First Class", Genre.SciFi, 2011, "XMenFirstClass.jpg");
            yield return new Movie("Snitch", Genre.Thriller, 2013, "Snitch.jpg");
            yield return new Movie("Life Of Pi", Genre.Drama, 2012, "LifeOfPi.jpg");
            yield return new Movie("The Call", Genre.Thriller, 2013, "TheCall.jpg");
            yield return new Movie("Wake in Fright", Genre.Thriller, 1971, "WakeInFright.jpg");
            yield return new Movie("Les Miserables", Genre.Musical, 2012, "LesMiserables.jpg");
            yield return new Movie("Footloose", Genre.Musical, 2011, "Footloose.jpg");
            yield return new Movie("The Croods", Genre.Animation, 2013, "TheCroods.jpg");
            yield return new Movie("Oblivion", Genre.SciFi, 2013, "Oblivion.jpg");
        }
    }
}
