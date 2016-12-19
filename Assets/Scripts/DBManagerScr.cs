using Assets.Scripts;
using UnityEngine;
using SQLite;
using System.Collections.Generic;

public class DBManagerScr {

    private static DBManagerScr instance = null;

    private DBManagerScr() { }

    public static DBManagerScr getInstance()
    {
        if (instance == null) instance = new DBManagerScr();
        return instance;
    }

	public List<Product> GetById (int id) {

        List<Product> tmpProd = new List<Product>();

        // Создаем новое подключение к базе данных
        using (var db = new SQLiteConnection(Application.dataPath + "/DataBases/Product.db"))
        {
            // Делаем запрос на выборку данных
            IEnumerable<Product> list = db.Query<Product>("SELECT * FROM tblProducts");
            // Читаем и выводим результат
            foreach (Product prod in list)
            {
                tmpProd.Add(prod);
            }
            // И не забываем закрыть соединение
            db.Close();
        }

        return tmpProd;
	}
}
