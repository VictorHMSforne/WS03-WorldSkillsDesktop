using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WS03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void btnSair_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Paciente paciente = new Paciente();
            List<Paciente> pacientes = paciente.listapaciente();
            dgvPaciente.DataSource = pacientes;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                Paciente paciente = new Paciente();
                var quarto = paciente.quarto;
                if (paciente.RegistroRepetido(txtNomePaciente.Text) == true)
                {
                    paciente.listanome(txtNomePaciente.Text);
                    
                    MessageBox.Show("Paciente já está no quarto N° '" + quarto + "'");
                    txtNomePaciente.Text = string.Empty;
                    txtNomeDoutor.Text = string.Empty;
                    cbxTipoQuarto.Text = string.Empty;
                    txtNumeroQuarto.Text = string.Empty;
                }
                else if(paciente.ValidaQuarto(cbxTipoQuarto.Text.Trim(),quarto) == true)
                {
                    MessageBox.Show("O Limite de pacientes neste quarto foi atingido,tente em outro quarto");
                    txtNumeroQuarto.Text = string.Empty;
                    this.ActiveControl = txtNumeroQuarto;
                    return;
                }
                else
                {
                    var numero = Convert.ToInt32(txtNumeroQuarto.Text);
                    paciente.Inserir(txtNomePaciente.Text, txtNomeDoutor.Text, cbxTipoQuarto.Text, numero);
                    MessageBox.Show("Paciente cadastro com Sucesso!");
                    txtNomePaciente.Text = string.Empty;
                    txtNomeDoutor.Text = string.Empty;
                    cbxTipoQuarto.Text = string.Empty;
                    txtNumeroQuarto.Text = string.Empty;
                    List<Paciente> pacientes = paciente.listapaciente();
                    dgvPaciente.DataSource = pacientes;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(txtId.Text);
            try
            {
                Paciente paciente = new Paciente();
                if (paciente.RegistroRepetido(txtNomePaciente.Text) == true)
                {
                    paciente.listanome(txtNomePaciente.Text);
                    var quarto = paciente.quarto;
                    MessageBox.Show("Paciente já está no quarto N° '" + quarto + "'");
                    txtNomePaciente.Text = string.Empty;
                    txtNomeDoutor.Text = string.Empty;
                    cbxTipoQuarto.Text = string.Empty;
                    txtNumeroQuarto.Text = string.Empty;
                }
                else
                {
                    var numero = Convert.ToInt32(txtNumeroQuarto.Text);
                    paciente.Atualizar(Id, txtNomePaciente.Text, txtNomeDoutor.Text, cbxTipoQuarto.Text, numero);
                    MessageBox.Show("Paciente Atualizado com Sucesso!");
                    txtId.Text = string.Empty;
                    txtNomePaciente.Text = string.Empty;
                    txtNomeDoutor.Text = string.Empty;
                    cbxTipoQuarto.Text = string.Empty;
                    txtNumeroQuarto.Text = string.Empty;
                    List<Paciente> pacientes = new List<Paciente>();
                    dgvPaciente.DataSource = pacientes;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Erro", er.Message);
            }
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(txtId.Text);
            try
            {
                Paciente paciente = new Paciente();
                paciente.Excluir(Id);
                MessageBox.Show("Paciente Excluído com Sucesso!");
                txtId.Text = string.Empty;
                txtNomePaciente.Text = string.Empty;
                txtNomeDoutor.Text = string.Empty;
                cbxTipoQuarto.Text = string.Empty;
                txtNumeroQuarto.Text = string.Empty;
                List<Paciente> pacientes = new List<Paciente>();
                dgvPaciente.DataSource = pacientes;

            }
            catch (Exception er)
            {
                MessageBox.Show("Erro", er.Message);
            }
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                if (txtId.Text == "")
                {
                    MessageBox.Show("Por favor Digite um Id para Localizar o Paciente!");
                }
                else
                {
                    var Id = Convert.ToInt32(txtId.Text);
                    Paciente paciente = new Paciente();
                    paciente.Localiza(Id);
                    txtNomePaciente.Text = paciente.nome_paciente.ToString();
                    txtNomeDoutor.Text = paciente.nome_doutor.ToString();
                    cbxTipoQuarto.Text = paciente.tipo_quarto.ToString();
                    txtNumeroQuarto.Text = paciente.quarto.ToString();
                }
            }
            catch (Exception er)
            {
                MessageBox.Show("Erro", er.Message);
            }
        }

        private void btnLocalizarQuarto_Click_1(object sender, EventArgs e)
        {
            
            try
            {
                if (txtNumeroQuarto.Text == "")
                {
                    MessageBox.Show("Por favor Digite um Id para Localizar o Paciente!");
                }
                else
                {
                    var quarto = Convert.ToInt32(txtNumeroQuarto.Text);
                    Paciente paciente = new Paciente();
                    paciente.LocalizaQuarto(quarto);
                    txtNomePaciente.Text = paciente.nome_paciente.ToString();
                    txtNomeDoutor.Text = paciente.nome_doutor.ToString();
                    cbxTipoQuarto.Text = paciente.tipo_quarto.ToString();
                    txtNumeroQuarto.Text = paciente.quarto.ToString();
                    List<Paciente> pacientes = paciente.listaquarto(quarto);
                    dgvPaciente.DataSource = pacientes;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro" );
            }
        }
    }
}
