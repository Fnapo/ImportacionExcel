using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ExcelDataReader;

namespace ImportacionExcel
{
    class LectorExcel
    {
        public static List<object[]> lista;

        public static int Lectura()
        {
            string nombre = "./fichero.xlsx";
            using var fichero = File.Open(nombre, FileMode.Open, FileAccess.Read);

            bool comenzado = false;
            int inicio = -1, filaExcel = 0;

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            var lector = ExcelReaderFactory.CreateReader(fichero);
            lista = new List<Object[]>();

            while (lector.Read())
            {
                int elementos = lector.FieldCount;
                Object[] fila = new object[elementos];

                if (inicio < 0) { inicio = elementos + 1; }
                ++filaExcel;
                for (int i = 0; i < elementos; ++i)
                {
                    var celda = lector.GetValue(i);

                    if (celda != null && comenzado && i < inicio)
                    {
                        return filaExcel;
                    }
                    if (celda != null || i >= inicio)
                    {
                        if (!comenzado)
                        {
                            comenzado = true;
                            inicio = Math.Min(i, inicio);
                        }
                        if (i >= inicio)
                        {
                            if (celda != null) { fila[i] = celda.ToString(); }
                            else
                            {
                                return filaExcel;
                            }
                        }
                    }
                }
                if (comenzado) { lista.Add(fila); }
            }

            return 0;
        }
    }
}
