using NetDimension.WinForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmta_App
{
    public partial class FormInico : ModernUIForm
    {

        public FormInico()
        {
            //ICON
            // Get an Hicon for myBitmap.
            IntPtr Hicon = Properties.Resources.steampunk_victorian.GetHicon();
            // Create a new icon from the handle. 
            Icon _Icon = Icon.FromHandle(Hicon);
            this.Icon = _Icon;            

            InitializeComponent();

            //Preencher o ecra todo (depende da resolução)
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        //Carregar Form
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //Botao para sair
        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Botao para minimizar
        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }    
}
