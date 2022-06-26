using Microsoft.Data.Sqlite;
using System;
using System.Configuration;
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
            using(SqliteConnection conn = new SqliteConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString))
            {
                Application.Run(new MainForm(conn));
            }
        }
    }
}