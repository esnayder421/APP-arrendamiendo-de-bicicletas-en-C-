using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace App_ARRIENDA_BICIS
{
    public partial class Bicicleta1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnInsertar_Click(object sender, EventArgs e)
        {
            Bicicleta obje = new Bicicleta();
            try
            {
                //enviando los datos a la logica de negocio
                obje.COD_BICI1 = TxtCodbici.Text;
                obje.MARCA1 = TxtMarca.Text;
                obje.VALOR1 = Convert.ToInt32(TxtValor.Text);
                obje.CANTIDAD1 = Convert.ToInt32(TxtCantidad.Text);
                obje.TIPO1 = TxtTipo.Text;
                
                if (!obje.insertar_bicicleta())
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
            Bicicleta obje = new Bicicleta();
            try
            {
                obje.COD_BICI1 = TxtCodbici.Text;
                obje.MARCA1 = TxtMarca.Text;
                obje.VALOR1 = Convert.ToInt32(TxtValor.Text);
                obje.CANTIDAD1 = Convert.ToInt32(TxtCantidad.Text);
                obje.TIPO1 = TxtTipo.Text;

                if (!obje.actualizar_bicicleta())
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
            Bicicleta objE = new Bicicleta();
            try
            {
                objE.COD_BICI1 = TxtCodbici.Text;

                if (!objE.consultar_bicicleta())
                {
                    Lblmensaje.Text = objE.StrError;
                    return;
                }
                else
                {
                    if (objE.ObjReader.HasRows)
                    {
                        objE.ObjReader.Read();
                        TxtMarca.Text = objE.ObjReader.GetString(1);
                        TxtValor.Text = objE.ObjReader.GetString(2);
                        TxtCantidad.Text = objE.ObjReader.GetString(3);
                        TxtTipo.Text = objE.ObjReader.GetString(4);


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
            Bicicleta objE = new Bicicleta();
            try
            {
                objE.COD_BICI1 = TxtCodbici.Text;

                if (!objE.eliminar_bicicleta())
                {
                    Lblmensaje.Text = objE.StrError;
                    return;
                }
                else
                {
                    if (objE.ObjReader.HasRows)
                    {
                        objE.ObjReader.Read();
                        TxtMarca.Text = objE.ObjReader.GetString(1);
                        TxtValor.Text = objE.ObjReader.GetString(2);
                        TxtCantidad.Text = objE.ObjReader.GetString(3);
                        TxtTipo.Text = objE.ObjReader.GetString(4);


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
            Bicicleta objE = new Bicicleta();
            if (!objE.listar_bicicleta(GVDatos))
            {
                Lblmensaje.Text = objE.StrError;
                return;
            }
        }
    }
}