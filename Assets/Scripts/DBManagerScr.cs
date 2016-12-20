using Assets.Scripts;
using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;

public class DBManagerScr {
    #region Singleton
    private static DBManagerScr instance = null;

    private DBManagerScr() { }

    public static DBManagerScr getInstance()
    {
        if (instance == null) instance = new DBManagerScr();
        return instance;
    }
    #endregion

    #region PublicMethods
    public Product GetById (int id) {
        Product tmpProd = null;

        IDbConnection connection = new SqliteConnection("URI = file:" + Application.dataPath + "/DataBases/Product.db");
        connection.Open();
        IDbCommand command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM tblProducts WHERE id = " + id;
        IDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            tmpProd = new Product();
            tmpProd.id = reader.GetInt32(0);
            tmpProd.name = reader.GetString(1);
            tmpProd.description = reader.GetString(2);
        }
        return tmpProd;
	}
    #endregion
}