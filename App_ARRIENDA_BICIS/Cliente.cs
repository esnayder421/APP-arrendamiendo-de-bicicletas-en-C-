using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

using System.Web.UI.WebControls;
// ---------------- LOGICA DE NEGOCIO ----------------
namespace App_ARRIENDA_BICIS
{
    public class Cliente
    {
        #region atributos
        private string strError;

        private string ID_CLIENTE;
        private string NOMBRE_CLI;
        private string TELEFONO_CLI;
        private string CORREO_CLI;
        private string DIRECCION_CLI;

        private SqlDataReader objReader;



        #endregion

        #region metodos
        public bool insertar_cliente()
        {
            string sentencia = "execute USP_INSERTAR_CLIENTE '" + ID_CLIENTE + "','" + NOMBRE_CLI + "','" + TELEFONO_CLI + "','" + CORREO_CLI + "','" + DIRECCION_CLI + "'";
            Conexion obj_conexion = new Conexion();

            if (obj_conexion.EjecutarSentencia(sentencia, false))
            {
                objReader = obj_conexion.Reader;
                obj_conexion = null;
                return true;
            }
            else
            {
                strError = obj_conexion.Error;
                obj_conexion = null;
                return false;
            }

        }
        //--------------------------------------------------------- ACTUALIZAR------------------------------------------
        public bool actualizar_cliente()
        {
            string sentencia = " execute USP_ACTUALIZAR_CLIENTE '" + ID_CLIENTE + "','" + NOMBRE_CLI + "','" + TELEFONO_CLI + "','" + CORREO_CLI + "','" + DIRECCION_CLI + "'";
            Conexion obj_conexion = new Conexion();

            if (obj_conexion.EjecutarSentencia(sentencia, false))
            {
                objReader = obj_conexion.Reader;
                obj_conexion = null;
                return true;
            }
            else
            {
                strError = obj_conexion.Error;
                obj_conexion = null;
                return false;
            }
        }

        //---------------------------------------CONSULTAR----------------------------------------------------
        public bool consultar_cliente()
        {
            string sentencia = "execute USP_CONSULTAR_CLIENTE '" + ID_CLIENTE + "'";
            Conexion obj_conexion = new Conexion();

            if (obj_conexion.consultar(sentencia, false))
            {
                objReader = obj_conexion.Reader;
                obj_conexion = null;
                return true;
            }
            else
            {
                strError = obj_conexion.Error;
                obj_conexion = null;
                return false;
            }
        }

        //-----------------------------------------------------------ELIMINAR------------------------------------------------------
        public bool eliminar_cliente()
        {
            string sentencia = "execute USP_ELIMINAR_CLIENTE'" + ID_CLIENTE + "'";
            Conexion obj_conexion = new Conexion();

            if (obj_conexion.EjecutarSentencia(sentencia, false))
            {
                objReader = obj_conexion.Reader;
                obj_conexion = null;
                return true;
            }
            else
            {
                strError = obj_conexion.Error;
                obj_conexion = null;
                return false;
            }
        }

        public bool listar_cliente(GridView dgvD)
        {
            LlenarGrid obj = new LlenarGrid();
            obj.NombreTabla = "CLIENTE";
            obj.SQL = "EXEC USP_LISTAR_CLIENTE";
            if (!obj.LlenarGridWeb(dgvD))
            {
                strError = obj.Error;
                obj = null;
                return false;
            }
            obj = null;
            return true;
        }
        #endregion

        #region propiedades
        public string StrError { get => strError; set => strError = value; }
        public string ID_CLIENTE1 { get => ID_CLIENTE; set => ID_CLIENTE = value; }
        public string NOMBRE_CLI1 { get => NOMBRE_CLI; set => NOMBRE_CLI = value; }
        public string TELEFONO_CLI1 { get => TELEFONO_CLI; set => TELEFONO_CLI = value; }

