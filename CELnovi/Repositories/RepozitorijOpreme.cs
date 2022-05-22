using CELnovi.Models;
using DBLayer;
using System;
using System.Collections.Generic;
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
            // DB.SetConfiguration("askarica20_DB", "askarica20", "]Sk{MEC4");
            DB.OpenConnection();
            /* var reader = DB.GetDataReader(sql);
             if (reader.HasRows)
             {
                 reader.Read();
                 oprema = KreirajObjekt(reader);
                 reader.Close();
             }
             DB.CloseConnection();*/
            return oprema;
        }
        /*
        public static List<Oprema> GetOpremas(){
            
            var opreme = new List<Oprema>();

            string sql = "SELECT * FROM Opreme";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Oprema oprema = KreirajObjekt(reader);
                opreme.Add(oprema);
            }

            reader.Close();
            //DB.CloseConnection();

            return opreme;
        }

        private static Oprema KreirajObjekt(SqlDataReader reader)
        {
            int id = int.Parse(reader["Id"].ToString());
            string nazivOpreme = reader["NazivOpreme"].ToString();
            string vrstaOpreme = reader["VrstaOpreme"].ToString();
            string datVrPrimke = reader["DatVrPrimke"].ToString(); 
            string nazivProjekta = reader["NazivProjekta"].ToString();
            string izvorFinanciranja = reader["IzvorFinanciranja"].ToString();
            string opisOpreme = reader["OpisOpreme"].ToString();
            string osobaNabave = reader["OsobaNabave"].ToString();
            string osobaPrimke = reader["OsobaPrimke"].ToString();

            var oprema = new Oprema
            {
                Id = id,
                NazivOpreme = nazivOpreme,
                VrstaOpreme = vrstaOpreme,
                DatVrPrimke = datVrPrimke,
                OpisOpreme = opisOpreme,
                NazivProjekta = nazivProjekta,
                IzvorFinanciranja = izvorFinanciranja,
                OsobaNabave = osobaNabave,
                OsobaPrimke = osobaPrimke
            };

            return oprema;
        }
        */
    }
}
