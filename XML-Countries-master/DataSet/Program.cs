using System;
using System.Data;

namespace ExampleDataSet
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DataSet dts = new DataSet("MiBase");
            /* DataTable tbl = new DataTable("Paises");
             DataColumn col;
             DataRow row;

             dts.Tables.Add(tbl);// agregar tabla a datasbl
             //Add implementa los metdos de la lista para modificarla
             col = new DataColumn("id");
             tbl.Columns.Add(col);// hice una columna
             col = new DataColumn("nombre");
             tbl.Columns.Add(col);// hice una columna
             col = new DataColumn("continente");
             tbl.Columns.Add(col);// hice una columna

             //Ingresamos datos
             row = tbl.NewRow();
             row["id"] = "1";
             row["nombre"] = "Mexico";
             row["continente"] = "Americano";
             tbl.Rows.Add(row);

             row = tbl.NewRow();
             row["id"] = "2";
             row["nombre"] = "Chile";
             row["continente"] = "Americano";
             tbl.Rows.Add(row);

             row = tbl.NewRow();
             row["id"] = "3";
             row["nombre"] = "Canadá";
             row["continente"] = "Americano";
             tbl.Rows.Add(row);*/
            dts.ReadXml(@"/Users/pamelaruiz/Projects/DataSet/DataSet/thing.xml");

            for (int i = 0; i < dts.Tables["Paises"].Rows.Count; i++) {
                //Mostrar en pantalla
                for (int j = 0; j < dts.Tables["Paises"].Columns.Count; j++)
                {
                    Console.WriteLine(dts.Tables["Paises"].Rows[i][j]);
                }
            }

        }
    }
}
