using System;
using System.Collections;
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
    public partial class Lista : Form
    {
        List<Empresa> emps = new List<Empresa>();
        public Lista(List<Empresa> lista)
        {
            
            emps = lista;
            InitializeComponent();
            
                    dataGridView1.DataSource = null;
                    dataGridView1.Refresh();
                    dataGridView1.DataSource = emps;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 menu = new Form1(emps);
            this.Hide();
            menu.ShowDialog();
        }
    }
}
