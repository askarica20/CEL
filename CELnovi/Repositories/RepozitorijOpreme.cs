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
    public class RepozitorijOpreme
    {
        public static Oprema GetOprema(int id)
        {
            Oprema oprema = null;
            string sql = $"SELECT * FROM Opreme WHERE Id = {id}";
            DB.SetConfiguration("askarica20_DB", "askarica20", "]Sk{MEC4");
            DB.OpenConnection();
             var reader = DB.GetDataReader(sql);
             if (reader.HasRows)
             {
                 reader.Read();
                 oprema = KreirajObjekt(reader);
                 reader.Close();
             }
             DB.CloseConnection();
            return oprema;
        }
        
        public static List<Oprema> GetOpremas(){
            
            var opreme = new List<Oprema>();

            string sql = "SELECT * FROM Oprema";
            DB.SetConfiguration("askarica20_DB", "askarica20", "]Sk{MEC4"); // AK NE DELA MAKNI OVO
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Oprema oprema = KreirajObjekt(reader);
                opreme.Add(oprema);
            }

            reader.Close();
            DB.CloseConnection();

            return opreme;
        }

        private static Oprema KreirajObjekt(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string naziv = reader["Naziv"].ToString(); // ovak se zovu columnsi u onom za bazu
            string vrsta = reader["Vrsta"].ToString();
            string datVrPrimke = reader["DatVrPrimke"].ToString(); 
            string nazivProjekta = reader["NazivProjekta"].ToString();
            string izvorFinanciranja = reader["IzvorFinanciranja"].ToString();
            string opisOpreme = reader["OpisOpreme"].ToString();
            string osobaNabave = reader["OsobaNabave"].ToString();
            string osobaPrimke = reader["OsobaPrimke"].ToString();

            var oprema = new Oprema
            {
                Id = id,
                Naziv = naziv,
                Vrsta = vrsta,
                DatVrPrimke = datVrPrimke,
                OpisOpreme = opisOpreme,
                NazivProjekta = nazivProjekta,
                IzvorFinanciranja = izvorFinanciranja,
                OsobaNabave = osobaNabave,
                OsobaPrimke = osobaPrimke
            };

            return oprema;
        }
       
    }
}
