using System;
using System.Windows.Forms;
using Npgsql;

namespace DatabaseManager
{
    public partial class Conexiones : Form
    {
        public Conexiones()
        {
            InitializeComponent();
        }

        private void bCrear_Click(object sender, EventArgs e)
        {
            String username = tbUser.Text;
            String password = tbPassword.Text;
            using (var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=masterkey;Database=postgres"))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "CREATE DATABASE "+username;
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "CREATE USER " + username + " WITH ENCRYPTED PASSWORD '" +password+"'";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "GRANT ALL PRIVILEGES ON DATABASE "+username+" TO "+username;
                    cmd.ExecuteNonQuery();
                    Console.Write("Se creo el usuario exitosamente");
                    tbUser.Text = "";
                    tbPassword.Text = "";
                }
            }
        }

        private void bModify_Click(object sender, EventArgs e)
        {
            String username = tbUser.Text;
            String password = tbPassword.Text;
            using (var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=masterkey;Database=postgres"))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "ALTER USER "+username+" WITH PASSWORD '"+password+"'";
                    cmd.ExecuteNonQuery();
                    Console.Write("Se modifico el usuario exitosamente");
                    tbUser.Text = "";
                    tbPassword.Text = "";
                }
            }
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            String username = tbUser.Text;
            String password = tbPassword.Text;
            if (password.Equals(ConnectionManager.password)){
                using (var conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=masterkey;Database=postgres"))
                {
                    conn.Open();
                    using (var cmd = new NpgsqlCommand())
                    {
                        cmd.Connection = conn;
                        /*cmd.CommandText = "REVOKE ALL PRIVILEGES ON ALL TABLES IN SCHEMA public FROM " + username + ";";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "REVOKE ALL PRIVILEGES ON ALL SEQUENCES IN SCHEMA public FROM "+username+";";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "REVOKE ALL PRIVILEGES ON ALL FUNCTIONS IN SCHEMA public FROM "+username+";";
                        cmd.ExecuteNonQuery();
                        cmd.CommandText = "REVOKE ALL PRIVILEGES ON SCHEMA public FROM "+username+";";
                        cmd.ExecuteNonQuery();*/
                        cmd.CommandText = "DROP OWNED BY " + username;
                        cmd.ExecuteNonQuery();
                        //cmd.CommandText = "DROP DATABASE " + username;
                        //cmd.ExecuteNonQuery();
                        cmd.CommandText = "drop USER " + username + ";";
                        cmd.ExecuteNonQuery();
                        Console.Write("Se borro el usuario exitosamente");
                        tbUser.Text = "";
                        tbPassword.Text = "";
                    }
                }
            }
        }
    }
}
