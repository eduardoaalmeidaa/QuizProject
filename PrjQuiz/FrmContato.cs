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
    public partial class FrmContato : Form
    {
        public FrmContato()
        {
            InitializeComponent();
        }

        private void LblFechar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}