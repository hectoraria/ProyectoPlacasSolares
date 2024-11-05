using DAL;
using ENT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoPlacasSolares.VM
{
    class CitasClientesVM
    {
        public List<ClsCita> ListaClientes { get; }
        public ClsCita CitaSelected { get; set; }

        public CitasClientesVM()
        {
            ListaClientes = ClsListas.listaCitas();
        }
    }
}
