namespace PDFparaEXCEL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            button2 = new Button();
            label1 = new Label();
            Linha = new DataGridViewTextBoxColumn();
            Entrada = new DataGridViewTextBoxColumn();
            Motorista = new DataGridViewTextBoxColumn();
            Matrícula = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(49, 60);
            button1.Name = "button1";
            button1.Size = new Size(232, 38);
            button1.TabIndex = 0;
            button1.Text = "Importar escala em PDF";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Linha, Entrada, Motorista, Matrícula });
            dataGridView1.Location = new Point(428, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(479, 426);
            dataGridView1.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(49, 336);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Escala do dia ...";
            textBox1.Size = new Size(198, 23);
            textBox1.TabIndex = 6;
            // 
            // button2
            // 
            button2.Location = new Point(49, 384);
            button2.Name = "button2";
            button2.Size = new Size(354, 38);
            button2.TabIndex = 7;
            button2.Text = "Converter escala para o Excel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 318);
            label1.Name = "label1";
            label1.Size = new Size(198, 15);
            label1.TabIndex = 8;
            label1.Text = "Digite o nome da escala à converter:";
            // 
            // Linha
            // 
            Linha.HeaderText = "Linha";
            Linha.Name = "Linha";
            // 
            // Entrada
            // 
            Entrada.HeaderText = "Entrada";
            Entrada.Name = "Entrada";
            // 
            // Motorista
            // 
            Motorista.HeaderText = "Motorista";
            Motorista.Name = "Motorista";
            // 
            // Matrícula
            // 
            Matrícula.HeaderText = "Matrícula";
            Matrícula.Name = "Matrícula";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 450);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button button2;
        private Label label1;
        private DataGridViewTextBoxColumn Linha;
        private DataGridViewTextBoxColumn Entrada;
        private DataGridViewTextBoxColumn Motorista;
        private DataGridViewTextBoxColumn Matrícula;
    }
}
