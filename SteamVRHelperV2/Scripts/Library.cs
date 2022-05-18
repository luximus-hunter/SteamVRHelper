using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SteamVRHelper
{
    internal class Library
    {
        private List<Game> games;

        public Library()
        {
            games = new List<Game>();

            List<string> unsortedGames = Directory.GetDirectories(Locations.SteamGames).ToList();

            foreach (string unsortedGame in unsortedGames)
            {
                Game game = new Game();

                game.Name = unsortedGame.Split(@"\").Last();

                foreach (string openvrPath in Directory.EnumerateFiles(unsortedGame, Locations.OpenvrDllFileName, SearchOption.AllDirectories))
                {
                    List<string> pathSegments = openvrPath.Split(@"\").ToList();
                    pathSegments.Remove(Locations.OpenvrDllFileName);
                    string path = string.Join(@"\", pathSegments);

                    game.Paths.Add(path);
                }

                if (game.Paths.Count > 0)
                {
                    games.Add(game);
                }
            }
        }

        #region Getters and Setters

        public List<Game> Games
        {
            get => games;
            set => games = value;
        }

        #endregion
    }

    internal class Game
    {
        private string name;
        private List<string> paths;

        public Game()
        {
            name = "Untitled Game";
            paths = new();
        }

        #region Getters and Setters

        public string Name
        {
            get => name;
            set => name = value;
        }

        public List<string> Paths
        {
            get => paths;
            set => paths = value;
        }

        #endregion
    }
}
