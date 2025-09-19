using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CRUD
{
    public partial class frmCadastrodeClientes : Form
    {

        //Conexão Com o banco de dados MySql

        MySqlConnection Conexao;
        string data_source = "datasource=localhost; username=root; password=; database=db_cadastro";

        private int? codigo_cliente = null;

        public frmCadastrodeClientes()
        {
            InitializeComponent();

            //Configuração Inicial do lIstview para exibição do dados de cliente

            lstCliente.View = View.Details;                 // Define a visualização como detalhes
            lstCliente.LabelEdit = true;                   // Permite a edição dos rótulos
            lstCliente.AllowColumnReorder = true;         // Permite reordenar as colunas
            lstCliente.FullRowSelect = true;             // Seleciona a linha inteira ao clicar
            lstCliente.GridLines = true;                // Exibe linhas de grade

            // Definindo as colunas da listview

            lstCliente.Columns.Add("Codigo", 100, HorizontalAlignment.Left); //Coluna de Código
            lstCliente.Columns.Add("Nome Completo", 200, HorizontalAlignment.Left); //Coluna de Nome
            lstCliente.Columns.Add("Nome Social", 200, HorizontalAlignment.Left); //Coluna de Nome Social
            lstCliente.Columns.Add("E-mail", 240, HorizontalAlignment.Left); //Coluna de E-mail
            lstCliente.Columns.Add("CPF", 200, HorizontalAlignment.Left); //Coluna de CPF

            //Carrega os dados do clientes na interface

            carregar_cliente();

        }

        private void carregar_clientes_com_query(string query)
        {
            try
            {
                // Cria a Conexão com banco de dados

                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                // Executa a consulta SQL Fornecida

                MySqlCommand cmd = new MySqlCommand(query, Conexao);

                // Se a consulta contém o parâmetro @q, adiciona o valor da caixa de pesquisa

                if (query.Contains("@q"))
                {
                    cmd.Parameters.AddWithValue("@q", "%" + txtBuscar.Text + "%");
                }

                // Excuta o Comando e obtém os resultados

                MySqlDataReader reader = cmd.ExecuteReader();

                // Limpa os intens existentes no ListView antes de adicionar novos

                lstCliente.Items.Clear();

                // Preenche a Listview com os dados do cliente

                while (reader.Read())
                {
                    // Cria uma linha para cada clientes com os dados retornados da consulta
                    string[] row =
                    {
                        Convert.ToString(reader.GetInt32(0)), // Codigo
                        reader.GetString(1),                  // Nome completo
                        reader.GetString(2),                  // Nome social
                        reader.GetString(3),                  // E-mail
                        reader.GetString(4),                  // CPF
                    };

                    // Adiciona a linha ao listview

                    lstCliente.Items.Add(new ListViewItem(row));
                }
            }


            catch (MySqlException ex)
            {
                // Trata Erros relacionados ao Mysql

                MessageBox.Show("Erro" + ex.Number + " ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {

                // Trata erros de outros tipos não relacioanados ao Database

                MessageBox.Show("Ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                //Garante que a conexão com o banco será fechada, mesmo se ocorrer erro

                if (Conexao != null && Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }

            }
        }

        // Método para carregar todos os clientes no ListView (usando uma consulta sem parâmetros)
        private void carregar_cliente()
        {
            string query = "SELECT * FROM dadosdocliente ORDER BY idcliente DESC";
            carregar_clientes_com_query(query);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //Validação de campos obrigatórios

                if (string.IsNullOrEmpty(txtNomeCompleto.Text.Trim()) ||
                    string.IsNullOrEmpty(txtEmail.Text.Trim()) ||
                    string.IsNullOrEmpty(txtCPF.Text.Trim()))
                {
                    MessageBox.Show("Todos os campos devem ser preechidos.",
                                    "Validação",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                    return; //Impede o proseeguimento se algum campo estiver vazio
                }

                ////Validação do CPF

                //string cpf = txtCPF.Text.Trim();

                //if (!isValidCPFLength(cpf))
                //{
                //    MessageBox.Show("CPF inválido. Certifique-se de que o CPF tenha 11 digítos Numéricos.",
                //                    "Validação",
                //                     MessageBoxButtons.OK,
                //                     MessageBoxIcon.Warning);
                //    return; //Impede o prosseguimento se o CPF for inválido
                //}

                //Cria conexão com banco de dados

                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                //Comando SQL para inserir um novo cliente no banco de dados

                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Conexao
                };

                cmd.Prepare();

                if (codigo_cliente == null)
                {
                    // Insert

                    cmd.CommandText = "INSERT INTO dadosdocliente(nomecompleto, nomesocial, email, cpf)" +
                        "VALUES(@nomecompleto, @nomesocial, @email, @cpf)";

                    // Adiciona os parâmetros com os dados do formulário

                    cmd.Parameters.AddWithValue("@nomecompleto", txtNomeCompleto.Text.Trim());
                    cmd.Parameters.AddWithValue("@nomesocial", txtNomeSocial.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@cpf", txtCPF.Text.Trim());

                    // Executa o comando de inserção no banco

                    cmd.ExecuteNonQuery();

                    // Executa o comando de inserção no banco

                    MessageBox.Show("Contato inserido com sucesso: ",
                                    "Sucesso",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                }
                else
                {
                    // Update

                    cmd.CommandText = $"UPDATE `dadosdocliente` SET " +
                    $"nomecompleto = @nomecompleto, " +
                    $"nomesocial = @nomesocial, " +
                    $"email = @email, " +
                    $"cpf = @cpf " +
                    $"WHERE idcliente = @codigo";

                    // Adiciona os parãmetros com os dados do formulário

                    cmd.Parameters.AddWithValue("@nomecompleto", txtNomeCompleto.Text.Trim());
                    cmd.Parameters.AddWithValue("@nomesocial", txtNomeSocial.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@cpf", txtCPF.Text.Trim());
                    cmd.Parameters.AddWithValue("@codigo", codigo_cliente);

                    // Excuta o comando de alteração no banco

                    cmd.ExecuteNonQuery();

                    // Executa o comando de Atualização no banco &&  Mensagem de sucesso para dados atualizados


                    MessageBox.Show($"Os dados com o código {codigo_cliente} foram alterados com sucesso!",
                                    "Sucesso",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                }

                codigo_cliente = null;

                // LImpa os campos após o sucesso

                txtNomeCompleto.Text = String.Empty;
                txtNomeSocial.Text = " ";
                txtEmail.Text = " ";
                txtCPF.Text = " ";

                // Recarrega os clientes no ListView

                carregar_cliente();

                // MUda para a aba de pesquisa
                tbControl.SelectedIndex = 1;

            }
            catch (MySqlException ex)
            {
                // Trata Erros relacionados ao Mysql

                MessageBox.Show("Erro" + ex.Number + " ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {

                // Trata erros de outros tipos não relacioanados ao Database

                MessageBox.Show("Ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                //Garante que a conexão com o banco será fechada, mesmo se ocorrer erro

                if (Conexao != null && Conexao.State == ConnectionState.Open)
                {
                    Conexao.Close();
                }

            }
        }



        // Função para validar o comprimento e formato de CPF

        //private bool isValidCPFLength(string cpf)
        //{
        //    //Remove todos os caracteres não númericos

        //    cpf = new string(cpf.Where(char.IsDigit).ToArray());

        //    // Verifica se o CPF tem exatamente 11 dígitos

        //    return cpf.Length == 11;
        //}

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM dadosdocliente WHERE idcliente LIKE @q OR nomecompleto LIKE @q OR nomesocial LIKE @q ORDER BY idcliente DESC";
            carregar_clientes_com_query(query);
        }

        private void lstCliente_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection clientesdaselecao = lstCliente.SelectedItems;

            foreach (ListViewItem item in clientesdaselecao)
            {
                codigo_cliente = Convert.ToInt32(item.SubItems[0].Text);

                MessageBox.Show("Código de clientes: " + codigo_cliente.ToString(),
                                "Código Selecionado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                txtNomeCompleto.Text = item.SubItems[1].Text;
                txtNomeSocial.Text = item.SubItems[2].Text;
                txtEmail.Text = item.SubItems[3].Text;
                txtCPF.Text = item.SubItems[4].Text;
            }
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            codigo_cliente = null;

            // LImpa os campos após o sucesso

            txtNomeCompleto.Text = String.Empty;
            txtNomeSocial.Text = " ";
            txtEmail.Text = " ";
            txtCPF.Text = " ";

            txtNomeCompleto.Focus();

        }

        private void nepalform_load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }

        private void gradientSideBarPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