        public string CORREO_CLI1 { get => CORREO_CLI; set => CORREO_CLI = value; }
        public string DIRECCION_CLI1 { get => DIRECCION_CLI; set => DIRECCION_CLI = value; }

        public SqlDataReader ObjReader { get => objReader; set => objReader = value; }
        #endregion
    }

    public class Empleado
    {
        #region atributos
        private string strError;

        private string ID_EMPLEADO;
        private string NOMBRE_EMP;
        private string TELEFONO_EMP;
        private string CORREO_EMP;
        private string DIRECCION_EMP;

        private SqlDataReader objReader;

        #endregion

        #region metodos
        public bool insertar_empleado()
        {
            string sentencia = "execute USP_INSERTAR_EMPLEADO'" + ID_EMPLEADO + "','" + NOMBRE_EMP + "','" + TELEFONO_EMP + "','" + CORREO_EMP + "','" + DIRECCION_EMP + "'";
            Conexion obj_conexion = new Conexion();

            if (obj_conexion.EjecutarSentencia(sentencia, false))
            {
                objReader = obj_conexion.Reader;
                obj_conexion = null;
                return true;
            }
            else
            {
                strError = obj_conexion.Error;
                obj_conexion = null;
                return false;
            }

        }
        //--------------------------------------------------------- ACTUALIZAR------------------------------------------
        public bool actualizar_empleado()
        {
            string sentencia = " execute USP_ACTUALIZAR_EMPLEADO'" + ID_EMPLEADO + "','" + NOMBRE_EMP + "','" + TELEFONO_EMP + "','" + CORREO_EMP + "','" + DIRECCION_EMP + "'";
            Conexion obj_conexion = new Conexion();

            if (obj_conexion.EjecutarSentencia(sentencia, false))
            {
                objReader = obj_conexion.Reader;
                obj_conexion = null;
                return true;
            }
            else
            {
                strError = obj_conexion.Error;
                obj_conexion = null;
                return false;
            }
        }

        //---------------------------------------CONSULTAR----------------------------------------------------
        public bool consultar_empleado()
        {
            string sentencia = "execute USP_CONSULTAR_EMPLEADO '" + ID_EMPLEADO + "'";
            Conexion obj_conexion = new Conexion();

            if (obj_conexion.consultar(sentencia, false))
            {
                objReader = obj_conexion.Reader;
                obj_conexion = null;
                return true;
            }
            else
            {
                strError = obj_conexion.Error;
                obj_conexion = null;
                return false;
            }
        }

        //-----------------------------------------------------------ELIMINAR------------------------------------------------------
        public bool eliminar_empleado()
        {
            string sentencia = "execute USP_ELIMINAR_EMPLEADO'" + ID_EMPLEADO + "'";
            Conexion obj_conexion = new Conexion();

            if (obj_conexion.EjecutarSentencia(sentencia, false))
            {
                objReader = obj_conexion.Reader;
                obj_conexion = null;
                return true;
            }
            else
            {
                strError = obj_conexion.Error;
                obj_conexion = null;
                return false;
            }
        }

        public bool listar_empleado(GridView dgvD)
        {
            LlenarGrid obj = new LlenarGrid();
            obj.NombreTabla = "EMPLEADO";
            obj.SQL = "EXEC USP_LISTAR_EMPLEADO";
            if (!obj.LlenarGridWeb(dgvD))
            {
                strError = obj.Error;
                obj = null;
                return false;
            }
            obj = null;
            return true;
        }


        #endregion

        #region propiedades
        public string StrError { get => strError; set => strError = value; }
        public string ID_EMPLEADO1 { get => ID_EMPLEADO; set => ID_EMPLEADO = value; }
        public string NOMBRE_EMP1 { get => NOMBRE_EMP; set => NOMBRE_EMP = value; }
        public string TELEFONO_EMP1 { get => TELEFONO_EMP; set => TELEFONO_EMP = value; }
        public string CORREO_EMP1 { get => CORREO_EMP; set => CORREO_EMP = value; }
        public string DIRECCION_EMP1 { get => DIRECCION_EMP; set => DIRECCION_EMP = value; }
        public SqlDataReader ObjReader { get => objReader; set => objReader = value; }
        #endregion
    }
    public class Bicicleta
    {
        #region atributos
        private string strError;

