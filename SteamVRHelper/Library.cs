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

                game.Name = unsortedGame.Split(@"\")[unsortedGame.Split(@"\").Length - 1];

                string unityPath = Path.Combine(unsortedGame, game.Name + "_Data", @"Plugins\x86_64");
                string unrealPath = Path.Combine(unsortedGame, @"Engine\Binaries\ThirdParty\OpenVR\OpenVRvX_Y_Z");

                bool isUnity = File.Exists(Path.Combine(unityPath, Locations.OpenvrDllFileName));
                bool isUnreal = File.Exists(Path.Combine(unrealPath, Locations.OpenvrDllFileName));

                bool isOpenvr = File.Exists(Path.Combine(unityPath, Locations.OpenvrDllFileName)) ||
                              File.Exists(Path.Combine(unrealPath, Locations.OpenvrDllFileName));

                if (isUnity)
                {
                    game.Path = unityPath;
                    game.Scaleable = true;
                }
                else if (isUnreal)
                {
                    game.Path = unrealPath;
                    game.Scaleable = true;
                }

                if (game.Scaleable)
                {
                    games.Add(game);
                }
            }
        }

        public void ToggleScale(Game game)
        {
            int index = games.IndexOf(game);

            if (index < 0)
            {
                return;
            }

            game.Scaled = !game.Scaled;

            games[index] = game;
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
        private string path;
        private bool scaleable;
        private bool scaled;

        #region Getters and Setters

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Path
        {
            get => path;
            set => path = value;
        }

        public bool Scaleable
        {
            get => scaleable;
            set => scaleable = value;
        }

        public bool Scaled
        {
            get => scaled;
            set => scaled = value;
        }

        #endregion
    }
}
