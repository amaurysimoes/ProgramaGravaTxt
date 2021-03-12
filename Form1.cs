using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//Fonte de informãções:
//https://satellasoft.com/artigo/csharp/gravando-e-lendo-dados-em-arquivo-texto-com-csharp

namespace ExemploProgramaGravaTxt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void clearForm()
        { 
            txtNome.Text = null;
            txtEmail.Text = null;
            rtbDescricao.Text = null;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //Conteudo de arquivoTexto está na classe
            arquivoTexto.writeData(txtNome.Text, txtEmail.Text, rtbDescricao.Text);
            clearForm();
            MessageBox.Show("Dados gravados.");
        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            //Conteudo de arquivoTexto está na classe
            String[] text = arquivoTexto.readFile().Split('|');
            MessageBox.Show(text[0] + "\n" + text[1] + "\n" + text[2]);
        }
    }
}
