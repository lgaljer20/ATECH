using ATECH.Models;
using DBLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATECH.Repositories
{
    public class IzvoriFinanciranjaRepository
    {
        public static IzvoriFinanciranja DohvatiIzvor(int id)
        {
            IzvoriFinanciranja izvor = null;
            string sql = $"SELECT * FROM IzvoriFinanciranja WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                izvor = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return izvor;
        }

        public static List<IzvoriFinanciranja> DohvatiIzvore()
        {
            List<IzvoriFinanciranja> izvori = new List<IzvoriFinanciranja>();
            string sql = "SELECT * FROM IzvoriFinanciranja";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                IzvoriFinanciranja izvor = CreateObject(reader);
                izvori.Add(izvor);
            }
            reader.Close();
            DB.CloseConnection();
            return izvori;
        }

        private static IzvoriFinanciranja CreateObject(System.Data.SqlClient.SqlDataReader reader)
        {

            int id = int.Parse(reader["Id"].ToString());
            string izvorFinanciranja = reader["IzvorFinanciranja"].ToString();


            var izvor = new IzvoriFinanciranja
            {
                Id = id,
                IzvorFinanciranja = izvorFinanciranja
            };

            return izvor;
        }
    }
}
