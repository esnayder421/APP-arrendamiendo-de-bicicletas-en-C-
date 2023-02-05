using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace App_ARRIENDA_BICIS
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        // -------------------------------INSERTAR -------------------------------------------------------
        protected void BtnInsertar_Click(object sender, EventArgs e)
        {
            Cliente obje = new Cliente();
            try
            {
                //enviando los datos a la logica de negocio
                obje.ID_CLIENTE1 = TxtIDcliente.Text;
                obje.NOMBRE_CLI1 = TxtNomCliente.Text;
                obje.TELEFONO_CLI1 = TxtTelefClieente.Text;
                obje.CORREO_CLI1 = TxtCorreoCliente.Text;
                obje.DIRECCION_CLI1 = TxtDirecCliente.Text;
                if (!obje.insertar_cliente())
                {
                    Lblmensaje.Text = obje.StrError;
                    return;
                }
                else
                {
                    Lblmensaje.Text = "se grabó exitosamente";
                    return;
                }

            }
            catch (Exception ex)
            {
                Lblmensaje.Text = ex.Message;
                return;
            }
        }
        //---------------------------------------CONSULTAR----------------------------------------------------
        protected void BtnConsultar_Click(object sender, EventArgs e)
        {
            Cliente objE = new Cliente();
            try
            {
                objE.ID_CLIENTE1 = TxtIDcliente .Text;

                if (!objE.consultar_cliente())
                {
                    Lblmensaje.Text = objE.StrError;
                    return;
                }
                else
                {
                    if (objE.ObjReader.HasRows)
                    {
                        objE.ObjReader.Read();
                        TxtNomCliente.Text = objE.ObjReader.GetString(1);
                        TxtTelefClieente.Text = objE.ObjReader.GetString(2);
                        TxtCorreoCliente.Text = objE.ObjReader.GetString(3);
                        TxtDirecCliente.Text = objE.ObjReader.GetString(4);


                        objE.ObjReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Lblmensaje.Text = objE.StrError;
                return;
            }
        }

        //---------------------------------------LISTAR---------------------------------------------------------
        protected void BtnListar_Click(object sender, EventArgs e)
        {
            Cliente objE = new Cliente();
            if (!objE.listar_cliente(GVDatos))
            {
                Lblmensaje.Text = objE.StrError;
                return;
            }
        }

        //------------------------------------------------------ACTUALIZAR-------------------------------------
        protected void BtnActualizas_Click(object sender, EventArgs e)
        {
            Cliente obje = new Cliente();
            try
            {
                obje.ID_CLIENTE1 = TxtIDcliente.Text;
                obje.NOMBRE_CLI1 = TxtNomCliente.Text;
                obje.TELEFONO_CLI1 = TxtTelefClieente.Text;
                obje.CORREO_CLI1 = TxtCorreoCliente.Text;
                obje.DIRECCION_CLI1 = TxtDirecCliente.Text;

                if (!obje.actualizar_cliente())
                {
                    Lblmensaje.Text = obje.StrError;
                    return;
                }
                else
                {
                    Lblmensaje.Text = "Se actualizo exitosamente";
                    return;
                }
            }
            catch (Exception ex)
            {
                Lblmensaje.Text = obje.StrError;
                return;
            }
        }

        //-----------------------------------------------------ELIMIAR---------------------------------------------
        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            Cliente objE = new Cliente();
            try
            {
                objE.ID_CLIENTE1 = TxtIDcliente.Text;

                if (!objE.eliminar_cliente())
                {
                    Lblmensaje.Text = objE.StrError;
                    return;
                }
                else
                {
                    if (objE.ObjReader.HasRows)
                    {
                        objE.ObjReader.Read();
                        TxtNomCliente.Text = objE.ObjReader.GetString(1);
                        TxtTelefClieente.Text = objE.ObjReader.GetString(2);
                        TxtCorreoCliente.Text = objE.ObjReader.GetString(3);
                        TxtDirecCliente.Text = objE.ObjReader.GetString(4);


                        objE.ObjReader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                Lblmensaje.Text = objE.StrError;
                return;
            }
        }
    }
}