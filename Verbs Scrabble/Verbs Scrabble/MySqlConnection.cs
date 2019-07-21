using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Verbs_Scrabble
{
    class MySqlConnection
    {
        public static string source = "datasource=localhost; port=3306; username=root; password=; database=verbsscrabble2";
        public static MySql.Data.MySqlClient.MySqlConnection dbConection = new MySql.Data.MySqlClient.MySqlConnection(source);
        public static MySqlDataReader verbs_infinitive, verbs_simple_past, verbs_past_participle;

        private int idVerb = 0;

        public static bool OpenConnection()
        {
            try
            {
                dbConection.Open();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo establecer conexion con el servidor: " + ex.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool CloseConnection()
        {
            try
            {
                dbConection.Close();
                return true;

            } catch(Exception e)
            {
                MessageBox.Show("No se pudo cerrar conexion con el servidor: " + e.Message, "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void setID()
        {
            Random random = new Random();
            idVerb = random.Next(1, 101);
        }

        public string getVerbInfinitive()
        {
            string infinitive = "";
            OpenConnection();
            string sql = "SELECT verb FROM verbs_inifnitive WHERE id = '" + idVerb + "'";
            MySqlCommand mySql = new MySqlCommand(sql, dbConection);

            try
            {
                verbs_infinitive = mySql.ExecuteReader();
                if (verbs_infinitive.HasRows)
                {
                    while (verbs_infinitive.Read())
                        infinitive = Convert.ToString(verbs_infinitive["verb"]);
                }
            }catch(Exception e)
            {
                MessageBox.Show("No se pudo procesar la peticion, lo sentimos: " + e.Message, "Notificación",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            CloseConnection();
            return infinitive;
        }

        public string getVerbSP()
        {
            string sp = "";
            OpenConnection();
            string sql = "SELECT verb FROM verbs_simple_past WHERE id = '" + idVerb + "'";
            MySqlCommand mySql = new MySqlCommand(sql, dbConection);

            try
            {
                verbs_simple_past = mySql.ExecuteReader();
                if (verbs_simple_past.HasRows)
                {
                    while (verbs_simple_past.Read())
                        sp = Convert.ToString(verbs_simple_past["verb"]);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo procesar la peticion, lo sentimos: " + e.Message, "Notificación",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            CloseConnection();   
            return sp;
        }

        public string getVerbPP()
        {
            string pp = "";
            OpenConnection();
            string sql = "SELECT verb FROM verbs_inifnitive WHERE id = '" + idVerb + "'";
            MySqlCommand mySql = new MySqlCommand(sql, dbConection);
            try
            {
                verbs_past_participle = mySql.ExecuteReader();
                if (verbs_past_participle.HasRows)
                {
                    while (verbs_past_participle.Read())
                        pp = Convert.ToString(verbs_past_participle["verb"]);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo procesar la peticion, lo sentimos: " + e.Message, "Notificación",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            CloseConnection();
            return pp;
        }
    }
}
