using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL_FacturacionElectronica;
using ENT_FacturacionElectronica;

namespace WEB_Facturacion_Electronica
{
    public partial class FrmLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private Cls_Usuario_ENT _usuario_ent;
        private readonly Cls_Usuario_BLL _usuario_bll = new Cls_Usuario_BLL();
        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            TraerPorId(Login1.UserName, Login1.Password);
        }

        private void TraerPorId(string login, string clave)
        {
            try
            {
                _usuario_ent = _usuario_bll.TraerPorId(login, clave);

                if (_usuario_ent != null)
                {
                    Login1.UserName = _usuario_ent.Usu_login;
                    //Login1.Password = _usuario_ent.Usu_clave;
                }
                //else
                    //MessageBox.Show("Usuario no existe");
            }
            catch (Exception ex)
            {
                //MessageBox.Show(string.Format("Error: {0}", ex.Message), "Error inesperado");
            }
        }
    }
}