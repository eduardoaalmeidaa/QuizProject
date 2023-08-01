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
    public partial class FrmP1 : Form
    {
        public FrmP1()
        {
            InitializeComponent();
        }

        private void BtnProximo_Click(object sender, EventArgs e)
        {
            if (rbtnCerta.Checked == true)
            {
                MessageBox.Show("Correto!", "QUIZ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //somar na variavel Global acertos
                VariaveisGlobais.Acertos+=1;
                FrmP2 p2 = new FrmP2();
                p2.ShowDialog();
                this.Dispose();
            }
            else if (radioButton2.Checked || radioButton3.Checked || radioButton4.Checked)
            {
                MessageBox.Show("Incorreto!", "QUIZ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //somar na variavel Global erros
                VariaveisGlobais.Erros+=1;
                FrmP2 p2 = new FrmP2(); 
                p2.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Escolha uma Alternativa!", "QUIZ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}