namespace ENT
{
    public class ClsCita
    {
        #region Propiedades
        public string Descripcion { get; set; }
        public string NombreCliente { get; set; }
        public string Direccion { get; set; }
        #endregion

        #region Constructores
        public ClsCita() { }
        public ClsCita(string nombreCliente,string descripcion, string direccion)
        {
           
            Descripcion = descripcion;
            NombreCliente = nombreCliente;
            Direccion = direccion;
        }

        #endregion
    }
}
