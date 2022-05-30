using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DBLayer;
using System.Data.SqlClient;
using PI_zadaca_3.Models;
using PI_zadaca_3.Rep;

namespace PI_zadaca_3.Rep
{
    
    

    public class ZahtjevRep
    {
        public static List<Zahtjev> DohvatiZahtjev()
             {
                List<Zahtjev> zahtjev = new List<Zahtjev>();

                string sql = "SELECT * FROM Zahtjev";
                //DB.SetConfiguration("fkruzicev20_DB","fkruzice20","j&l(5zqU");
                DB.OpenConnection();
                var reader = DB.GetDataReader(sql);
                while (reader.Read())
                {
                    var zahtjevi= new Zahtjev
                        { 
                           Id_Zahtjev=int.Parse(reader["Id_Zahtjev"].ToString()),
                           NazivPonude = reader["NazivPonude"].ToString(),
                           DatumPodnosenja=DateTime.Parse(reader["DatumPodnosenja"].ToString()),
                           Narucitelj=reader["Naručitelj"].ToString(),

                        
                        };
                        zahtjev.Add(zahtjevi);
                }

                reader.Close();
                DB.CloseConnection();
                return zahtjev;
             }


     


    }
}
