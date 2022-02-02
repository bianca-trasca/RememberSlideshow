﻿using Microsoft.Data.Sqlite;
using System;
using System.Windows.Forms;

namespace Remember
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string pathToDB = @"C:\Users\byanc\OneDrive\Desktop\Licenta\Repos\RememberSlideShow\Remember\bin\Debug\usersDataBase.db";
            string dataSource = @"Data Source=" + pathToDB;
            SqliteConnection conn = new SqliteConnection(dataSource);

            ApplicationConfiguration.Initialize();
            Application.Run(new mainForm(conn));
        }
    }
}