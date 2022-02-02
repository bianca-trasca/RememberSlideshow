using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Remember
{
    public partial class mainForm : Form
    {
        SqliteConnection Conn = new SqliteConnection();

        public mainForm(SqliteConnection connection)
        {
            Conn = connection;
            InitializeComponent();
        }

        SqliteCommand cmd = new SqliteCommand();


    }
}
