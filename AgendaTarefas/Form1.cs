using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaTarefas
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            clbTarefas.ItemCheck += atalizarTarefa;
        }

        private void atalizarTarefa(object sender, ItemCheckEventArgs e)
        {
            int cont = clbTarefas.CheckedItems.Count;
            pgrBarra.Maximum = contarTarefas;

            if(e != null)
            {
                if (e.NewValue == CheckState.Checked) cont++;
                else cont--;
            }            

            pgrBarra.Value = cont;
            lblPorcento.Text = ((cont * 100) / contarTarefas).ToString("000") + "%";
        }

        int contarTarefas = 0;

        private void btnInserir_Click(object sender, EventArgs e)
        {
            if(txtTarefas.Text != string.Empty)
            {                
                clbTarefas.Items.Add(txtTarefas.Text);
                txtTarefas.Text = string.Empty;
                contarTarefas++;
                atalizarTarefa(null, null);
                txtTarefas.Focus();
                
            }            
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (clbTarefas.Items.Count > 0)
            {
                if (txtTarefas.Text != string.Empty)
                {
                    clbTarefas.Items.Remove(txtTarefas.Text);
                    txtTarefas.Text = string.Empty;
                    contarTarefas--;
                    atalizarTarefa(null, null);
                    txtTarefas.Focus();
                    return;
                }

                if (clbTarefas.SelectedItem != null)
                {
                    DialogResult Resp = MessageBox.Show("Remover", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (Resp == DialogResult.Yes)
                    {
                        clbTarefas.Items.Remove(clbTarefas.SelectedItem);
                        txtTarefas.Text = string.Empty;
                        contarTarefas--;
                        atalizarTarefa(null, null);
                        txtTarefas.Focus();
                        return;
                    }
                }
            }            
        }

        private void txtTarefas_KeyPress(object sender, KeyPressEventArgs e)
        {
           if( e.KeyChar == 13) btnInserir_Click(sender, e);
        }

        private void txtTarefas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) btnRemover_Click(sender, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHorario.Text = DateTime.Now.ToString(" HH : mm : ss");
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {            
            DateTime dataAtual = DateTime.Now;            
            lblData.Text = dataAtual.ToString("dd/MM/yyyy");
        }
    }
}
