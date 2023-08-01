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
    public partial class FrmFinal : Form
    {
        public FrmFinal()
        {
            InitializeComponent();
        }

        private void FrmFinal_Load(object sender, EventArgs e)
        {
            lblAcertos.Text = VariaveisGlobais.Acertos.ToString();
            LblErros.Text = VariaveisGlobais.Erros.ToString();
        }

        private void LblFechar_Click(object sender, EventArgs e)
        {
            FrmContato contact = new FrmContato();
            contact.ShowDialog();
            this.Dispose();
        }
    }
}