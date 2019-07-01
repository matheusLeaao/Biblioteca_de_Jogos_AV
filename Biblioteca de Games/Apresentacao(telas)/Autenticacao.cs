﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using Biblioteca_de_Games.Conexoes;
using Biblioteca_de_Games.Apresentacao_telas_;

namespace Biblioteca_de_Games.Apresentacao_telas_
{
    public partial class Autenticacao : Form
    {
        public Autenticacao()
        {
            InitializeComponent();
        }

        string nomeJogo;
        string usuario;

        //verifica se o usuario digitado no autenticacao está correto, se estiver ele aplica o jogo a bilioteca do usuario
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Loja loja = new Loja();
            
            
            //instanceia o Form Loja para receber a lista dos jogos no btnLogin_Click
            Loja lista = new Loja();
            
            
            
            //instanceia a classe LoginCadastro para receber as variaveis login e senha para a verificação
            Conexoes.LoginCadastro objusuario = new Conexoes.LoginCadastro();
            objusuario.login = txtLogin.Text;
            objusuario.senha = txtSenha.Text;

            //abre a conexão com o banco instanciando o ConexaoDB para o objconexao e executando o  comando pgsqlConnection
            NpgsqlConnection pgsqlConnection = null;
            ConexaoDB objconexao = new ConexaoDB();
            pgsqlConnection = objconexao.getConexao();

            pgsqlConnection.Open();

            
            //forçando qual deve ser o jogo
            string naruto = "Naruto Shippuden Ultimate ninja Storm 4";

            /*if (objusuario.logar(objusuario.login, objusuario.senha) == true)
            {
                //if()
                string sql = "INSERT INTO tbl_tem(fk_usuario_login, fk_jogo_nome) VALUES " + "('" + objusuario.login + "', '" + naruto+ "');";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                NpgsqlDataReader dr1 = cmd.ExecuteReader();
                dr1.Close();

                MessageBox.Show("Jogo Inserido na  Biblioteca ");

                Close();



            }
            else
            {

                MessageBox.Show("Usuario incorreto! /n Tente novamente");

            } */

            if (objusuario.logar(objusuario.login, objusuario.senha) == true)
            {


                if (loja.botaoNaruto == true)
                {
                    string nome = "Naruto Shippuden Ultimate ninja Storm 4";

                    string sql = "INSERT INTO tbl_tem(fk_usuario_login, fk_jogo_nome) VALUES " + "('" + objusuario.login + "', '" + nome + "');";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                    NpgsqlDataReader dr1 = cmd.ExecuteReader();
                    dr1.Close();

                    MessageBox.Show("Jogo Inserido na  Biblioteca ");

                    Close();
                }
                else if (loja.botaoGta == true)
                {
                    string nome = "Grand Theft Auto 5";

                    string sql = "INSERT INTO tbl_tem(fk_usuario_login, fk_jogo_nome) VALUES " + "('" + objusuario.login + "', '" + nome + "');";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                    NpgsqlDataReader dr1 = cmd.ExecuteReader();
                    dr1.Close();

                    MessageBox.Show("Jogo Inserido na  Biblioteca ");

                    Close();
                }
                else if (loja.botaoPokemon == true)
                {
                    string nome = "Pokémon Fire Red";

                    string sql = "INSERT INTO tbl_tem(fk_usuario_login, fk_jogo_nome) VALUES " + "('" + objusuario.login + "', '" + nome + "');";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                    NpgsqlDataReader dr1 = cmd.ExecuteReader();
                    dr1.Close();

                    MessageBox.Show("Jogo Inserido na  Biblioteca ");

                    Close();
                }
                else if (loja.botaoFF == true)
                {
                    string nome = "Final Fantasy XV";

                    string sql = "INSERT INTO tbl_tem(fk_usuario_login, fk_jogo_nome) VALUES " + "('" + objusuario.login + "', '" + nome + "');";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                    NpgsqlDataReader dr1 = cmd.ExecuteReader();
                    dr1.Close();

                    MessageBox.Show("Jogo Inserido na  Biblioteca ");

                    Close();
                }
                else if (loja.botaoGta == true)
                {
                    string nome = "Grand Theft Auto 5";

                    string sql = "INSERT INTO tbl_tem(fk_usuario_login, fk_jogo_nome) VALUES " + "('" + objusuario.login + "', '" + nome + "');";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                    NpgsqlDataReader dr1 = cmd.ExecuteReader();
                    dr1.Close();

                    MessageBox.Show("Jogo Inserido na  Biblioteca ");

                    Close();
                }
                else if (loja.botaoSonic == true)
                {
                    string nome = "Sonic Rider";

                    string sql = "INSERT INTO tbl_tem(fk_usuario_login, fk_jogo_nome) VALUES " + "('" + objusuario.login + "', '" + nome + "');";
                    NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                    NpgsqlDataReader dr1 = cmd.ExecuteReader();
                    dr1.Close();

                    MessageBox.Show("Jogo Inserido na  Biblioteca ");

                    Close();
                }
                else if (loja.botaoBO4 == true)
                {
                    string nome = "Call of Duty Black Ops ";
                    if (verificaJogoBiblioteca(objusuario.login, nome) == true)
                    {
                        string sql = "INSERT INTO tbl_tem(fk_usuario_login, fk_jogo_nome) VALUES " + "('" + objusuario.login + "', '" + nome + "');";
                        NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

                        NpgsqlDataReader dr1 = cmd.ExecuteReader();
                        dr1.Close();

                        MessageBox.Show("Jogo Inserido na  Biblioteca ");

                        Close();
                    }
                    else
                    {
                        MessageBox.Show("jogo já inserido na biblioteca.");
                    }
                }

            }
            else
            {
                MessageBox.Show("Usuario não encontrado!");
            }
            
        }

        public bool verificaJogoBiblioteca(string nomeJogo, string usuario)
        {
            //abre a conexão com o banco instanciando o ConexaoDB para o objconexao e executando o  comando pgsqlConnection
            NpgsqlConnection pgsqlConnection = null;
            ConexaoDB objconexao = new ConexaoDB();
            pgsqlConnection = objconexao.getConexao();

            pgsqlConnection.Open();

            string sql = "select * from tbl_tem where fk_usuario_login='" + usuario + "' and fk_jogo_nome='" + nomeJogo + "';";
            //atribui ao cmd a string 'sql' e a conexão a ser utilizada
            NpgsqlCommand cmd = new NpgsqlCommand(sql, pgsqlConnection);

            //exacuta-se o sql e declara um DataReader para receber a matriz de valores
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {


                if (usuario == dr["fk_usuario_login"].ToString() && nomeJogo == dr["fk_jogo_nome"].ToString())
                {

                    return true;
                }
                else
                {
                    return false;

                }



            }
            else
            {

                return false;
            }
        }

    }
}
    

