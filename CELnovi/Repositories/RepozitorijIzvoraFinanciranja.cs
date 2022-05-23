using CELnovi.Models;
using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CELnovi.Repositories
{
    public class RepozitorijIzvoraFinanciranja
    {
        
        public static IzvorFinanciranja GetIzvorFinanciranja(int id)
        {
            IzvorFinanciranja izvorFinanciranja = null;
            string sql = $"SELECT * FROM Izvorifinanciranja WHERE Id = {id}";
            DB.SetConfiguration("askarica20_DB", "askarica20", "]Sk{MEC4");
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                izvorFinanciranja = KreirajObjekt(reader);
                reader.Close();
            }
            DB.CloseConnection();
            return izvorFinanciranja;
        }

        public static List<IzvorFinanciranja> GetIzvoreFinanciranja()
        {
            List<IzvorFinanciranja> izvoriFinanciranja = new List<IzvorFinanciranja>();

            string sql = $"SELECT * FROM Izvorifinanciranja";
            DB.SetConfiguration("askarica20_DB", "askarica20", "]Sk{MEC4"); // mozda smeta
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                IzvorFinanciranja izvorFinanciranja = KreirajObjekt(reader);
                izvoriFinanciranja.Add(izvorFinanciranja);
            }
            reader.Close();
            DB.CloseConnection();
            return izvoriFinanciranja;
        }
    
        private static IzvorFinanciranja KreirajObjekt(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string iznos = reader["Iznos"].ToString();
            string naziv = reader["Naziv"].ToString();

            IzvorFinanciranja izvorFinanciranja = new IzvorFinanciranja
            {
                Id = id,
                Iznos = iznos,
                Naziv = naziv
            };
            return izvorFinanciranja;
        }
    }
}
