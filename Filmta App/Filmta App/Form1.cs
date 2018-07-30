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
    public partial class Form1 : ModernUIForm
    {

        public Form1()
        {
            InitializeComponent();

            //Preencher o ecra todo (depende da resolução)
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }        
                
    }    
}