        private string COD_BICI;
        private string MARCA;
        private int VALOR;
        private int CANTIDAD;
        private string TIPO;
        private SqlDataReader objReader;


        #endregion

        #region metodos
        public bool insertar_bicicleta()
        {
            string sentencia = "execute USP_INSERTAR_BICICLETA '" + COD_BICI + "','" + MARCA + "'," + VALOR + "," + CANTIDAD + ",'" + TIPO + "'";
            Conexion obj_conexion = new Conexion();

            if (obj_conexion.EjecutarSentencia(sentencia, false))
            {
                ObjReader = obj_conexion.Reader;
                obj_conexion = null;
                return true;
            }
            else
            {
                strError = obj_conexion.Error;
                obj_conexion = null;
                return false;
            }

        }
        //--------------------------------------------------------- ACTUALIZAR------------------------------------------
        public bool actualizar_bicicleta()
        {
            string sentencia = " execute USP_ACTUALIZAR_BICICLETA '" + COD_BICI + "','" + MARCA + "'," + VALOR + "," + CANTIDAD + ",'" + TIPO + "'";
            Conexion obj_conexion = new Conexion();

            if (obj_conexion.EjecutarSentencia(sentencia, false))
            {
                ObjReader = obj_conexion.Reader;
                obj_conexion = null;
                return true;
            }
            else
            {
                strError = obj_conexion.Error;
                obj_conexion = null;
                return false;
            }
        }

        //---------------------------------------CONSULTAR----------------------------------------------------
        public bool consultar_bicicleta()
        {
            string sentencia = "execute USP_CONSULTAR_BICICLETA '" + COD_BICI + "'";
            Conexion obj_conexion = new Conexion();

            if (obj_conexion.consultar(sentencia, false))
            {
                ObjReader = obj_conexion.Reader;
                obj_conexion = null;
                return true;
            }
            else
            {
                strError = obj_conexion.Error;
                obj_conexion = null;
                return false;
            }
        }

        //-----------------------------------------------------------ELIMINAR------------------------------------------------------
        public bool eliminar_bicicleta()
        {
            string sentencia = "execute USP_ELIMINAR_BICICLETA'" + COD_BICI + "'";
            Conexion obj_conexion = new Conexion();

            if (obj_conexion.EjecutarSentencia(sentencia, false))
            {
                ObjReader = obj_conexion.Reader;
                obj_conexion = null;
                return true;
            }
            else
            {
                strError = obj_conexion.Error;
                obj_conexion = null;
                return false;
            }
        }

        public bool listar_bicicleta(GridView dgvD)
        {
            LlenarGrid obj = new LlenarGrid();
            obj.NombreTabla = "BICICLETA";
            obj.SQL = "EXEC USP_LISTAR_BICICLETA";
            if (!obj.LlenarGridWeb(dgvD))
            {
                strError = obj.Error;
                obj = null;
                return false;
            }
            obj = null;
            return true;
        }
        #endregion

        #region propiedades
        public string StrError { get => strError; set => strError = value; }
        public string COD_BICI1 { get => COD_BICI; set => COD_BICI = value; }
        public string MARCA1 { get => MARCA; set => MARCA = value; }
        public int VALOR1 { get => VALOR; set => VALOR = value; }
        public int CANTIDAD1 { get => CANTIDAD; set => CANTIDAD = value; }
        public string TIPO1 { get => TIPO; set => TIPO = value; }
        public SqlDataReader ObjReader { get => objReader; set => objReader = value; }

        #endregion
    }

    public class Factura
    {
        #region atributos
        private string strError;

