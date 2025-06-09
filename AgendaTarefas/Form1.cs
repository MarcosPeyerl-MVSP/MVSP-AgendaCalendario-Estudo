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
        int contarTarefas = 0;
        string description = string.Empty;
        int contPriority = 0;
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

            if (contarTarefas == 0) lblPorcento.Text = "00%";
            else if (contarTarefas != 100 || contarTarefas != 0) lblPorcento.Text = ((cont * 100) / contarTarefas).ToString("00") + "%";
            else lblPorcento.Text = ((cont * 100) / contarTarefas).ToString("000") + "%";
        }

        

        private void btnInserir_Click(object sender, EventArgs e)
        {
            
            if (txtTarefas.Text != string.Empty)
            {
                if (txtDescription.Text == string.Empty)
                {
                    MessageBox.Show("Description is EMPTY", "Atention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (contPriority == 0)
                {
                    MessageBox.Show("No priority", "Atention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                description = txtDescription.Text;
                clbTarefas.Items.Add(txtTarefas.Text);
                txtTarefas.Text = string.Empty;
                txtDescription.Text = string.Empty;
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
                    DialogResult Resp = MessageBox.Show("Remove: " + txtTarefas.Text, "Atention", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (Resp == DialogResult.Yes)
                    {
                        clbTarefas.Items.Remove(txtTarefas.Text);
                        txtTarefas.Text = string.Empty;
                        contarTarefas--;
                        atalizarTarefa(null, null);
                        txtTarefas.Focus();
                        return;
                    }
                }

                if (clbTarefas.SelectedItem != null)
                {
                    DialogResult Resp = MessageBox.Show("Remove: " + clbTarefas.SelectedItem.ToString(), "Atention", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
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

        private void btnLimparDescription_Click(object sender, EventArgs e)
        {
            DialogResult Resp = MessageBox.Show("Wanna Clear the description?", "Atention", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (Resp == DialogResult.Yes)
            {
                txtDescription.Text = string.Empty;
            }
              
        }

        private void btnPriority_Click(object sender, EventArgs e)
        {
            

            if(contPriority == 0)
            {
                btnPriorityLabel.Text = "LOW";
                btnPriorityLabel.BackColor = Color.LightGreen;
                btnPriorityLabel.FlatAppearance.BorderColor = Color.Green;
                contPriority = 1;
            }
            else if (contPriority == 1)
            {
                btnPriorityLabel.Text = "MEDIUM";
                btnPriorityLabel.BackColor = Color.LightYellow;
                btnPriorityLabel.FlatAppearance.BorderColor = Color.Yellow;
                contPriority = 3;
            }
            else if (contPriority == 3)
            {
                btnPriorityLabel.Text = "HIGH";
                btnPriorityLabel.BackColor = Color.Salmon;
                btnPriorityLabel.FlatAppearance.BorderColor = Color.Red;
                contPriority = 0;
            }
        }

        private void btnChosePriority_Click(object sender, EventArgs e)
        {
            DialogResult Resp = MessageBox.Show("Wanna chose " + btnPriorityLabel.Text + " priority?", "Atention", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (Resp == DialogResult.Yes)
            {
                btnPriority.Visible = false;
                btnChosePriority.Visible = false;
            }
               
        }
    }
}
