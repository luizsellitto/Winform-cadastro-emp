using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_Empresa___PDS
{
    public partial class CadastroEmp : Form
    {
        List<Empresa> emps = new List<Empresa>();
        public CadastroEmp(List<Empresa> lista)
        {
            
            emps = lista;
            InitializeComponent();
        }

        private void CadastroEmp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1(emps);
            this.Hide();
            menu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cnpj = maskedTextBox1.Text;
            string razao = textBox1.Text;
            string nfant = textBox2.Text;
            string situacao = comboBox1.Text;
            string regime;
            string datadeInicio = dateTimePicker1.Text;
            string telefone = maskedTextBox2.Text;
            double capital = Double.Parse(textBox3.Text);
            string estado = comboBox2.Text;
            string cidade = textBox4.Text;
            string bairro = textBox5.Text;
            string rua = textBox6.Text;
            double numero = Double.Parse(textBox7.Text);
            string tipo;
            string porte;
            string natureza = comboBox3.Text;
            string nomeProp = textBox8.Text;
            string cpfProp = textBox9.Text;
            if (radioButton1.Checked == true)
            {
                regime = "Simples Nacional";
            }
            else if (radioButton2.Checked == true) { regime = "Lucro Presumido"; }
            else if (radioButton3.Checked == true) { regime = "Lucro Real"; }
            else { regime = "";}

            if (radioButton6.Checked == true) { tipo = "Matriz"; }
            else if (radioButton4.Checked == true) { tipo = "Filial"; }
            else
            {
                tipo = "";
            }

            if (radioButton7.Checked == true) { porte = "Pequeno"; }
            else if (radioButton5.Checked == true) { porte = "Médio"; }
            else if (radioButton8.Checked == true) { porte = "Grande"; }
            else
            {
                porte = "";
            }

            Empresa p = new Empresa(cnpj, razao, nfant, situacao, regime, datadeInicio, telefone, capital, estado, cidade, bairro, rua, numero, tipo, porte, natureza, nomeProp, cpfProp);
            emps.Add(p);
            Form1 menu = new Form1(emps);
            this.Hide();
            menu.ShowDialog();
        }
    }
}
