using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using CapaDatos;
using CapaEntidad;

namespace CapaDatos
{
    public class Datos
    {
        public SqlConnection conexion = new SqlConnection("Data Source=SOFIA03\\SQLEXPRESS;Initial Catalog=Base_datos_programacion;Integrated Security=True");
        public SqlCommand comando;

        
        ////////////// INSERT ///////////////////////
        public void CrearDatos(EntidadClases Habitantes)
        {
            conexion.Open();
            comando = new SqlCommand($"INSERT INTO Habitantes (Cedula,Nombre,Manzana,Edificio,Apto) Values('{Habitantes.Cedula}'," +
                $"'{Habitantes.Nombre}','{Habitantes.Manzana}',{Habitantes.Edificio},{Habitantes.Apto})", conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        ////////////// SELECT ///////////////////////
        public DataTable Leer()
        {
            conexion.Open();
            comando = new SqlCommand("[dbo].[MostrarParaUsuario]", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.ExecuteNonQuery();//Ejecutar comando

            SqlDataAdapter adap = new SqlDataAdapter(comando);

            DataTable tabla = new DataTable();
            adap.Fill(tabla);
            conexion.Close();

            return tabla;
        }


        ////////////// UPDATE ///////////////////////
        public void Update(EntidadClases habitantes)
        {
            conexion.Open();
            comando = new SqlCommand($"UPDATE Habitantes SET Nombre = '{habitantes.Nombre}', Manzana = '{habitantes.Manzana}'," +
                $" Edificio = {habitantes.Edificio}, Apto = {habitantes.Apto} where cedula = '{habitantes.Cedula}'", conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }


        ////////////// DELETE ///////////////////////
        public void Delete(EntidadClases habitantes)
        {
            conexion.Open();
            comando = new SqlCommand($"DELETE FROM Habitantes WHERE cedula = '{habitantes.Cedula}'", conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }


        ////////////// Buscar ///////////////////////
        public DataTable Buscar(EntidadClases habitantes)
        {
            conexion.Open();
            comando = new SqlCommand("BuscarHabitantes", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Add(new SqlParameter("@EleccionUsuario",habitantes.Cedula));
            comando.ExecuteNonQuery();

            SqlDataAdapter adap = new SqlDataAdapter(comando);

            DataTable tabla = new DataTable();
            adap.Fill(tabla);
            conexion.Close();

            return tabla;
        }

        ////////////// Manzana /////////////
        public DataTable CampoManzana()
        {
            conexion.Open();
            comando = new SqlCommand("SELECT * FROM ManzanaHabitantes ", conexion);
            comando.ExecuteNonQuery();

            SqlDataAdapter adap = new SqlDataAdapter(comando);

            DataTable tabla = new DataTable();
            adap.Fill(tabla);
            conexion.Close();

            return tabla;
        }

        ////////////// Edificio //////////
        public DataTable CampoEdificio()
        {
            conexion.Open();
            comando = new SqlCommand("SELECT * FROM EdificioHabitantes", conexion);
            comando.ExecuteNonQuery();

            SqlDataAdapter adap = new SqlDataAdapter(comando);

            DataTable tabla = new DataTable();
            adap.Fill(tabla);
            conexion.Close();

            return tabla;
        }

        ////////////// Apartamento ///////////////////////
        public DataTable CampoApartamentos()
        {
            conexion.Open();
            comando = new SqlCommand("SELECT * FROM ApartamentoHabitantes", conexion);
            comando.ExecuteNonQuery();

            SqlDataAdapter adap = new SqlDataAdapter(comando);

            DataTable tabla = new DataTable();
            adap.Fill(tabla);
            conexion.Close();

            return tabla;
        }

        public DataTable ListadoManzana(string EleccionUsuario)
        {
            conexion.Open();

            comando = new SqlCommand("ListadoManzana", conexion);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@EleccionUsuario", EleccionUsuario);
            comando.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            conexion.Close();

            return tabla;

        }

        public DataTable ListadoEdificio(string EleccionUsuario)
        {
            conexion.Open();

            comando = new SqlCommand("ListadoEdificio", conexion);
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@EleccionUsuario", EleccionUsuario);
            comando.ExecuteNonQuery();

            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            conexion.Close();

            return tabla;

        }
    }
}
