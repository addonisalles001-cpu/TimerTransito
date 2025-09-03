using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerTransito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int segundos = 0;        
        
        private void tmrSemafaro_Tick(object sender, EventArgs e)
        {
            segundos++;
            if (segundos == 5)
            {
                pxtSemafaro.Image = Properties.Resources.images;

            }
            else if (segundos == 15)
            {
                pxtSemafaro.Image = Properties.Resources.images__1_;
            }
            else if (segundos == 30) 
            {
                pxtSemafaro.Image = Properties.Resources.Vermelho;
                segundos = 0;
            }



        }

        private void btnLigar_Click(object sender, EventArgs e)
        {
            trmSemafaro.Start();
        }

        private void btnDelisgar_Click(object sender, EventArgs e)
        {
            trmSemafaro.Stop();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }    
     
}

