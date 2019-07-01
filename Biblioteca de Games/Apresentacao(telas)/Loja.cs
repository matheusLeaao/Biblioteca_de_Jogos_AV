using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca_de_Games.Conexoes;
using Npgsql;

namespace Biblioteca_de_Games.Apresentacao_telas_
{
    public partial class Loja : Form
    {
        public Loja()
        {
            InitializeComponent();
        }
        public bool botaoNaruto;
        public bool botaoGta = false;
        public bool botaoPokemon = false;
        public bool botaoFF = false;
        public bool botaoSonic = false;
        public bool botaoBO4 = false;
        

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        public void btnNaruto_Click(object sender, EventArgs e)

        {
            bool botaoNarutoo = true;
            

            string nome = "Naruto Shippuden Ultimate ninja Storm 4";

            Autenticacao abrir = new Autenticacao();
            MessageBox.Show("Para segurança de sua conta insira o usuario e senha");
            abrir.Show();

        }

        private void btnPokemon_Click(object sender, EventArgs e)
        {
            botaoPokemon = true;

            string nome = "Pokemon Fire Red";

            Autenticacao abrir = new Autenticacao();
            MessageBox.Show("Para segurança de sua conta insira o usuario e senha");
            abrir.Show();
        }

        private void btnFFXV_Click(object sender, EventArgs e)
        {
            botaoFF = true;

            string nome = "Final Fantasy XV";

            Autenticacao abrir = new Autenticacao();
            MessageBox.Show("Para segurança de sua conta insira o usuario e senha");
            abrir.Show();
        }

        private void btnCOD_Click(object sender, EventArgs e)
        {
            botaoBO4 = true;

            string nome = "Call of Duty Black Ops ";

            Autenticacao abrir = new Autenticacao();
            MessageBox.Show("Para segurança de sua conta insira o usuario e senha");
            abrir.Show();
        }

        private void btnGta_Click(object sender, EventArgs e)
        {
            botaoGta = true;

            string nome = "Grand Theft Auto 5";

            Autenticacao abrir = new Autenticacao();
            MessageBox.Show("Para segurança de sua conta insira o usuario e senha");
            abrir.Show();
        }

        private void btnSonicRiders_Click(object sender, EventArgs e)
        {
            botaoSonic = true;

            string nome = "Sonic Riders";

            Autenticacao abrir = new Autenticacao();
            MessageBox.Show("Para segurança de sua conta insira o usuario e senha");
            abrir.Show();
        }
    }
}
