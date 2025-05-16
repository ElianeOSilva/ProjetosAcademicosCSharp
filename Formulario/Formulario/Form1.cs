using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void nota1_Click(object sender, EventArgs e)
        {

        }

        private void rb_nao_CheckedChanged(object sender, EventArgs e)
        {
            notaSPA.Visible = false;
            tb_notaSPA.Visible = false;
        }

        private void rb_sim_CheckedChanged(object sender, EventArgs e)
        {
            notaSPA.Visible = true;
            tb_notaSPA.Visible = true;
        }

        private void box_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_calcular_Click(object sender, EventArgs e)
        {
            float nota1 = float.Parse(tb_nota1.Text);
            float nota2 = float.Parse(tb_nota2.Text);
            float media;

            if (rb_sim.Checked)
            {
                float spa = float.Parse(tb_notaSPA.Text);
                media = (nota1 + 2 * nota2 + spa) / 4;
            }
            else
            {
                media = (nota1 + 2 * nota2) / 3;
            }

            string disciplina = tb_disciplina.SelectedItem.ToString();

            box.Items.Add("Aluno: " + tb_nome.Text + " Disciplina: " + disciplina +
" Média: " + media);
            
            tb_nome.Clear();
            tb_nota1.Clear();
            tb_nota2.Clear();
            tb_notaSPA.Clear();
            tb_nome.Focus();
            rb_nao.Checked = true;
        }

        private void bt_limpar_Click(object sender, EventArgs e)
        {
            box.Items.Clear();
            tb_nome.Focus();
        }

        private void bt_remover_Click(object sender, EventArgs e)
        {
            int selecionado = box.SelectedIndex;

            if (selecionado >= 0) // Verifica se algum item está selecionado
            {
                box.Items.RemoveAt(selecionado);
            }
            else
            {
                MessageBox.Show("Selecione um item para remover.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

