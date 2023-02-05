using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace App_ARRIENDA_BICIS
{
    public partial class Empleado1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnInsertar_Click(object sender, EventArgs e)
        {
            Empleado obje = new Empleado();
            try
            {
                //enviando los datos a la logica de negocio
                obje.ID_EMPLEADO1 = TxtIDEm.Text;
                obje.NOMBRE_EMP1 = TxtNomEm.Text;
                obje.TELEFONO_EMP1 = TxtTelefEm.Text;
                obje.CORREO_EMP1 = TxtCorreoEm.Text;
                obje.DIRECCION_EMP1 = TxtDirecEm.Text;
                if (!obje.insertar_empleado())
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
            Empleado obje = new Empleado();
            try
            {
                obje.ID_EMPLEADO1 = TxtIDEm.Text;
                obje.NOMBRE_EMP1 = TxtNomEm.Text;
                obje.TELEFONO_EMP1 = TxtTelefEm.Text;
                obje.CORREO_EMP1 = TxtCorreoEm.Text;
                obje.DIRECCION_EMP1 = TxtDirecEm.Text;

                if (!obje.actualizar_empleado())
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
            Empleado objE = new Empleado();
            try
            {
                objE.ID_EMPLEADO1 = TxtIDEm.Text;

                if (!objE.consultar_empleado())
                {
                    Lblmensaje.Text = objE.StrError;
                    return;
                }
                else
                {
                    if (objE.ObjReader.HasRows)
                    {
                        objE.ObjReader.Read();
                        TxtNomEm.Text = objE.ObjReader.GetString(1);
                        TxtTelefEm.Text = objE.ObjReader.GetString(2);
                        TxtCorreoEm.Text = objE.ObjReader.GetString(3);
                        TxtDirecEm.Text = objE.ObjReader.GetString(4);


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
            Empleado objE = new Empleado();
            try
            {
                objE.ID_EMPLEADO1 = TxtIDEm.Text;

                if (!objE.eliminar_empleado())
                {
                    Lblmensaje.Text = objE.StrError;
                    return;
                }
                else
                {
                    if (objE.ObjReader.HasRows)
                    {
                        objE.ObjReader.Read();
                        TxtNomEm.Text = objE.ObjReader.GetString(1);
                        TxtTelefEm.Text = objE.ObjReader.GetString(2);
                        TxtCorreoEm.Text = objE.ObjReader.GetString(3);
                        TxtDirecEm.Text = objE.ObjReader.GetString(4);


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
            Empleado objE = new Empleado();
            if (!objE.listar_empleado(GVDatos))
            {
                Lblmensaje.Text = objE.StrError;
                return;
            }
        }
    }
}