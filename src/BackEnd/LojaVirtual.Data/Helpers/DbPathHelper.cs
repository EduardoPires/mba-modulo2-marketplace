﻿namespace LojaVirtual.Data.Helpers
{
    public static class DbPathHelper
    {
        public static string GetDatabasePath()
        {
            var absolutePath = Path.GetFullPath(Path.Combine("..", "LojaVirtual.Data", "Database", "loja.db"));
            Directory.CreateDirectory(Path.GetDirectoryName(absolutePath)!);
            return absolutePath;
        }
    }
}
