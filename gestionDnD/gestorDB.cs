using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace gestionDnD
{
    public class gestorDB
    {
        public struct tablaStats{
            public int id;
            public string Nombre;
            public int Nivel;
            public int PX;
            public int PXActuales;
            public int Iniciativa;
            public int Velocidad;
            public int CA;
            public int PV;
            public int PVActuales;
            public int Fuerza;
            public int Destreza;
            public int Constitucion;
            public int Inteligencia;
            public int Sabiduria;
            public int Carisma;
        }

        public struct tablaSkills
        {
            public int id;
            public int Acrobacia;
            public int Atletismo;
            public int ConArcano;
            public int Engano;
            public int Historia;
            public int Interpretacion;
            public int Intimidacion;
            public int Investigacion;
            public int JuegoManos;
            public int Medicina;
            public int Naturaleza;
            public int Percepcion;
            public int Perspicacia;
            public int Persuasion;
            public int Religion;
            public int Sigilo;
            public int Supervivencia;
            public int TratoAnimales;
        }

        public struct tablaMod
        {
            public int id;
            public int Fuerza;
            public int Destreza;
            public int Constitucion;
            public int Inteligencia;
            public int Sabiduria;
            public int Carisma;
        }

        public struct tablaInv
        {
            public int id;
            public string slot1;
            public string slot2;
            public string slot3;
            public string slot4;
            public string slot5;
            public string slot6;
            public string slot7;
            public string slot8;
            public string slot9;
            public string slot10;
            public string slot11;
            public string slot12;
            public string slot13;
            public string slot14;
            public string slot15;
            public string slot16;
            public string slot17;
            public string slot18;
            public string slot19;
            public string slot20;
            public int oro;
            public int plata;
            public int cobre;
        }
        // Server Password
        static string serverIp = "192.168.1.59";
        static string username = "root";
        static string password = "";
        static string databaseName = "personajes";
        public static string getClase(int id)
        {
            String Clase = "";

            try
            {
                string sql = "SELECT * FROM stats WHERE id=" + id;
                MySqlConnection con = new MySqlConnection(string.Format("server={0};userid={1};pwd={2};database={3};", serverIp, username, password, databaseName));
                MySqlCommand cmd = new MySqlCommand(sql, con);

                con.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Clase = reader.GetString("Clase");
                }
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("No se ha podido conectar");
                Console.WriteLine(e);
            }
            return Clase;
        }

        public static tablaStats getStats(int id) {
            tablaStats statsLeidas;
            statsLeidas.id = id;
            statsLeidas.Nombre = "0";
            statsLeidas.Nivel = 0;
            statsLeidas.PX = 0;
            statsLeidas.PXActuales = 0;
            statsLeidas.Iniciativa = 0;
            statsLeidas.Velocidad = 0;
            statsLeidas.CA = 0;
            statsLeidas.PV = 0;
            statsLeidas.PVActuales = 0;
            statsLeidas.Fuerza = 0;
            statsLeidas.Destreza = 0;
            statsLeidas.Constitucion = 0;
            statsLeidas.Inteligencia = 0;
            statsLeidas.Sabiduria = 0;
            statsLeidas.Carisma = 0;

            try
            {
                string sql = "SELECT * FROM stats WHERE id=" + id;
                MySqlConnection con = new MySqlConnection(string.Format("server={0};userid={1};pwd={2};database={3};", serverIp, username, password, databaseName));
                MySqlCommand cmd = new MySqlCommand(sql, con);

                con.Open();

                MySqlDataReader  reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    statsLeidas.id = reader.GetInt16("id");
                    statsLeidas.Nombre = reader.GetString("Nombre");
                    statsLeidas.Nivel = reader.GetInt16("Nivel");
                    statsLeidas.PX = reader.GetInt16("PX");
                    statsLeidas.PXActuales = reader.GetInt16("PXActuales");
                    statsLeidas.Iniciativa = reader.GetInt16("Iniciativa");
                    statsLeidas.Velocidad = reader.GetInt16("Velocidad");
                    statsLeidas.CA = reader.GetInt16("CA");
                    statsLeidas.PV = reader.GetInt16("PV");
                    statsLeidas.PVActuales = reader.GetInt16("PVActuales");
                    statsLeidas.Fuerza = reader.GetInt16("Fuerza");
                    statsLeidas.Destreza = reader.GetInt16("Destreza");
                    statsLeidas.Constitucion = reader.GetInt16("Constitucion");
                    statsLeidas.Inteligencia = reader.GetInt16("Inteligencia");
                    statsLeidas.Sabiduria = reader.GetInt16("Sabiduria");
                    statsLeidas.Carisma = reader.GetInt16("Carisma");
                }
                con.Close();
            }
            catch (Exception e){
                Console.WriteLine("No se ha podido conectar");
                Console.WriteLine(e);
            }
            return statsLeidas;
        }

        public static tablaSkills getSkills(int id)
        {
            tablaSkills statsLeidas;
            statsLeidas.id = id;
            statsLeidas.Acrobacia = 0;
            statsLeidas.Atletismo = 0;
            statsLeidas.ConArcano = 0;
            statsLeidas.Engano = 0;
            statsLeidas.Historia = 0;
            statsLeidas.Interpretacion = 0;
            statsLeidas.Intimidacion = 0;
            statsLeidas.Investigacion = 0;
            statsLeidas.JuegoManos = 0;
            statsLeidas.Medicina = 0;
            statsLeidas.Naturaleza = 0;
            statsLeidas.Percepcion = 0;
            statsLeidas.Perspicacia = 0;
            statsLeidas.Persuasion = 0;
            statsLeidas.Religion = 0;
            statsLeidas.Sigilo = 0;
            statsLeidas.Supervivencia = 0;
            statsLeidas.TratoAnimales = 0;

            try
            {
                string sql = "SELECT * FROM skills WHERE id=" + id;
                MySqlConnection con = new MySqlConnection(string.Format("server={0};userid={1};pwd={2};database={3};", serverIp, username, password, databaseName));
                MySqlCommand cmd = new MySqlCommand(sql, con);

                con.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    statsLeidas.id = reader.GetInt16("id");
                    statsLeidas.Acrobacia = reader.GetInt16("Acrobacia");
                    statsLeidas.Atletismo = reader.GetInt16("Atletismo");
                    statsLeidas.ConArcano = reader.GetInt16("ConArcano");
                    statsLeidas.Engano = reader.GetInt16("Engano");
                    statsLeidas.Historia = reader.GetInt16("Historia");
                    statsLeidas.Interpretacion = reader.GetInt16("Interpretacion");
                    statsLeidas.Intimidacion = reader.GetInt16("Intimidacion");
                    statsLeidas.Investigacion = reader.GetInt16("Investigacion");
                    statsLeidas.JuegoManos = reader.GetInt16("JuegoManos");
                    statsLeidas.Medicina = reader.GetInt16("Medicina");
                    statsLeidas.Naturaleza = reader.GetInt16("Naturaleza");
                    statsLeidas.Percepcion = reader.GetInt16("Percepcion");
                    statsLeidas.Perspicacia = reader.GetInt16("Perspicacia");
                    statsLeidas.Persuasion = reader.GetInt16("Persuasion");
                    statsLeidas.Religion = reader.GetInt16("Religion");
                    statsLeidas.Sigilo = reader.GetInt16("Sigilo");
                    statsLeidas.Supervivencia = reader.GetInt16("Supervivencia");
                    statsLeidas.TratoAnimales = reader.GetInt16("Trato Animales");
                }
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("No se ha podido conectar");
                Console.WriteLine(e);
            }
            return statsLeidas;
        }

        public static tablaMod getMod(int id)
        {
            tablaMod statsLeidas;
            statsLeidas.id = id;
            statsLeidas.Fuerza = 0;
            statsLeidas.Destreza = 0;
            statsLeidas.Constitucion = 0;
            statsLeidas.Inteligencia = 0;
            statsLeidas.Sabiduria = 0;
            statsLeidas.Carisma = 0;

            try
            {
                string sql = "SELECT * FROM tirSalvacion WHERE id=" + id;
                MySqlConnection con = new MySqlConnection(string.Format("server={0};userid={1};pwd={2};database={3};", serverIp, username, password, databaseName));
                MySqlCommand cmd = new MySqlCommand(sql, con);

                con.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    statsLeidas.id = reader.GetInt16("id");
                    statsLeidas.Fuerza = reader.GetInt16("Fuerza");
                    statsLeidas.Destreza = reader.GetInt16("Destreza");
                    statsLeidas.Constitucion = reader.GetInt16("Constitucion");
                    statsLeidas.Inteligencia = reader.GetInt16("Inteligencia");
                    statsLeidas.Sabiduria = reader.GetInt16("Sabiduria");
                    statsLeidas.Carisma = reader.GetInt16("Carisma");
                }
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("No se ha podido conectar");
                Console.WriteLine(e);
            }
            return statsLeidas;
        }

        public static tablaInv getInv(int id)
        {
            tablaInv statsLeidas;
            statsLeidas.id = id;
            statsLeidas.slot1 = "";
            statsLeidas.slot2 = "";
            statsLeidas.slot3 = "";
            statsLeidas.slot4 = "";
            statsLeidas.slot5 = "";
            statsLeidas.slot6 = "";
            statsLeidas.slot7 = "";
            statsLeidas.slot8 = "";
            statsLeidas.slot9 = "";
            statsLeidas.slot10 = "";
            statsLeidas.slot11 = "";
            statsLeidas.slot12 = "";
            statsLeidas.slot13 = "";
            statsLeidas.slot14 = "";
            statsLeidas.slot15 = "";
            statsLeidas.slot16 = "";
            statsLeidas.slot17 = "";
            statsLeidas.slot18 = "";
            statsLeidas.slot19 = "";
            statsLeidas.slot20 = "";
            statsLeidas.oro = 0;
            statsLeidas.plata = 0;
            statsLeidas.cobre = 0;

            try
            {
                string sql = "SELECT * FROM Inventario WHERE id=" + id;
                MySqlConnection con = new MySqlConnection(string.Format("server={0};userid={1};pwd={2};database={3};", serverIp, username, password, databaseName));
                MySqlCommand cmd = new MySqlCommand(sql, con);

                con.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    statsLeidas.id = reader.GetInt16("id");
                    statsLeidas.slot1 = reader.GetString("slot1");
                    statsLeidas.slot2 = reader.GetString("slot2");
                    statsLeidas.slot3 = reader.GetString("slot3");
                    statsLeidas.slot4 = reader.GetString("slot4");
                    statsLeidas.slot5 = reader.GetString("slot5");
                    statsLeidas.slot6 = reader.GetString("slot6");
                    statsLeidas.slot7 = reader.GetString("slot7");
                    statsLeidas.slot8 = reader.GetString("slot8");
                    statsLeidas.slot9 = reader.GetString("slot9");
                    statsLeidas.slot10 = reader.GetString("slot10");
                    statsLeidas.slot11 = reader.GetString("slot11");
                    statsLeidas.slot12 = reader.GetString("slot12");
                    statsLeidas.slot13 = reader.GetString("slot13");
                    statsLeidas.slot14 = reader.GetString("slot14");
                    statsLeidas.slot15 = reader.GetString("slot15");
                    statsLeidas.slot16 = reader.GetString("slot16");
                    statsLeidas.slot17 = reader.GetString("slot17");
                    statsLeidas.slot18 = reader.GetString("slot18");
                    statsLeidas.slot19 = reader.GetString("slot19");
                    statsLeidas.slot20 = reader.GetString("slot20");
                    statsLeidas.oro = reader.GetInt32("Oro");
                    statsLeidas.plata = reader.GetInt32("Plata");
                    statsLeidas.cobre = reader.GetInt32("Cobre");
                }
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("No se ha podido conectar");
                Console.WriteLine(e);
            }
            return statsLeidas;
        }

        public static void sendInv(int id, tablaInv aEnviar) 
        {
            try
            {
                string sql = "UPDATE Inventario SET" +
                    " slot1 = '" + aEnviar.slot1 +
                    "', slot2 = '" + aEnviar.slot2 +
                    "', slot3 = '" + aEnviar.slot3 +
                    "', slot4 = '" + aEnviar.slot4 +
                    "', slot5 = '" + aEnviar.slot5 +
                    "', slot6 = '" + aEnviar.slot6 +
                    "', slot7 = '" + aEnviar.slot7 +
                    "', slot8 = '" + aEnviar.slot8 +
                    "', slot9 = '" + aEnviar.slot9 +
                    "', slot10 = '" + aEnviar.slot10 +
                    "', slot11 = '" + aEnviar.slot11 +
                    "', slot12 = '" + aEnviar.slot12 +
                    "', slot13 = '" + aEnviar.slot13 +
                    "', slot14 = '" + aEnviar.slot14 +
                    "', slot15 = '" + aEnviar.slot15 +
                    "', slot16 = '" + aEnviar.slot16 +
                    "', slot17 = '" + aEnviar.slot17 +
                    "', slot18 = '" + aEnviar.slot18 +
                    "', slot19 = '" + aEnviar.slot19 +
                    "', slot20 = '" + aEnviar.slot20 +
                    "', Oro = '" + aEnviar.oro +
                    "', Plata = '" + aEnviar.plata +
                    "', Cobre = '" + aEnviar.cobre +
                    "' WHERE id=" + id;
                MySqlConnection con = new MySqlConnection(string.Format("server={0};userid={1};pwd={2};database={3};", serverIp, username, password, databaseName));
                MySqlCommand cmd = new MySqlCommand(sql, con);

                con.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                }
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("No se ha podido conectar");
                Console.WriteLine(e);
            }
        }

        public static void sendSkills(int id, tablaSkills aEnviar)
        {
            try
            {
                string sql = "UPDATE skills SET" +
                    " Acrobacia = '" + aEnviar.Acrobacia +
                    "', Atletismo = '" + aEnviar.Atletismo +
                    "', ConArcano = '" + aEnviar.ConArcano+
                    "', Engano = '" + aEnviar.Engano +
                    "', Historia = '" + aEnviar.Historia +
                    "', Interpretacion = '" + aEnviar.Interpretacion +
                    "', Intimidacion = '" + aEnviar.Intimidacion +
                    "', Investigacion = '" + aEnviar.Investigacion +
                    "', JuegoManos = '" + aEnviar.JuegoManos +
                    "', Medicina = '" + aEnviar.Medicina +
                    "', Naturaleza = '" + aEnviar.Naturaleza +
                    "', Percepcion = '" + aEnviar.Percepcion +
                    "', Perspicacia = '" + aEnviar.Perspicacia +
                    "', Persuasion = '" + aEnviar.Persuasion +
                    "', Religion = '" + aEnviar.Religion +
                    "', Sigilo = '" + aEnviar.Sigilo +
                    "', Supervivencia = '" + aEnviar.Supervivencia +
                    "', `Trato Animales` = '" + aEnviar.TratoAnimales +
                    "' WHERE id=" + id;
                MySqlConnection con = new MySqlConnection(string.Format("server={0};userid={1};pwd={2};database={3};", serverIp, username, password, databaseName));
                MySqlCommand cmd = new MySqlCommand(sql, con);

                con.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader);
                }
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("No se ha podido conectar");
                Console.WriteLine(e);
            }
        }

        public static void sendMod(int id, tablaMod aEnviar)
        {
            try
            {
                string sql = "UPDATE tirSalvacion SET" +
                    " Fuerza = '" + aEnviar.Fuerza +
                    "', Destreza = '" + aEnviar.Destreza +
                    "', Constitucion = '" + aEnviar.Constitucion +
                    "', Inteligencia = '" + aEnviar.Inteligencia +
                    "', Sabiduria = '" + aEnviar.Sabiduria +
                    "', Carisma = '" + aEnviar.Carisma +
                    "' WHERE id=" + id;
                MySqlConnection con = new MySqlConnection(string.Format("server={0};userid={1};pwd={2};database={3};", serverIp, username, password, databaseName));
                MySqlCommand cmd = new MySqlCommand(sql, con);

                con.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                }
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("No se ha podido conectar");
                Console.WriteLine(e);
            }
        }

        public static void sendStats(int id, tablaStats aEnviar)
        {
            try
            {
                string sql = "UPDATE stats SET" +
                    " Nombre = '" + aEnviar.Nombre +
                    "', Nivel = '" + aEnviar.Nivel +
                    "', PX = '" + aEnviar.PX +
                    "', PXActuales = '" + aEnviar.PXActuales +
                    "', Iniciativa = '" + aEnviar.Iniciativa +
                    "', Velocidad = '" + aEnviar.Velocidad +
                    "', CA = '" + aEnviar.CA +
                    "', PV = '" + aEnviar.PV +
                    "', PVActuales = '" + aEnviar.PVActuales +
                    "', Fuerza = '" + aEnviar.Fuerza +
                    "', Destreza = '" + aEnviar.Destreza +
                    "', Constitucion = '" + aEnviar.Constitucion +
                    "', Inteligencia = '" + aEnviar.Inteligencia +
                    "', Sabiduria = '" + aEnviar.Sabiduria +
                    "', Carisma = '" + aEnviar.Carisma +
                    "' WHERE id=" + id;
                MySqlConnection con = new MySqlConnection(string.Format("server={0};userid={1};pwd={2};database={3};", serverIp, username, password, databaseName));
                MySqlCommand cmd = new MySqlCommand(sql, con);

                con.Open();

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                }
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("No se ha podido conectar");
                Console.WriteLine(e);
            }
        }

        public static void darXPATodos(List<int> listaIDs, int px)
        {
            for (int i = 0; i < listaIDs.Count(); i++)
            {
                tablaStats actuales = getStats(listaIDs[i]);
                int asumar = actuales.PXActuales + px;
                try
                {
                    string sql = "UPDATE stats SET PXActuales = '" + asumar + "' WHERE id=" + listaIDs[i];
                    MySqlConnection con = new MySqlConnection(string.Format("server={0};userid={1};pwd={2};database={3};", serverIp, username, password, databaseName));
                    MySqlCommand cmd = new MySqlCommand(sql, con);

                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                    }
                    con.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine("No se ha podido conectar");
                    Console.WriteLine(e);
                }
            }
        }
    }
}
