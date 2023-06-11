using BadmintonTournamentManager.Controller.Helpers;
using BadmintonTournamentManager.Model.Common;
using BadmintonTournamentManager.Model.Exceptions;
using BadmintonTournamentManager.Model.Objects;
using System.IO;
using System.Text.Json;

namespace BadmintonTournamentManager.Controller.Filesystem
{
    public class DBContext
    {
        public DBContext() { }

        public async Task<HashSet<T>> LoadData<T>(string path) where T : ISaveable
        {
            if (!File.Exists(path))
                return new();

            var data = await FileHelper.ReadFromFileAsync(path);

            if (data == null)
                return new();

            var loadedData = JsonSerializer.Deserialize<HashSet<T>>(data);

            if (loadedData == null)
                throw new AppDataLoadException("Failed to load data");
            return loadedData;
        }

        public void SaveData<T>(IEnumerable<T> data) where T : ISaveable
        {
            switch (data)
            {
                case IEnumerable<Player>:
                    SaveData(Paths.PlayerFile, data);
                    break;
                case IEnumerable<Match>:
                    SaveData(Paths.MatchFile, data);
                    break;
                case IEnumerable<Tournament>:
                    SaveData(Paths.TournamentFile, data);
                    break;
                default:
                    throw new AppInvalidDataException("Can not save this type of data");
            }

        }

        private void SaveData<T>(string path, IEnumerable<T> data)
        {
            FileHelper.CreateNewFile(path);

            string result = JsonSerializer.Serialize(data);

            FileHelper.WriteToFileAsync(path, result);
        }

        public void SaveUsers(Dictionary<string, byte[]> data)
        {
            FileHelper.CreateNewFile(Paths.UserFile);

            string result = JsonSerializer.Serialize(data);

            FileHelper.WriteToFileAsync(Paths.UserFile, result);
        }

        public async Task<Dictionary<string, byte[]>> LoadUsers()
        {
            if (!File.Exists(Paths.UserFile))
                return new();

            var data = await FileHelper.ReadFromFileAsync(Paths.UserFile);

            if (data == null)
                throw new AppDataLoadException("Failed to load user data");

            var users = JsonSerializer.Deserialize<Dictionary<string, byte[]>>(data);
            if (users == null)
                throw new AppDataLoadException("Failed to load user data");

            return users;
        }
    }
}
