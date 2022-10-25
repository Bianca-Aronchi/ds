using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bigui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        List<Aluno> AlunosLindos = new List<Aluno>();
        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            {

                Aluno aluno = new Aluno();
               
                aluno.ra = Convert.ToDouble(txtRA.Text);
                aluno.Nome = txtNome.Text;
                aluno.n1 = Convert.ToDouble(txtN1.Text);
                aluno.n2 = Convert.ToDouble(txtN2.Text);
                aluno.n3 = Convert.ToDouble(txtN3.Text);
                aluno.n4 = Convert.ToDouble(txtN4.Text);
                aluno.Calcmedia();
                aluno.defSituacao();

                bool existe = false;
                foreach (Aluno p in AlunosLindos)
                {
                    if (p.ra == aluno.ra)
                    {
                        existe = true;
                    }
                }
                if (!existe)
                {
                    AlunosLindos.Add(aluno);
                    MessageBox.Show("ok!!!");
                    dataGridView1.Rows.Add(aluno.ra, aluno.Nome, aluno.n1, aluno.n2, aluno.n3, aluno.n4, aluno.media.ToString(), aluno.situacao);
                }
                else
                {
                    MessageBox.Show("aluno já existente!!!");
                }
            }
        }
    }
}
   
