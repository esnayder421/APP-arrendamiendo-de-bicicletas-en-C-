using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace App_ARRIENDA_BICIS
{
    public partial class Factura1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnInsertar_Click(object sender, EventArgs e)
        {
            Factura obje = new Factura();
            try
            {
                //enviando los datos a la logica de negocio
                obje.NUM_FACTURA1 = TxtFactura.Text;
                obje.FECHA1 = TxtFecha.Text;
                obje.ID_CLIENTE1 = TxtIdCli.Text;
                obje.ID_EMPLEADO1 = TxtIdEmp.Text;

                if (!obje.insertar_factura())
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

        protected void BtnActualizas_Click(object sender, EventArgs e)
        {
            Factura obje = new Factura();
            try
            {
                obje.NUM_FACTURA1 = TxtFactura.Text;
                obje.FECHA1 = TxtFecha.Text;
                obje.ID_CLIENTE1 = TxtIdCli.Text;
                obje.ID_EMPLEADO1 = TxtIdEmp.Text;

                if (!obje.actualizar_factura())
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

        protected void BtnConsultar_Click(object sender, EventArgs e)
        {
            Factura objE = new Factura();
            try
            {
                objE.NUM_FACTURA1 = TxtFactura.Text;

                if (!objE.consultar_factura())
                {
                    Lblmensaje.Text = objE.StrError;
                    return;
                }
                else
                {
                    if (objE.ObjReader.HasRows)
                    {
                        objE.ObjReader.Read();
                        TxtFecha.Text = objE.ObjReader.GetString(1);
                        
                        TxtIdCli.Text = objE.ObjReader.GetString(5);
                        TxtIdEmp.Text = objE.ObjReader.GetString(6);


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

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            Factura objE = new Factura();
            try
            {
                objE.NUM_FACTURA1 = TxtFactura.Text;

                if (!objE.eliminar_factura())
                {
                    Lblmensaje.Text = objE.StrError;
                    return;
                }
                else
                {
                    if (objE.ObjReader.HasRows)
                    {
                        objE.ObjReader.Read();
                        TxtFecha.Text = objE.ObjReader.GetString(1);
                        
                        TxtIdCli.Text = objE.ObjReader.GetString(4);
                        TxtIdEmp.Text = objE.ObjReader.GetString(4);


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

        protected void BtnListar_Click(object sender, EventArgs e)
        {
            Factura objE = new Factura();
            if (!objE.listar_factura(GVDatos))
            {
                Lblmensaje.Text = objE.StrError;
                return;
            }
        }
    }
}



    