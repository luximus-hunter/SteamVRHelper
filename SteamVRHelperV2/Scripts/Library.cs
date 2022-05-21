using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SteamVRHelperV2.Scripts
{
    public class Library
    {
        private List<Game> _g;

        public Library()
        {
            _g = new List<Game>();

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
                    _g.Add(game);
                }
            }
        }

        #region Getters and Setters

        public List<Game> Games
        {
            get => _g;
            set => _g = value;
        }

        #endregion
    }

    public class Game
    {
        private string _n;
        private List<string> _p;

        public Game()
        {
            _n = "Untitled Game";
            _p = new();
        }

        #region Getters and Setters

        public string Name
        {
            get => _n;
            set => _n = value;
        }

        public List<string> Paths
        {
            get => _p;
            set => _p = value;
        }

        #endregion
    }
}