        private string NUM_FACTURA;
        private string FECHA;
        private int SUB_TOTAL;
        private int TOTAL;
        private int IVA;
        private string ID_CLIENTE;
        private string ID_EMPLEADO;

        private SqlDataReader objReader;


        #endregion
        
        #region metodos
        public bool insertar_factura()
        {
            string sentencia = "execute USP_INSERTAR_FACTURA '" + NUM_FACTURA + "','" + FECHA + "','" + ID_CLIENTE + ",'" + ID_EMPLEADO +"'";
            Conexion obj_conexion = new Conexion();

            if (obj_conexion.EjecutarSentencia(sentencia, false))
            {
                objReader = obj_conexion.Reader;
                obj_conexion = null;
                return true;
            }
            else
            {
                strError = obj_conexion.Error;
                obj_conexion = null;
                return false;
            }

        }
        //--------------------------------------------------------- ACTUALIZAR------------------------------------------
        public bool actualizar_factura()
        {
            string sentencia = " execute USP_ACTUALIZAR_FACTURA '" + NUM_FACTURA + "','" + FECHA + "','" + ID_CLIENTE + ",'" + ID_EMPLEADO + "'";
            Conexion obj_conexion = new Conexion();

            if (obj_conexion.EjecutarSentencia(sentencia, false))
            {
                objReader = obj_conexion.Reader;
                obj_conexion = null;
                return true;
            }
            else
            {
                strError = obj_conexion.Error;
                obj_conexion = null;
                return false;
            }
        }

        //---------------------------------------CONSULTAR----------------------------------------------------
        public bool consultar_factura()
        {
            string sentencia = "execute USP_CONSULTAR_CLIENTE '" + NUM_FACTURA + "'";
            Conexion obj_conexion = new Conexion();

            if (obj_conexion.consultar(sentencia, false))
            {
                objReader = obj_conexion.Reader;
                obj_conexion = null;
                return true;
            }
            else
            {
                strError = obj_conexion.Error;
                obj_conexion = null;
                return false;
            }
        }

        //-----------------------------------------------------------ELIMINAR------------------------------------------------------
        public bool eliminar_factura()
        {
            string sentencia = "execute USP_ELIMINAR_FACTURA'" + NUM_FACTURA + "'";
            Conexion obj_conexion = new Conexion();

            if (obj_conexion.EjecutarSentencia(sentencia, false))
            {
                objReader = obj_conexion.Reader;
                obj_conexion = null;
                return true;
            }
            else
            {
                strError = obj_conexion.Error;
                obj_conexion = null;
                return false;
            }
        }

        public bool listar_factura(GridView dgvD)
        {
            LlenarGrid obj = new LlenarGrid();
            obj.NombreTabla = "FACTURA";
            obj.SQL = "EXEC USP_LISTAR_FACTURA";
            if (!obj.LlenarGridWeb(dgvD))
            {
                strError = obj.Error;
                obj = null;
                return false;
            }
            obj = null;
            return true;
        }
        #endregion

        #region propiedades
        public string StrError { get => strError; set => strError = value; }
        public string NUM_FACTURA1 { get => NUM_FACTURA; set => NUM_FACTURA = value; }
        public string FECHA1 { get => FECHA; set => FECHA = value; }
        public int SUB_TOTAL1 { get => SUB_TOTAL; set => SUB_TOTAL = value; }
        public int TOTAL1 { get => TOTAL; set => TOTAL = value; }
        public int IVA1 { get => IVA; set => IVA = value; }
        public string ID_CLIENTE1 { get => ID_CLIENTE; set => ID_CLIENTE = value; }
        public string ID_EMPLEADO1 { get => ID_EMPLEADO; set => ID_EMPLEADO = value; }
        public SqlDataReader ObjReader { get => objReader; set => objReader = value; }
        #endregion
    }
}

// ------------------------------- LOGICA DE NEGOCIO ----------------------------------