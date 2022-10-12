﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Devs2Blu.ProjetosAula.AgendaDeContatos.Data
{
    public class ConnectionMySQL
    {
        public static String ConnectionString { get; set; }
        public static String Server { get; set; }
        public static String DataBase { get; set; }
        public static String User { get; set; }
        public static String Password { get; set; }

        public static MySqlConnection GetConnection()
        {
            try
            {
                Server = "localhost";
                DataBase = "agendadecontatos";
                User = "root";
                Password = "root";

                ConnectionString = $"Persist Security Info=False;server={Server};" +
                    $"database={DataBase};uid={User};server={Server};database={DataBase};" +
                    $"uid={User};pwd='{Password}'";

                MySqlConnection conn = new MySqlConnection(ConnectionString);
                conn.Open();
                return conn;

            }
            catch (MySqlException myEx)
            {
                MessageBox.Show(myEx.Message, "Erro ao conectar ao banco",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
