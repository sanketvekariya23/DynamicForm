namespace Task.Provider
{
    public class ConfigProvider
    {
        public static string BaseDirectory => @"D:/Form";
        public static string BaseFolderName => "Form";
        public static void EnsureDirectoryExists()
        {
            if (!Directory.Exists(BaseDirectory))
            {
                Directory.CreateDirectory(BaseDirectory);
            }
        }
    }
}
