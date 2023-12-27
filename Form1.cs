using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfa_SistemaGestao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblNomeF.Visible = false;
            tbxNomeF.Visible = false;
            GerarGradeListViewPf();
            GerarGradeListViewPj();
        }

        private void rbPessoaf_CheckedChanged(object sender, EventArgs e)
        {
            mtbCpfCnpj.Mask = "000,000,000-00";

            lblCpfCnpj.Text = "CPF: ";
            lblFilhosFuncionarios.Text = "Qtd Filhos: ";
            lblSalarioFaturamento.Text = "Salários: ";

            lblNomeF.Visible = false;
            tbxNomeF.Visible = false;

        }

        private void rbPessoaj_CheckedChanged(object sender, EventArgs e)
        {
            mtbCpfCnpj.Mask = "00,000,000/0000-00";

            lblCpfCnpj.Text = "CNPJ: ";
            lblFilhosFuncionarios.Text = "Qtd Funcionários: ";
            lblSalarioFaturamento.Text = "Faturamento: ";

            lblNomeF.Visible = true;
            tbxNomeF.Visible = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var recebeValidacao = ValidaInfo();
            if (rbPessoaf.Checked == true)
            {
                PessoaFisica pessoaFisica = new PessoaFisica(mtbCpfCnpj.Text, int.Parse(tbxFilhosFuncionarios.Text), double.Parse(tbxSalarioFaturamento.Text), tbxNome.Text, tbxCidade.Text);

                string[] clientePf = new string[6];

                clientePf[0] = pessoaFisica.Nome;
                clientePf[1] = pessoaFisica.Cpf;
                clientePf[2] = pessoaFisica.Cidade;
                clientePf[3] = pessoaFisica.QtdFilhos.ToString();
                clientePf[4] = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", pessoaFisica.Salario);
                clientePf[5] = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", pessoaFisica.CalcCredito());

                lvPf.Items.Add(new ListViewItem(clientePf));

                MessageBox.Show("Dados cadastrados com sucesso!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
            }
            else if (rbPessoaj.Checked == true)
            {
                PessoaJuridica pessoaJuridica = new PessoaJuridica(mtbCpfCnpj.Text, int.Parse(tbxFilhosFuncionarios.Text), double.Parse(tbxSalarioFaturamento.Text), tbxNomeF.Text, tbxNome.Text, tbxCidade.Text);

                string[] clientePj = new string[7];

                clientePj[0] = pessoaJuridica.Nome;
                clientePj[1] = pessoaJuridica.Cnpj;
                clientePj[2] = pessoaJuridica.Cidade;
                clientePj[3] = pessoaJuridica.QtdFuncionarios.ToString();
                clientePj[4] = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", pessoaJuridica.Faturamento);
                clientePj[5] = string.Format(CultureInfo.GetCultureInfo("pt-BR"), "{0:C}", pessoaJuridica.CalcCredito());
                clientePj[6] = pessoaJuridica.NomeFantasia;

                lvPj.Items.Add(new ListViewItem(clientePj));

                MessageBox.Show("Dados cadastrados com sucesso!", Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();

            }
        }
            
        private void btnLimpar_Click(object sender, EventArgs e)
        {
                Limpar();
        }

        private void MensagemBotao(string nomeLabel)
        {
            MessageBox.Show($"Você deve informar {nomeLabel}!", Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private bool ValidaInfo()
        {
            var validaInfo = true;

            if (tbxNome.Text.Trim() == string.Empty)
            {
              MensagemBotao(lblNome.Text);  
            }

         return validaInfo;
        }
        private void Limpar()
        {
            mtbCpfCnpj.Text = string.Empty;
            tbxNome.Text = string.Empty;
            tbxCidade.Text = string.Empty;
            tbxFilhosFuncionarios.Text = string.Empty;
            tbxSalarioFaturamento.Text = string.Empty;
            tbxNomeF.Text = string.Empty;
        }

        public void GerarGradeListViewPf()
        {
            lvPf.Columns.Add("Nome", 150).TextAlign = HorizontalAlignment.Center;
            lvPf.Columns.Add("CPF", 100).TextAlign = HorizontalAlignment.Center;
            lvPf.Columns.Add("Cidade", 100).TextAlign = HorizontalAlignment.Center;
            lvPf.Columns.Add("Qtd Filhos", 60).TextAlign = HorizontalAlignment.Center;
            lvPf.Columns.Add("Salário", 80).TextAlign = HorizontalAlignment.Center;
            lvPf.Columns.Add("Crédito", 80).TextAlign = HorizontalAlignment.Center;
            lvPf.View = View.Details;
        }

        public void GerarGradeListViewPj()
        {
            lvPj.Columns.Add("Nome", 150).TextAlign = HorizontalAlignment.Center;
            lvPj.Columns.Add("CNPJ", 100).TextAlign = HorizontalAlignment.Center;
            lvPj.Columns.Add("Cidade", 100).TextAlign = HorizontalAlignment.Center;
            lvPj.Columns.Add("Qtd Funcionários", 60).TextAlign = HorizontalAlignment.Center;
            lvPj.Columns.Add("Faturamento", 80).TextAlign = HorizontalAlignment.Center;
            lvPj.Columns.Add("Crédito", 80).TextAlign = HorizontalAlignment.Center;
            lvPj.Columns.Add("Nome Fantasia", 130).TextAlign = HorizontalAlignment.Center;
            lvPj.View = View.Details;
        }

        private void TeclaPressionada(KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), "^[a-zA-Z \bA|\x01]*$"))
                e.Handled = true;
        }

        private void PerdeuFoco(TextBox campo)
        {
            Regex regex = new Regex(@"[ ]{2,}");
            // Remove multiplos espaços
            campo.Text = regex.Replace(tbxNome.Text, @" ");
            campo.Text.Trim();
            //Aplica Title Case
            campo.Text = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(tbxNome.Text.ToLower());
        }
        private void tbxNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            TeclaPressionada(e);
        }

        
        private void tbxNome_Leave(object sender, EventArgs e)
        {
            PerdeuFoco(tbxNome); 
        }

        private void tbxCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            TeclaPressionada(e);
        }

        private void tbxCidade_Leave(object sender, EventArgs e)
        {
            PerdeuFoco(tbxCidade);
        }

        private void tbxSalarioFaturamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), "^[0-9,\bA|\x01]*$"))
                e.Handled = true;
        }

        private void tbxFilhosFuncionarios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), "^[0-9\bA|\x01]*$"))
                e.Handled = true;
        }

        private void btnSalvarCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog salvarCSVDialog = new SaveFileDialog
            {
                Filter = "Arquivos CSV (*csv)|*.csv",
                Title = "Salvar Dados do Usuário em CSV",
                FileName = "Dados"
            };

            if (salvarCSVDialog.ShowDialog() == DialogResult.OK)
            {
                var diretorio = Path.GetDirectoryName(salvarCSVDialog.FileName);
                var nomeArquivo = Path.GetFileName(salvarCSVDialog.FileName);
                var nomeArquivoSemExt = Path.GetFileNameWithoutExtension(salvarCSVDialog.FileName);
                var extArquivo = Path.GetExtension(salvarCSVDialog.FileName);
                ListViewToCSV(lvPf, Path.Combine(diretorio, $"{nomeArquivoSemExt}_PF{extArquivo}"));
                ListViewToCSV(lvPj, Path.Combine(diretorio, $"{nomeArquivoSemExt}_PJ{extArquivo}"));
                MessageBox.Show("Dados salvos com sucesso!!");
            }
        }

        private void ListViewToCSV(ListView list, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                try
                {
                    for (int i = 0; i < list.Columns.Count; i++)
                    {
                        writer.Write(list.Columns[i].Text);
                        if (i < list.Columns.Count - 1)
                        {
                            writer.Write("\t");
                        }
                    
                    }
                    writer.WriteLine();

                    foreach (ListViewItem item in list.Items)
                    {
                        for(int i = 0; i < item.SubItems.Count; i++)
                        {
                            writer.Write(item.SubItems[i].Text);
                            if (i < item.SubItems.Count - 1)
                            {
                                writer.Write("\t");
                            }
                        }
                        writer.WriteLine();
                    }

                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show($"Erro! Sem permisão pra acessar o arquivo!. {ex.Message}");
                }
                catch(IOException ex)
                {
                    MessageBox.Show($"Erro de Escrita. {ex.Message}");
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro: {ex.Message}");
                }
            }
        }
        private void btnAbrirCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrirCSVDialog = new OpenFileDialog
            {
                Filter = "Arquivo CSV (*.csv)|*.csv", 
                Title = "Importar Dados de CSV"
            };
            if (abrirCSVDialog.ShowDialog() == DialogResult.OK)
            {
                var nomeArquivo = Path.GetFileName(abrirCSVDialog.FileName);
                if (nomeArquivo.Contains("PF"))
                {
                    CSVToListView(lvPf, abrirCSVDialog.FileName);
                } 
                else if (nomeArquivo.Contains("PJ"))
                {
                    CSVToListView(lvPj, abrirCSVDialog.FileName);
                }
                else
                {
                    MessageBox.Show("Nome do arquivo inválido! (Precisa conter PF ou PJ)", 
                        "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        void CSVToListView(ListView listView, string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string headerLine = reader.ReadLine();
                    string[] headers = headerLine.Split('\t');

                    while (!reader.EndOfStream)
                    {
                        string dataLine = reader.ReadLine();
                        string[] data = dataLine.Split('\t');

                        ListViewItem item = new ListViewItem(data);
                        listView.Items.Add(item);
                    }
                }
            }
            
            catch(FileNotFoundException ex)
            {
                MessageBox.Show($"Arquivo não encontrado. {ex.Message}");
            }
            catch (IOException ex)
            {
                MessageBox.Show($"Erro de leitura. {ex.Message}");
            }

        }
    }
    }
