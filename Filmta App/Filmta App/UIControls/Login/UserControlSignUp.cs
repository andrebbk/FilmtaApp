using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmta_App.UIControls.Login
{
    public partial class UserControlSignUp : UserControl
    {
        private FormLogin formL;

        public UserControlSignUp(FormLogin _formL)
        {
            InitializeComponent();

            //Inicializar form em uso
            formL = _formL;
        }

        private void buttonGoBack_Click(object sender, EventArgs e)
        {
            formL.BuscarContainer().Controls.Clear();
            formL.BuscarContainer().Controls.Add(new UserControlLogin(formL));
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {

        }
    }
}
