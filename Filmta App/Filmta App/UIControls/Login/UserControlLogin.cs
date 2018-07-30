﻿using System;
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
    public partial class UserControlLogin : UserControl
    {
        private FormLogin formL;

        public UserControlLogin(FormLogin _formL)
        {
            InitializeComponent();

            //Inicializar form em uso
            formL = _formL;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formL.BuscarContainer().Controls.Clear();
            formL.BuscarContainer().Controls.Add(new UserControlSignUp(formL));
        }
    }
}
