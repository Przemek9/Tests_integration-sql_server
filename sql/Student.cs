using System;
using System.Data.SqlClient;

namespace ConnectSQLServer
{
    public class Student
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Imie studenta o Id 1 to: " + Select_imie("test_aeh_students"));
            //Console.WriteLine("Nazwisko studenta o Id 1 to: " + Select_nazwisko("test_aeh_students"));

        }

        private int m_Id;
        private string m_Imie;
        private string m_Nazwisko;

        public Student(int Id,string Imie, string Nazwisko)
        {
            m_Id = Id;
            m_Imie = Imie;
            m_Nazwisko = Nazwisko;
        }

        public int Id
        {
            get { return m_Id; }
        }

        public string Imie
        {
            get { return m_Imie; }
        }

        public string Nazwisko
        {
            get { return m_Nazwisko; }
        }

        public static string Select_nazwisko(string tabela)
        {
                string nazwisko_w;
                string m_tabela = tabela; 
                var datasource = @"DESKTOP-B71JALK";
                var database = "AEH"; 
                var username = "User1"; 
                var password = "Komputer0!"; 
                string connString = @"Data Source=" + datasource + ";Initial Catalog="
                            + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM "+m_tabela+" WHERE Id=1", conn))
                {

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                      if (reader.Read())
                    {
                        Student pole1 = new Student(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));                   
                        nazwisko_w = pole1.Nazwisko;
                        return nazwisko_w;
                    }
                        else return null;

                       }
                 }

        }
        public static string Select_imie(string tabela)
        {
            string imie_w;
            string m_tabela = tabela;
            var datasource = @"DESKTOP-B71JALK";
            var database = "AEH";
            var username = "User1";
            var password = "Komputer0!";
            string connString = @"Data Source=" + datasource + ";Initial Catalog="
                        + database + ";Persist Security Info=True;User ID=" + username + ";Password=" + password;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            using (SqlCommand command = new SqlCommand("SELECT * FROM " + m_tabela + " WHERE Id=1", conn))
            {

                using (SqlDataReader reader = command.ExecuteReader())
                {

                    if (reader.Read())
                    {
                        Student pole1 = new Student(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                        imie_w = pole1.Imie;
                        return imie_w;
                    }
                    else return null;

                }
            }

        }
    }
}