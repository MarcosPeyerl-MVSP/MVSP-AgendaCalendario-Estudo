namespace AgendaTarefas
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.clbTarefas = new System.Windows.Forms.CheckedListBox();
            this.pgrBarra = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDescription = new System.Windows.Forms.TabPage();
            this.btnLimparDescription = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.tabPriority = new System.Windows.Forms.TabPage();
            this.btnChosePriority = new System.Windows.Forms.Button();
            this.btnPriority = new System.Windows.Forms.Button();
            this.btnPriorityLabel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTarefas = new System.Windows.Forms.TextBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.lblPorcento = new System.Windows.Forms.Label();
            this.lblHorario = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblData = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabDescription.SuspendLayout();
            this.tabPriority.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // clbTarefas
            // 
            this.clbTarefas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.clbTarefas.CheckOnClick = true;
            this.clbTarefas.FormattingEnabled = true;
            this.clbTarefas.Location = new System.Drawing.Point(11, 55);
            this.clbTarefas.Name = "clbTarefas";
            this.clbTarefas.Size = new System.Drawing.Size(185, 349);
            this.clbTarefas.TabIndex = 0;
            // 
            // pgrBarra
            // 
            this.pgrBarra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pgrBarra.Location = new System.Drawing.Point(10, 22);
            this.pgrBarra.Name = "pgrBarra";
            this.pgrBarra.Size = new System.Drawing.Size(549, 24);
            this.pgrBarra.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtTarefas);
            this.panel1.Controls.Add(this.btnRemover);
            this.panel1.Controls.Add(this.btnInserir);
            this.panel1.Location = new System.Drawing.Point(202, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 349);
            this.panel1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDescription);
            this.tabControl1.Controls.Add(this.tabPriority);
            this.tabControl1.Location = new System.Drawing.Point(22, 52);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(367, 255);
            this.tabControl1.TabIndex = 4;
            // 
            // tabDescription
            // 
            this.tabDescription.BackColor = System.Drawing.Color.DarkGray;
            this.tabDescription.Controls.Add(this.btnLimparDescription);
            this.tabDescription.Controls.Add(this.txtDescription);
            this.tabDescription.Location = new System.Drawing.Point(4, 22);
            this.tabDescription.Name = "tabDescription";
            this.tabDescription.Padding = new System.Windows.Forms.Padding(3);
            this.tabDescription.Size = new System.Drawing.Size(359, 229);
            this.tabDescription.TabIndex = 0;
            this.tabDescription.Text = "Description";
            // 
            // btnLimparDescription
            // 
            this.btnLimparDescription.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimparDescription.FlatAppearance.BorderSize = 2;
            this.btnLimparDescription.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLimparDescription.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnLimparDescription.Location = new System.Drawing.Point(140, 193);
            this.btnLimparDescription.Name = "btnLimparDescription";
            this.btnLimparDescription.Size = new System.Drawing.Size(75, 29);
            this.btnLimparDescription.TabIndex = 1;
            this.btnLimparDescription.Text = "Clear";
            this.btnLimparDescription.UseVisualStyleBackColor = true;
            this.btnLimparDescription.Click += new System.EventHandler(this.btnLimparDescription_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(6, 6);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(350, 181);
            this.txtDescription.TabIndex = 0;
            // 
            // tabPriority
            // 
            this.tabPriority.BackColor = System.Drawing.Color.DarkGray;
            this.tabPriority.Controls.Add(this.btnChosePriority);
            this.tabPriority.Controls.Add(this.btnPriority);
            this.tabPriority.Controls.Add(this.btnPriorityLabel);
            this.tabPriority.Location = new System.Drawing.Point(4, 22);
            this.tabPriority.Name = "tabPriority";
            this.tabPriority.Padding = new System.Windows.Forms.Padding(3);
            this.tabPriority.Size = new System.Drawing.Size(359, 229);
            this.tabPriority.TabIndex = 1;
            this.tabPriority.Text = "Priority";
            // 
            // btnChosePriority
            // 
            this.btnChosePriority.BackColor = System.Drawing.Color.White;
            this.btnChosePriority.FlatAppearance.BorderSize = 2;
            this.btnChosePriority.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnChosePriority.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnChosePriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChosePriority.Location = new System.Drawing.Point(192, 182);
            this.btnChosePriority.Name = "btnChosePriority";
            this.btnChosePriority.Size = new System.Drawing.Size(152, 41);
            this.btnChosePriority.TabIndex = 2;
            this.btnChosePriority.Text = "Chose";
            this.btnChosePriority.UseVisualStyleBackColor = false;
            this.btnChosePriority.Click += new System.EventHandler(this.btnChosePriority_Click);
            // 
            // btnPriority
            // 
            this.btnPriority.BackColor = System.Drawing.Color.White;
            this.btnPriority.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPriority.FlatAppearance.BorderSize = 2;
            this.btnPriority.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPriority.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnPriority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPriority.Location = new System.Drawing.Point(6, 182);
            this.btnPriority.Name = "btnPriority";
            this.btnPriority.Size = new System.Drawing.Size(152, 41);
            this.btnPriority.TabIndex = 1;
            this.btnPriority.Text = "Change";
            this.btnPriority.UseVisualStyleBackColor = false;
            this.btnPriority.Click += new System.EventHandler(this.btnPriority_Click);
            // 
            // btnPriorityLabel
            // 
            this.btnPriorityLabel.BackColor = System.Drawing.Color.White;
            this.btnPriorityLabel.Enabled = false;
            this.btnPriorityLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPriorityLabel.Location = new System.Drawing.Point(6, 6);
            this.btnPriorityLabel.Name = "btnPriorityLabel";
            this.btnPriorityLabel.Size = new System.Drawing.Size(347, 153);
            this.btnPriorityLabel.TabIndex = 0;
            this.btnPriorityLabel.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Task:";
            // 
            // txtTarefas
            // 
            this.txtTarefas.Location = new System.Drawing.Point(55, 26);
            this.txtTarefas.Name = "txtTarefas";
            this.txtTarefas.Size = new System.Drawing.Size(334, 20);
            this.txtTarefas.TabIndex = 2;
            this.txtTarefas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTarefas_KeyDown);
            this.txtTarefas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTarefas_KeyPress);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRemover.FlatAppearance.BorderColor = System.Drawing.Color.Brown;
            this.btnRemover.FlatAppearance.BorderSize = 2;
            this.btnRemover.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemover.Location = new System.Drawing.Point(253, 313);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(136, 29);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "Remove";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnInserir.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnInserir.FlatAppearance.BorderSize = 2;
            this.btnInserir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.btnInserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInserir.Location = new System.Drawing.Point(22, 313);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(136, 29);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Insert";
            this.btnInserir.UseVisualStyleBackColor = false;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // lblPorcento
            // 
            this.lblPorcento.AutoSize = true;
            this.lblPorcento.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorcento.Location = new System.Drawing.Point(542, 17);
            this.lblPorcento.Name = "lblPorcento";
            this.lblPorcento.Size = new System.Drawing.Size(93, 33);
            this.lblPorcento.TabIndex = 3;
            this.lblPorcento.Text = "000%";
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorario.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHorario.Location = new System.Drawing.Point(439, -2);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(160, 31);
            this.lblHorario.TabIndex = 4;
            this.lblHorario.Text = "00 : 00 : 00";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblData);
            this.panel2.Controls.Add(this.lblHorario);
            this.panel2.Location = new System.Drawing.Point(10, 410);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 34);
            this.panel2.TabIndex = 5;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.ForeColor = System.Drawing.SystemColors.Control;
            this.lblData.Location = new System.Drawing.Point(0, -2);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(85, 31);
            this.lblData.TabIndex = 6;
            this.lblData.Text = "Data:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblPorcento);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pgrBarra);
            this.Controls.Add(this.clbTarefas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabDescription.ResumeLayout(false);
            this.tabDescription.PerformLayout();
            this.tabPriority.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbTarefas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txtTarefas;
        private System.Windows.Forms.ProgressBar pgrBarra;
        private System.Windows.Forms.Label lblPorcento;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDescription;
        private System.Windows.Forms.TabPage tabPriority;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnLimparDescription;
        private System.Windows.Forms.Button btnPriorityLabel;
        private System.Windows.Forms.Button btnPriority;
        private System.Windows.Forms.Button btnChosePriority;
    }
}

