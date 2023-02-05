using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App_ARRIENDA_BICIS
{
    public class LlenarGrid
    {
        #region "CONSTRUCTOR"
        public LlenarGrid()
        {
            strNombreTabla = "";
            strSQL = "";
            strError = "";
        }
        #endregion

        #region "ATRIBUTOS"
        private string strNombreTabla;
        private string strSQL;
        private string strError;
        #endregion

        #region"PROPIEDADES"
        public string NombreTabla
        {
            get { return strNombreTabla; }
            set { strNombreTabla = value; }
        }
        public string SQL
        {
            get { return strSQL; }
            set { strSQL = value; }
        }
        public string Error
        {
            get { return strError; }
            set { strError = value; }
        }
        #endregion
        #region"METODOS PUBLICOS"

        public bool LlenarGridWeb(System.Web.UI.WebControls.GridView grdGenerico)
        {
            if (strSQL == "")
            {
                strError = "Debe definir una instruccion SQL";
                return false;
            }
            Conexion objConexionBD = new Conexion();
            if (strNombreTabla == "")
            {
                strNombreTabla = "DatosGridWeb";
            }
            if (objConexionBD.LlenarDataSet(strNombreTabla, strSQL, false))
            {
                grdGenerico.DataSource = objConexionBD.DataSet_Retornado.Tables[strNombreTabla];
                grdGenerico.DataBind();
                objConexionBD.CerrarConexion();
                objConexionBD = null;
                return true;
            }
            else
            {
                strError = objConexionBD.Error;
                objConexionBD.CerrarConexion();
                objConexionBD = null;
                return false;
            }
        }


        #endregion
    }
}