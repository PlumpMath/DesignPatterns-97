using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string conection =
                "Server=(localdb)\\mssqllocaldb;Database=WatchHorseTV;Trusted_Connection=True;MultipleActiveResultSets=true";

            Database db;
            db = new SqlDatabase(conection);

            db.Connection.Open();
            db.Command.CommandText = "select * from AspNetUsers";
            DbDataReader r = db.Command.ExecuteReader();
            while (r.Read())
            {
                Console.WriteLine($"{r.GetString(r.GetOrdinal("firstname"))} {r.GetString(r.GetOrdinal("lastname"))}");
            }
            db.Connection.Close();*/
            var pepoleFactory = new PepoleFactory();
            IPepole p1 = pepoleFactory.GetPepole(PepoleType.Villagers);
            Console.WriteLine(p1.GetName());
            p1 = pepoleFactory.GetPepole(PepoleType.CityPeople);
            Console.WriteLine(p1.GetName());
        }
    }
}
