﻿using System;
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
    public partial class FrmP6 : Form
    {
        public FrmP6()
        {
            InitializeComponent();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            if (rbtnCerta.Checked == true)
            {
                MessageBox.Show("Correto!", "QUIZ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //somar na variavel Global acertos
                VariaveisGlobais.Acertos += 1;
                FrmP7 p7 = new FrmP7();
                p7.ShowDialog();
                this.Dispose();
            }
            else if (radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                MessageBox.Show("Incorreto!", "QUIZ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //somar na variavel Global erros
                VariaveisGlobais.Erros += 1;
                FrmP7 p7 = new FrmP7();
                p7.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Escolha uma Alternativa!", "QUIZ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}