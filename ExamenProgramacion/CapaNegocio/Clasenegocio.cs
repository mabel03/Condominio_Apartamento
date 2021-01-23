using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class Clasenegocio
    {
        Datos ejecutor = new Datos();

        public void Creador(EntidadClases Habitantes)
        {
            ejecutor.CrearDatos(Habitantes);
        }
        public DataTable Lector()
        {
            return ejecutor.Leer();
        }

        public void Modificar(EntidadClases Habitantes)
        {
            ejecutor.Update(Habitantes);
        }

        public void Eliminar(EntidadClases Habitantes)
        {
            ejecutor.Delete(Habitantes);
        }

        public DataTable Buscar(EntidadClases habitantes)
        {
            var resultado = ejecutor.Buscar(habitantes);
            return resultado;
        }

        ////////////// Manzana ////////////////
        public DataTable CampoManzana()
        {
            return ejecutor.CampoManzana();
        }

        ////////////// Apartamento ////////////////
        public DataTable CampoApartamento()
        {
            return ejecutor.CampoApartamentos();
        }

        ////////////// Edificio ////////////////
        public DataTable CampoEdificio()
        {
            return ejecutor.CampoEdificio();
        }

        public DataTable ListadoManzana(string EleccionUsuario)
        {
            return ejecutor.ListadoManzana(EleccionUsuario);
        }

        public DataTable ListadoEdificio(string EleccionUsuario)
        {
            return ejecutor.ListadoEdificio(EleccionUsuario);
        }

    }
}
