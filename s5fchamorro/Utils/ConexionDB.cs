

namespace s5fchamorro.Utils
{
    public static class ConexionDB
    {
        public static string devolverRuta(String nombreBaseDatos)
        {
            string rutaBaseDatos = string.Empty;
            if (DeviceInfo.Platform == DevicePlatform.Android)
            {
                rutaBaseDatos = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                rutaBaseDatos = Path.Combine(rutaBaseDatos, nombreBaseDatos);


            }
           return rutaBaseDatos;
        }


    }
}
