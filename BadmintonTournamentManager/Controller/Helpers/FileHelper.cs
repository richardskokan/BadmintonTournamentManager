namespace BadmintonTournamentManager.Controller.Helpers
{
    public static class FileHelper
    {
        public static async void WriteToFileAsync(string path, string text)
        {
            CreateFileIfNotExist(path);

            using (StreamWriter writer = new StreamWriter(path))
            {
                await writer.WriteAsync(text);
                writer.Flush();
            }
        }

        public static async Task<string> ReadFromFileAsync(string path)
        {
            if (!File.Exists(path))
                return "";

            using (StreamReader reader = new StreamReader(path))
            {
                return await reader.ReadToEndAsync();
            }
        }

        public static void CreateFileIfNotExist(string path)
        {
            if (!File.Exists(path))
                Directory.CreateDirectory(Path.GetDirectoryName(path)!);
                File.Create(path).Dispose();
        }

        public static void CreateNewFile(string path)
        {
            if (File.Exists(path))
                File.Delete(path);

            Directory.CreateDirectory(Path.GetDirectoryName(path)!);
            File.Create(path).Dispose();
        }
    }
}
