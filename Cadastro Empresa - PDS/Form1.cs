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
    public partial class Form1 : Form
    {
        List<Empresa> emps = new List<Empresa>();
        public Form1(List<Empresa> lista)
        {
            
            emps = lista;

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_cad_Click(object sender, EventArgs e)
        {
            CadastroEmp  a = new CadastroEmp(emps);
            this.Hide();
            a.ShowDialog();
        }

        private void bt_list_Click(object sender, EventArgs e)
        {
            Lista a = new Lista(emps);
            this.Hide();
            a.ShowDialog();
        }
    }
}
