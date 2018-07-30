using Filmta_App.UIControls.Login;
using System;
using System.Windows.Forms;

namespace Filmta_App
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            //Inicializar com controladores para o Login
            PanelContainer.Controls.Clear();
            PanelContainer.Controls.Add(new UserControlLogin(this));           
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Panel BuscarContainer()
        {
            return this.PanelContainer;
        }
    }
}
