using System;
using System.Drawing;
using System.Windows.Forms;

namespace ConversorExcel
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grid_Dados = new System.Windows.Forms.DataGridView();
            this.grid_ColunaLinha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_CounaHorário = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_ColunaMotorista = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_ColunaMatrícula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_AlterarPasta = new System.Windows.Forms.Button();
            this.lb_NomeArquivo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lb_PastaDestino = new System.Windows.Forms.Label();
            this.btn_ConverterDocumento = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menu_Principal = new System.Windows.Forms.MenuStrip();
            this.menu_ImportarEscala = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Configuracao = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_AbrirQuandoSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_AtribuirFolga = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_FolgaCacapava = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_FolgaPinda = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_FolgaTau = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_CaixaAltaNomes = new System.Windows.Forms.ToolStripMenuItem();
            this.linhasADireitaNoExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Informacao = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Dados)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.menu_Principal.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_Dados
            // 
            this.grid_Dados.AllowUserToAddRows = false;
            this.grid_Dados.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grid_Dados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_Dados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_Dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Dados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grid_ColunaLinha,
            this.grid_CounaHorário,
            this.grid_ColunaMotorista,
            this.grid_ColunaMatrícula});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_Dados.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_Dados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_Dados.Location = new System.Drawing.Point(20, 20);
            this.grid_Dados.Margin = new System.Windows.Forms.Padding(10);
            this.grid_Dados.Name = "grid_Dados";
            this.grid_Dados.Size = new System.Drawing.Size(415, 241);
            this.grid_Dados.TabIndex = 5;
            this.grid_Dados.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.Grid_Dados_CellValidating);
            this.grid_Dados.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Grid_Dados_EditingControlShowing);
            // 
            // grid_ColunaLinha
            // 
            this.grid_ColunaLinha.HeaderText = "Linha";
            this.grid_ColunaLinha.Name = "grid_ColunaLinha";
            this.grid_ColunaLinha.ReadOnly = true;
            // 
            // grid_CounaHorário
            // 
            this.grid_CounaHorário.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.grid_CounaHorário.HeaderText = "Horário";
            this.grid_CounaHorário.Name = "grid_CounaHorário";
            this.grid_CounaHorário.ReadOnly = true;
            this.grid_CounaHorário.Width = 66;
            // 
            // grid_ColunaMotorista
            // 
            this.grid_ColunaMotorista.HeaderText = "Motorista";
            this.grid_ColunaMotorista.MaxInputLength = 6;
            this.grid_ColunaMotorista.Name = "grid_ColunaMotorista";
            this.grid_ColunaMotorista.ReadOnly = true;
            // 
            // grid_ColunaMatrícula
            // 
            this.grid_ColunaMatrícula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.grid_ColunaMatrícula.HeaderText = "Matrícula";
            this.grid_ColunaMatrícula.Name = "grid_ColunaMatrícula";
            this.grid_ColunaMatrícula.Width = 77;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_NomeArquivo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_PastaDestino, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn_ConverterDocumento, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(20, 10, 20, 20);
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(422, 324);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.textBox2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(23, 172);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(376, 47);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.textBox2.Location = new System.Drawing.Point(3, 7);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(257, 22);
            this.textBox2.TabIndex = 9;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.btn_AlterarPasta, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(266, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(107, 41);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // btn_AlterarPasta
            // 
            this.btn_AlterarPasta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_AlterarPasta.Font = new System.Drawing.Font("Nirmala UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AlterarPasta.Location = new System.Drawing.Point(3, 3);
            this.btn_AlterarPasta.Name = "btn_AlterarPasta";
            this.btn_AlterarPasta.Size = new System.Drawing.Size(101, 24);
            this.btn_AlterarPasta.TabIndex = 11;
            this.btn_AlterarPasta.Text = "Alterar";
            this.btn_AlterarPasta.UseVisualStyleBackColor = true;
            this.btn_AlterarPasta.Click += new System.EventHandler(this.Btn_MudarPasta_Click);
            // 
            // lb_NomeArquivo
            // 
            this.lb_NomeArquivo.AutoSize = true;
            this.lb_NomeArquivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_NomeArquivo.Font = new System.Drawing.Font("Nirmala UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NomeArquivo.Location = new System.Drawing.Point(23, 10);
            this.lb_NomeArquivo.Name = "lb_NomeArquivo";
            this.lb_NomeArquivo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lb_NomeArquivo.Size = new System.Drawing.Size(376, 53);
            this.lb_NomeArquivo.TabIndex = 8;
            this.lb_NomeArquivo.Text = "N O M E    D O    A R Q U I V O :";
            this.lb_NomeArquivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Nirmala UI", 8.25F);
            this.textBox1.Location = new System.Drawing.Point(23, 70);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(376, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Escala Convertida";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txb_VerificadorCaracteres_KeyPress);
            // 
            // lb_PastaDestino
            // 
            this.lb_PastaDestino.AutoSize = true;
            this.lb_PastaDestino.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_PastaDestino.Font = new System.Drawing.Font("Nirmala UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_PastaDestino.Location = new System.Drawing.Point(23, 116);
            this.lb_PastaDestino.Name = "lb_PastaDestino";
            this.lb_PastaDestino.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.lb_PastaDestino.Size = new System.Drawing.Size(376, 53);
            this.lb_PastaDestino.TabIndex = 10;
            this.lb_PastaDestino.Text = "D E S T I N O :";
            this.lb_PastaDestino.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_ConverterDocumento
            // 
            this.btn_ConverterDocumento.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_ConverterDocumento.Font = new System.Drawing.Font("Nirmala UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConverterDocumento.Location = new System.Drawing.Point(23, 225);
            this.btn_ConverterDocumento.MaximumSize = new System.Drawing.Size(376, 47);
            this.btn_ConverterDocumento.MinimumSize = new System.Drawing.Size(376, 47);
            this.btn_ConverterDocumento.Name = "btn_ConverterDocumento";
            this.btn_ConverterDocumento.Size = new System.Drawing.Size(376, 47);
            this.btn_ConverterDocumento.TabIndex = 7;
            this.btn_ConverterDocumento.Text = "Converter escala para o Excel";
            this.btn_ConverterDocumento.UseVisualStyleBackColor = true;
            this.btn_ConverterDocumento.Click += new System.EventHandler(this.Btn_SalvarExcel_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(23, 278);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(376, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 14;
            // 
            // menu_Principal
            // 
            this.menu_Principal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menu_Principal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_ImportarEscala,
            this.menu_Configuracao,
            this.menu_Informacao});
            this.menu_Principal.Location = new System.Drawing.Point(1, 1);
            this.menu_Principal.Margin = new System.Windows.Forms.Padding(10, 6, 10, 0);
            this.menu_Principal.Name = "menu_Principal";
            this.menu_Principal.Padding = new System.Windows.Forms.Padding(10, 1, 10, 2);
            this.menu_Principal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu_Principal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menu_Principal.Size = new System.Drawing.Size(422, 30);
            this.menu_Principal.TabIndex = 13;
            this.menu_Principal.Text = "menuStrip1";
            // 
            // menu_ImportarEscala
            // 
            this.menu_ImportarEscala.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_ImportarEscala.Name = "menu_ImportarEscala";
            this.menu_ImportarEscala.Size = new System.Drawing.Size(124, 27);
            this.menu_ImportarEscala.Text = "Importar escala";
            this.menu_ImportarEscala.Click += new System.EventHandler(this.Menu_ImportarPdf_Click);
            // 
            // menu_Configuracao
            // 
            this.menu_Configuracao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_AbrirQuandoSalvar,
            this.menu_AtribuirFolga,
            this.menu_CaixaAltaNomes,
            this.linhasADireitaNoExcelToolStripMenuItem});
            this.menu_Configuracao.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_Configuracao.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.menu_Configuracao.Name = "menu_Configuracao";
            this.menu_Configuracao.Size = new System.Drawing.Size(116, 27);
            this.menu_Configuracao.Text = "Configurações";
            // 
            // menu_AbrirQuandoSalvar
            // 
            this.menu_AbrirQuandoSalvar.Checked = true;
            this.menu_AbrirQuandoSalvar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menu_AbrirQuandoSalvar.Font = new System.Drawing.Font("Nirmala UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_AbrirQuandoSalvar.Name = "menu_AbrirQuandoSalvar";
            this.menu_AbrirQuandoSalvar.Size = new System.Drawing.Size(373, 24);
            this.menu_AbrirQuandoSalvar.Text = "Abrir arquivo quando salvar";
            this.menu_AbrirQuandoSalvar.Click += new System.EventHandler(this.Menu_AbrirQuandoSalvar_Click);
            // 
            // menu_AtribuirFolga
            // 
            this.menu_AtribuirFolga.Checked = true;
            this.menu_AtribuirFolga.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menu_AtribuirFolga.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_FolgaCacapava,
            this.menu_FolgaPinda,
            this.menu_FolgaTau});
            this.menu_AtribuirFolga.Name = "menu_AtribuirFolga";
            this.menu_AtribuirFolga.Size = new System.Drawing.Size(373, 24);
            this.menu_AtribuirFolga.Text = "Atribuir folga a motoristas fora de escala";
            this.menu_AtribuirFolga.CheckStateChanged += new System.EventHandler(this.Menu_AtribuirFolga_CheckStateChanged);
            this.menu_AtribuirFolga.Click += new System.EventHandler(this.Menu_AtribuirFolga_Click);
            // 
            // menu_FolgaCacapava
            // 
            this.menu_FolgaCacapava.Checked = true;
            this.menu_FolgaCacapava.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menu_FolgaCacapava.Name = "menu_FolgaCacapava";
            this.menu_FolgaCacapava.Size = new System.Drawing.Size(105, 24);
            this.menu_FolgaCacapava.Text = "CCP";
            this.menu_FolgaCacapava.Click += new System.EventHandler(this.Menu_FolgaCacapava_Click);
            // 
            // menu_FolgaPinda
            // 
            this.menu_FolgaPinda.Name = "menu_FolgaPinda";
            this.menu_FolgaPinda.Size = new System.Drawing.Size(105, 24);
            this.menu_FolgaPinda.Text = "PIN";
            this.menu_FolgaPinda.Click += new System.EventHandler(this.Menu_FolgaPinda_Click);
            // 
            // menu_FolgaTau
            // 
            this.menu_FolgaTau.Checked = true;
            this.menu_FolgaTau.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menu_FolgaTau.Name = "menu_FolgaTau";
            this.menu_FolgaTau.Size = new System.Drawing.Size(105, 24);
            this.menu_FolgaTau.Text = "TAU";
            this.menu_FolgaTau.Click += new System.EventHandler(this.Menu_FolgaTau_Click);
            // 
            // menu_CaixaAltaNomes
            // 
            this.menu_CaixaAltaNomes.Checked = true;
            this.menu_CaixaAltaNomes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menu_CaixaAltaNomes.Name = "menu_CaixaAltaNomes";
            this.menu_CaixaAltaNomes.Size = new System.Drawing.Size(373, 24);
            this.menu_CaixaAltaNomes.Text = "Deixar em CAIXA ALTA nome dos motoristas";
            this.menu_CaixaAltaNomes.CheckStateChanged += new System.EventHandler(this.Menu_CaixaAltaNomes_CheckStateChanged);
            this.menu_CaixaAltaNomes.Click += new System.EventHandler(this.Menu_CaixaAltaNomes_Click);
            // 
            // linhasADireitaNoExcelToolStripMenuItem
            // 
            this.linhasADireitaNoExcelToolStripMenuItem.Name = "linhasADireitaNoExcelToolStripMenuItem";
            this.linhasADireitaNoExcelToolStripMenuItem.Size = new System.Drawing.Size(373, 24);
            this.linhasADireitaNoExcelToolStripMenuItem.Text = "Linhas na direita no arquivo excel";
            this.linhasADireitaNoExcelToolStripMenuItem.Click += new System.EventHandler(this.Menu_LinhasDaDireita_Click);
            // 
            // menu_Informacao
            // 
            this.menu_Informacao.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_Informacao.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.menu_Informacao.Name = "menu_Informacao";
            this.menu_Informacao.Size = new System.Drawing.Size(103, 27);
            this.menu_Informacao.Text = "Informações";
            this.menu_Informacao.Click += new System.EventHandler(this.Menu_Informacao_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(444, 384);
            this.tableLayoutPanel5.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.menu_Principal);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(10, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(1);
            this.panel2.Size = new System.Drawing.Size(424, 32);
            this.panel2.TabIndex = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 48);
            this.panel1.Margin = new System.Windows.Forms.Padding(10);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(1);
            this.panel1.Size = new System.Drawing.Size(424, 326);
            this.panel1.TabIndex = 15;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(911, 390);
            this.tableLayoutPanel4.TabIndex = 15;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.grid_Dados, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(453, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.Padding = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(455, 384);
            this.tableLayoutPanel6.TabIndex = 16;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(20, 281);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(10);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(415, 83);
            this.tableLayoutPanel7.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Nirmala UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label1.Size = new System.Drawing.Size(409, 33);
            this.label1.TabIndex = 9;
            this.label1.Text = "M O D I F I C A R    R E G I S T R O S :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 4;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel8.Controls.Add(this.button1, 3, 1);
            this.tableLayoutPanel8.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.comboBox1, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.maskedTextBox1, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.maskedTextBox2, 2, 1);
            this.tableLayoutPanel8.Controls.Add(this.comboBox2, 3, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 33);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(415, 50);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Nirmala UI Semilight", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(312, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 19);
            this.button1.TabIndex = 18;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Nirmala UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(209, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label4.Size = new System.Drawing.Size(97, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Matrícula :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Nirmala UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Entrada :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Nirmala UI Semilight", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Linha :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(97, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskedTextBox1.Location = new System.Drawing.Point(106, 28);
            this.maskedTextBox1.Mask = "aaaaaaaaaa";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(97, 20);
            this.maskedTextBox1.TabIndex = 14;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maskedTextBox2.Location = new System.Drawing.Point(209, 28);
            this.maskedTextBox2.Mask = "000000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(97, 20);
            this.maskedTextBox2.TabIndex = 16;
            this.maskedTextBox2.ValidatingType = typeof(int);
            // 
            // comboBox2
            // 
            this.comboBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Inserir horario",
            "Adicionar motorista",
            "Remover motorista",
            "Adicionar linha",
            "Remover linha",
            "Adicionar evento ",
            "Remover evento"});
            this.comboBox2.Location = new System.Drawing.Point(312, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.Box1_ConfigurarComponentes_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 390);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu_Principal;
            this.MinimumSize = new System.Drawing.Size(466, 429);
            this.Name = "Form1";
            this.Text = "Conversor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.grid_Dados)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.menu_Principal.ResumeLayout(false);
            this.menu_Principal.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MenuStrip menu_Principal;
        private ToolStripMenuItem menu_ImportarEscala;
        private TableLayoutPanel tableLayoutPanel5;
        private DataGridView grid_Dados;
        private DataGridViewTextBoxColumn grid_ColunaLinha;
        private DataGridViewTextBoxColumn grid_CounaHorário;
        private DataGridViewTextBoxColumn grid_ColunaMotorista;
        private DataGridViewTextBoxColumn grid_ColunaMatrícula;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBox2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btn_AlterarPasta;
        private Label lb_NomeArquivo;
        private TextBox textBox1;
        private Label lb_PastaDestino;
        private Button btn_ConverterDocumento;
        private ProgressBar progressBar1;
        private ToolStripMenuItem menu_Configuracao;
        private ToolStripMenuItem menu_Informacao;
        private ToolStripMenuItem menu_AbrirQuandoSalvar;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel panel2;
        private ToolStripMenuItem menu_AtribuirFolga;
        private ToolStripMenuItem menu_CaixaAltaNomes;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel8;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox comboBox1;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private Button button1;
        private ToolStripMenuItem menu_FolgaCacapava;
        private ToolStripMenuItem menu_FolgaPinda;
        private ToolStripMenuItem menu_FolgaTau;
        private ComboBox comboBox2;
        private ToolStripMenuItem linhasADireitaNoExcelToolStripMenuItem;
    }
}
