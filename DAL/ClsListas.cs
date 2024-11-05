using ENT;

namespace DAL
{
    public class ClsListas
    {
        /// <summary>
        /// Funcion para que devuelva la lista de citas
        /// </summary>
        /// <returns>Listado de la clase ClsCitas</returns>
        public static List<ClsCita> listaCitas()
        {

            List<ClsCita> lista = new List<ClsCita>();

            lista.Add(new ClsCita("Hector Arias","Instalacion Placas Solares","Calle Cataluña Nº3"));
            lista.Add(new ClsCita("Jorge Arias", "Instalacion Placas Solares", "Calle Cataluña Nº3"));
            lista.Add(new ClsCita("Marco Houlguin", "Instalacion Placas Solares", "Calle Madrid Nº11B"));
            lista.Add(new ClsCita("Lorenzo Jesus", "Instalacion Placas Solares", "Calle Baleares Nº7C"));
            lista.Add(new ClsCita("Eduardo Sarnoso", "Instalacion Placas Solares", "Calle Adurne Nº5"));
            lista.Add(new ClsCita("Pablo Chileno", "Instalacion Placas Solares", "Calle Osto Nº23A"));
            lista.Add(new ClsCita("Raul Dominguez", "Instalacion Placas Solares", "Calle Delenti Nº87"));
            lista.Add(new ClsCita("Esteban Garcia", "Instalacion Placas Solares", "Calle Dominguez Nº6"));
            lista.Add(new ClsCita("Dani Guerrero", "Instalacion Placas Solares", "Calle Rio Nº4"));

            return lista;
        }
    }
}
