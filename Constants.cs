using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Storage;

namespace TaskManager
{
    //establishing contrants for the database
    public class Constants  // put as public instead of internal for class access
    {
        public const string DBFilename = "TodoCapstoneData.db3";

        public const SQLite.SQLiteOpenFlags trigger =
            // when the database is opened, it will open is read/write mode 
            SQLite.SQLiteOpenFlags.ReadWrite |
            // if the database doesn't exists, this allows the database to be created
            SQLite.SQLiteOpenFlags.Create |
            // allow database access to  multi-threads
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string DBPath =>
            Path.Combine(FileSystem.AppDataDirectory, DBFilename);
    }
}

