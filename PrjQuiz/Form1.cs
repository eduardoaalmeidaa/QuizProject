using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          FrmLoad frmLoad = new FrmLoad();
          frmLoad.ShowDialog();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void LblIniciar_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.Acertos = 0;
            VariaveisGlobais.Erros = 0;

            FrmP1 p1 = new FrmP1();
            p1.ShowDialog();
        }
    }
}