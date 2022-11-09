using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENT_FacturacionElectronica;
using BLL_FacturacionElectronica;
namespace WIN_FacturacionElectronica
{
    public partial class FrmAutenticacion : Form
    {
        public FrmAutenticacion()
        {
            InitializeComponent();
        }
        private Cls_Usuario_ENT _usuario_ent;
        private readonly Cls_Usuario_BLL _usuario_bll = new Cls_Usuario_BLL();
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void TraerPorId(string login, string clave)
        {
            try
            {
                _usuario_ent = _usuario_bll.TraerPorId(login, clave);

                if (_usuario_ent != null)
                {
                    TxtUsuario.Text = _usuario_ent.Usu_login;
                    TxtClave.Text = _usuario_ent.Usu_clave;
                }
                else
                    MessageBox.Show("Usuario no existe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}", ex.Message), "Error inesperado");
            }
        }

        private void BtnProcesar_Click(object sender, EventArgs e)
        {
            TraerPorId(TxtUsuario.Text, TxtClave.Text);
        }
        //private void TxtUsuario_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyData == Keys.Enter && !string.IsNullOrWhiteSpace(TxtUsuario.Text))
        //    {
        //        e.SuppressKeyPress = true;
        //        TraerPorId(TxtUsuario.Text, TxtClave.Text);
        //    }
        //}
    }
}
