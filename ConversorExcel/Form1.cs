using DocumentFormat.OpenXml.ExtendedProperties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static ConversorExcel.Variaveis;

namespace ConversorExcel
{
    public partial class Form1 : Form
    {
        // Propriedades do formulário
        public Form1() => InitializeComponent();
        private void Form1_Shown(object sender, EventArgs e)
        {
            Registros.Carregar();
            Form1_Resize(null, null);
            comboBox2.SelectedIndex = 0;
            textBox2.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            tableLayoutPanel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, tableLayoutPanel1.Width, tableLayoutPanel1.Height, 20, 20));
            menu_Principal.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, menu_Principal.Width, menu_Principal.Height, 20, 20));
            panel1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel1.Width, panel1.Height, 20, 20));
            panel2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, panel2.Width, panel2.Height, 20, 20));
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e) => Registros.Salvar();

        // Propriedades do quadrante esquerdo superior
        private void Menu_LinhasDaDireita_Click(object sender, EventArgs e)
        {
            List<Linha> linhaslado = new List<Linha>();
            foreach(string linha in codlinha_apelido.Values)
            {
                Linha linhalado = new Linha();
                if (linhasDireita.Contains(linha))
                    linhalado.Direita = true;
                linhalado.LinhaCod = linha;
                linhaslado.Add(linhalado);
            }
            using (LinhaNaDireita inputForm = new LinhaNaDireita(linhaslado))
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    linhasDireita.Clear();
                    foreach (Linha linha in inputForm.LinhasNovas())
                    {
                        if (linha.Direita) linhasDireita.Add(linha.LinhaCod);
                    }
                }
            }
        }
        private void Menu_AtribuirFolga_CheckStateChanged(object sender, EventArgs e)
        {
            menu_FolgaPinda.Enabled = menu_AtribuirFolga.Checked;
            menu_FolgaTau.Enabled = menu_AtribuirFolga.Checked;
            menu_FolgaCacapava.Enabled = menu_AtribuirFolga.Checked;
        }
        private void Menu_FolgaTau_Click(object sender, EventArgs e) => menu_FolgaTau.Checked = !menu_FolgaTau.Checked;
        private void Menu_FolgaPinda_Click(object sender, EventArgs e) => menu_FolgaPinda.Checked = !menu_FolgaPinda.Checked;
        private void Menu_Informacao_Click(object sender, EventArgs e) => Erro(000);
        private void Menu_ImportarPdf_Click(object sender, EventArgs e) => Fun_OrganizarGridDados(PDF.LerDados);
        private void Menu_AtribuirFolga_Click(object sender, EventArgs e) => menu_AtribuirFolga.Checked = !menu_AtribuirFolga.Checked;
        private void Menu_FolgaCacapava_Click(object sender, EventArgs e) => menu_FolgaCacapava.Checked = !menu_FolgaCacapava.Checked;
        private void Menu_CaixaAltaNomes_Click(object sender, EventArgs e) => menu_CaixaAltaNomes.Checked = !menu_CaixaAltaNomes.Checked;
        private void Menu_AbrirQuandoSalvar_Click(object sender, EventArgs e) => menu_AbrirQuandoSalvar.Checked = !menu_AbrirQuandoSalvar.Checked;
        private void Menu_CaixaAltaNomes_CheckStateChanged(object sender, EventArgs e) => Fun_OrganizarGridDados();

        // Propriedades do quadrante direito superior
        private void Grid_Dados_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                if (matricula_motorista.ContainsKey(Convert.ToInt32(e.FormattedValue.ToString())))
                {
                    string s = matricula_motorista[Convert.ToInt32(e.FormattedValue.ToString())];
                    if (menu_CaixaAltaNomes.Checked)
                        s = s.ToUpper();
                    grid_Dados.Rows[e.RowIndex].Cells[2].Value = s;
                    grid_Dados.Rows[e.RowIndex].ErrorText = string.Empty;
                }
                else
                {
                    grid_Dados.Rows[e.RowIndex].Cells[2].Value = "";
                    grid_Dados.Rows[e.RowIndex].ErrorText = $"A matrícula {e.FormattedValue} não foi encontrada, cadastre-a ou altere.";
                }
            }
        }
        private void Grid_Dados_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e) 
        { 
            if (grid_Dados.CurrentCell.ColumnIndex == 3 && e.Control is TextBox textBox) 
            { 
                textBox.KeyPress -= Fun_FiltrarDigitacaoNumeros; 
                textBox.KeyPress += Fun_FiltrarDigitacaoNumeros; 
            } 
        }

        // Propriedades do quadrante infeiror esquerdo
        private void Btn_SalvarExcel_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 20;
            bool erro202 = false;
            bool erro203 = false;
            bool erro204 = false;
            bool ciclo = false;
            string caminho = textBox2.Text + "\\" + textBox1.Text + ".xlsx";

            try { Directory.GetDirectories(textBox2.Text); erro203 = false; } catch { erro203 = true; }
            foreach (DataGridViewRow row in grid_Dados.Rows) if (!string.IsNullOrEmpty(row.ErrorText)) erro204 = true;
            FileStream stream = null; try  { stream = new FileStream(caminho, FileMode.Open, FileAccess.ReadWrite, FileShare.None);  } catch (IOException) { erro202 = true; } finally { stream?.Close(); }

            if (grid_Dados.Rows.Count <= 0) Erro(200);
            else if (textBox1.Text == "") Erro(201);
            else if (textBox2.Text == "") { Btn_MudarPasta_Click(sender, e); ciclo = true; }
            else if (File.Exists(caminho)) { if (erro202) Erro(202); else try { File.Delete(caminho); ciclo = true; } catch (Exception E) { Erro(0, E); } }
            else if (erro203) { Erro(203); Btn_MudarPasta_Click(sender, e); ciclo = true; }
            else if (erro204) Erro(204);
            else
            {
                progressBar1.Value = 50;
                Fun_OrganizarGridDados();
                progressBar1.Value = 60;
                List<Horario> linhas = new List<Horario>();
                foreach (DataGridViewRow row in grid_Dados.Rows)
                {
                    Horario linha = new Horario();
                    linha.Linha = row.Cells[0].Value.ToString();
                    linha.InicioJornada = row.Cells[1].Value.ToString();
                    linha.Nome = row.Cells[2].Value.ToString();
                    linha.Matricula = row.Cells[3].Value.ToString();
                    linhas.Add(linha);
                }
                progressBar1.Value = 70;
                List<Horario> eventos = new List<Horario>();
                eventosDeMotorista.ForEach(evento => eventos.Add(evento.EventoParaHorario));
                eventos.Sort((x, y) => x.Linha.CompareTo(y.Linha));
                progressBar1.Value = 80;
                List<Horario> folgas = new List<Horario>();
                if (menu_AtribuirFolga.Checked)
                {
                    List<int> matriculas = new List<int>();
                    linhas.ForEach(linha => matriculas.Add(Convert.ToInt32(linha.Matricula)));
                    foreach (int matricula in matricula_motorista.Keys)
                    {
                        if (!matriculas.Contains(matricula))
                        {
                            Horario folga = new Horario();
                            folga.Linha = "Folga";
                            folga.InicioJornada = "00:00";
                            folga.Matricula = matricula.ToString();
                            folga.Nome = matricula_motorista[matricula];
                            if (menu_FolgaCacapava.Checked && matricula_localidade[matricula] == "Caçapava") folgas.Add(folga);
                            else if (menu_FolgaPinda.Checked && matricula_localidade[matricula] == "Pinda") folgas.Add(folga);
                            else if (menu_FolgaTau.Checked && matricula_localidade[matricula] == "Taubaté") folgas.Add(folga);
                        }
                    }
                }
                folgas.Sort((x, y) => x.Matricula.CompareTo(y.Matricula));
                progressBar1.Value = 90;
                linhas.AddRange(folgas);
                linhas.AddRange(eventos);
                GerarExcel.fun_GerarExcel(caminho, linhas);
                progressBar1.Value = 100;
                if (menu_AbrirQuandoSalvar.Checked) Process.Start(caminho);
            }
            if (ciclo) Btn_SalvarExcel_Click(sender, e);
            progressBar1.Value = 0;
        }
        private void Btn_MudarPasta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = false;
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            DialogResult dr = fbd.ShowDialog();
            if (dr == DialogResult.OK) { textBox2.Text = fbd.SelectedPath; }
        }
        private void Txb_VerificadorCaracteres_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if (Array.Exists(new char[] { '\\', '/', ':', '*', '?', '"', '<', '>', '|' }, c => c == e.KeyChar)) 
            {
                Erro(205);
                e.Handled = true;
            }
        }

        // Propriedades do quadrante direito inferior direito
        private void Box1_ConfigurarComponentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Tag = comboBox2.SelectedIndex;
            string[] btn1text = { "Inserir horario", "Adicionar mot", "Remover mot", "Adicionar Linha", "Remover Linha", "Adicionar Evento", "Remover Evento" };
            try { button1.Text = btn1text[comboBox2.SelectedIndex]; } catch { }
            maskedTextBox2.Text = "";
            maskedTextBox1.Text = "";
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            comboBox1.Visible = false;
            maskedTextBox1.Visible = false;
            maskedTextBox2.Visible = false;

            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    {
                        label2.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        comboBox1.Visible = true;
                        maskedTextBox1.Visible = true;
                        maskedTextBox2.Visible = true;
                        label2.Text = "Linha :";
                        label3.Text = "Horário :";
                        label4.Text = "Matrícula :";
                        comboBox1.Items.Clear();
                        foreach (string linha in codlinha_apelido.Keys.ToList()) { comboBox1.Items.Add(codlinha_apelido[linha]); }
                        maskedTextBox1.Mask = "00:00";
                        maskedTextBox2.Mask = "000000";
                        break;
                    }
                case 1:
                    {
                        label2.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        comboBox1.Visible = true;
                        maskedTextBox1.Visible = true;
                        maskedTextBox2.Visible = true;
                        label2.Text = "Localidade :";
                        label3.Text = "Nome :";
                        label4.Text = "Matrícula :";
                        comboBox1.Items.Clear();
                        comboBox1.Items.AddRange(new object[] { "Caçapava", "Taubaté", "Pinda" });
                        maskedTextBox1.Mask = "aaaaaaaaaa";
                        maskedTextBox2.Mask = "000000";
                        break;
                    }
                case 2:
                    {
                        label2.Text = "Motorista :";
                        label2.Visible = true;
                        comboBox1.Visible = true;
                        comboBox1.Items.Clear();
                        List<int> chaves = matricula_motorista.Keys.ToList();
                        chaves.Sort();
                        foreach (int chave in chaves) { comboBox1.Items.Add(chave + " - " + matricula_motorista[chave]); }
                        break;
                    }
                case 3:
                    {
                        label3.Visible = true;
                        label4.Visible = true;
                        maskedTextBox1.Visible = true;
                        maskedTextBox2.Visible = true;
                        label3.Text = "Linha :";
                        label4.Text = "Apelido :";
                        maskedTextBox1.Mask = "aaaaaaaaaa";
                        maskedTextBox2.Mask = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
                        break;
                    }
                case 4:
                    {
                        label2.Visible = true;
                        comboBox1.Visible = true;
                        label2.Text = "Linha :";
                        comboBox1.Items.Clear();
                        foreach (string linha in codlinha_apelido.Keys.ToList()) { comboBox1.Items.Add(linha); }
                        break;
                    }
                case 5:
                    {
                        label2.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        comboBox1.Visible = true;
                        maskedTextBox2.Visible = true;
                        maskedTextBox1.Visible = true;
                        label2.Text = "Evento :";
                        label3.Text = "Motorista :";
                        label4.Text = "Retorno :";
                        comboBox1.Items.Clear();
                        comboBox1.Items.AddRange(new string[] {"Atestado", "Férias", "Afastamento" });
                        maskedTextBox2.Mask = "00/00/0000";
                        maskedTextBox1.Mask = "000000";
                        break;
                    }
                case 6:
                    {
                        label2.Visible = true;
                        comboBox1.Visible = true;
                        label2.Text = "Motorista :";
                        comboBox1.Items.Clear();
                        eventosDeMotorista.Sort((x, y) => x.Matricula.CompareTo(y.Matricula));
                        foreach (Evento motorista in eventosDeMotorista) { comboBox1.Items.Add(motorista.Matricula + "|" + matricula_motorista[motorista.Matricula] + "|" + motorista.Razao + "|" + motorista.Fim.ToString("dd/MM/yyyy")); }
                        break;
                    }
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    {
                        try
                        {
                            string s = matricula_motorista[Convert.ToInt32(maskedTextBox2.Text)];
                            s = s.ToUpper();
                            if (!TimeSpan.TryParseExact(maskedTextBox1.Text, "hh\\:mm", null, out _)) Erro(300);
                            else if (comboBox1.SelectedItem == null) Erro(301);
                            else
                            {
                                grid_Dados.Rows.Add(comboBox1.SelectedItem.ToString(), maskedTextBox1.Text, s, maskedTextBox2.Text);
                            }
                        }
                        catch { Erro(302); }
                        break;
                    }
                case 1:
                    {
                        if (comboBox1.SelectedItem == null) Erro(303);
                        else if (maskedTextBox1.Text == "") Erro(304);
                        else if (maskedTextBox2.Text == "") Erro(305);
                        else
                        {
                            try
                            {
                                matricula_localidade.Add(Convert.ToInt32(maskedTextBox2.Text), comboBox1.SelectedItem.ToString());
                                matricula_motorista.Add(Convert.ToInt32(maskedTextBox2.Text), maskedTextBox1.Text);
                            }
                            catch { Erro(315); }
                        }
                        break;
                    }
                case 2:
                    {
                        if (comboBox1.SelectedItem == null) Erro(306);
                        else
                        {
                            int matricula = Convert.ToInt32(comboBox1.SelectedItem.ToString().Remove(comboBox1.SelectedItem.ToString().TrimEnd().IndexOf('-')));
                            matricula_localidade.Remove(matricula);
                            matricula_motorista.Remove(matricula);
                        }
                        break;
                    }
                case 3:
                    {
                        if (maskedTextBox1.Text == "" || maskedTextBox2.Text == "") Erro(307);
                        else 
                        {
                            try
                            {
                                if (Erro(308) == DialogResult.OK) codlinha_apelido.Add(maskedTextBox1.Text, maskedTextBox2.Text);
                            }
                            catch { Erro(316); }
                        }
                        break;
                    }
                case 4:
                    {
                        if (comboBox1.SelectedItem == null) Erro(309);
                        else
                        {
                            if (Erro(310) == DialogResult.OK)
                            {
                                codlinha_apelido.Remove(comboBox1.SelectedItem.ToString());
                                Fun_OrganizarGridDados();
                                comboBox2.SelectedIndex = -1;
                                comboBox2.SelectedIndex = 4;
                            }
                        }
                        break;
                    }
                case 5:
                    {
                        try
                        {
                            DateTime eventoDia;
                            string s = matricula_motorista[Convert.ToInt32(maskedTextBox1.Text)];
                            if (comboBox1.SelectedItem == null) Erro(311);
                            else if (!DateTime.TryParse(maskedTextBox2.Text, out eventoDia)) Erro(312);
                            else
                            {
                                Evento evento = new Evento();
                                evento.Fim = eventoDia;
                                evento.Matricula = Convert.ToInt32(maskedTextBox1.Text);
                                evento.Razao = comboBox1.SelectedItem.ToString();
                                eventosDeMotorista.Add(evento);
                            }
                        }
                        catch { Erro(313); }
                        break;
                    }
                case 6:
                    {
                        if (comboBox1.SelectedItem == null) Erro(314);
                        else
                        {
                            List<string> eventoSelecionado = comboBox1.SelectedItem.ToString().Split('|').ToList();
                            int index = -1;
                            foreach (Evento evento in eventosDeMotorista) { if (evento.Matricula == Convert.ToInt32(eventoSelecionado[0])) { if (evento.Fim == Convert.ToDateTime(eventoSelecionado[3])) { if (evento.Razao == eventoSelecionado[2]) { index = eventosDeMotorista.IndexOf(evento); } } } }
                            eventosDeMotorista.RemoveAt(index);
                        }
                        break;
                    }
            }
            Fun_OrganizarGridDados();
            int indexBox = comboBox2.SelectedIndex;
            comboBox2.SelectedIndex = -1;
            comboBox2.SelectedIndex = indexBox;
        }
        
        // Funções
        private DialogResult Erro(int erro, Exception e = null)
        { 
            string m = string.Empty;
            string t = string.Empty;
            MessageBoxButtons b = MessageBoxButtons.OK;
            MessageBoxIcon i = MessageBoxIcon.Information;
            // Caso de erro204 mapeados
            if (e == null)
            {
                switch (erro)
                {
                    // Erros no quadrante esquerdo superior (0 - 99 : menu)
                    case 000:
                        {
                            m = "Sobre o app: A aplicação foi desenvolvida com o intuito de ganhar tempo nas tarefas rotineiras e " +
                                "reduzir erros de comunicação gerados pela digitação manual das escalas no EXCEL.\n\nSobre o desenvolvedor: " +
                                "Esse esse aplicativo foi desenvolvido por Gabriel Garcia Pereira. Para suporte entre em contato pelo email:" +
                                " gabriel.gpereira2157@gmail.com";
                            t = "Informações";
                            break;
                        }
                    // Erros no quadrante direito superior (100 - 199 : grid)
                    // Erros no quadrante esquerdo inferior (200 - 299 : salvar excel)
                    case 200:
                        {
                            m = "Importe uma escala para poder salva-la como PDF!";
                            t = "PDF para EXCEL";
                            break;
                        }
                    case 201:
                        {
                            m = "Digite o nome do arquivo a salvar";
                            t = "PDF para EXCEL";
                            break;
                        }
                    case 202:
                        {
                            m = "Não foi possível salvar! Um arquivo com mesmo nome na pasta selecionada está aberto, feche-o e tente" +
                                " salvar novamente.";
                            t = "PDF para EXCEL";
                            i = MessageBoxIcon.Warning;
                            break;
                        }
                    case 203:
                        {
                            m = "O diretório não está acessível! Selecione outra pasta.";
                            t = "PDF para EXCEL";
                            i = MessageBoxIcon.Warning;
                            break;
                        }
                    case 204:
                        {
                            m = "Há erro(s) na tabela, corrija-os para poder salvar como EXCEL";
                            t = "PDF para EXCEL";
                            break;
                        }
                    case 205:
                        {
                            m = "Os nomes de arquivos não podem conter nenhum dos seguintes caracteres:\n   \\ / : * ? \" < > |";
                            t = "Aviso de formatação";
                            break;
                        }
                    // Erros no quadrante direito inferior (300 - 399 : modificador de registros)
                    case 300:
                        {
                            m = "O horário digitada é invalida!";
                            t = "Inserir horário";
                            break;
                        }
                    case 301:
                        {
                            m = "Selecione uma linha!";
                            t = "Inserir horário";
                            break;
                        }
                    case 302:
                        {
                            m = "A matrícula digitada não foi encontrada, cadastre ou a corrija";
                            t = "Inserir horário";
                            break;
                        }
                    case 303:
                        {
                            m = "Selecione uma linha!";
                            t = "Inserir motorista";
                            break;
                        }
                    case 304:
                        {
                            m = "Digite um nome para ser gravado no sistema!";
                            t = "Inserir motorista";
                            break;
                        }
                    case 305:
                        {
                            m = "Digite uma matrícula para ser gravado no sistema!";
                            t = "Inserir motorista";
                            break;
                        }
                    case 306:
                        {
                            m = "Selecione uma matrícula para remover.";
                            t = "Remover motorista";
                            break;
                        }
                    case 307:
                        {
                            m = "Preencha os campos para adicionar uma nova linha.";
                            t = "Adicionar linha";
                            break;
                        }
                    case 308:
                        {
                            m = "AVISO: Para que a linha seja lida no PDF, ela tem que estar IGUAL a como está escrita no arquivo.";
                            t = "Adicionar linha";
                            b = MessageBoxButtons.OKCancel;
                            i = MessageBoxIcon.Warning;
                            break;
                        }
                    case 309:
                        {
                            m = "Selecione uma linha para remover.";
                            t = "Remover linha";
                            break;
                        }
                    case 310:
                        {
                            m = "AVISO: remover uma linha implica em:\n\n - Ela não será lida no PDF\n\nIsso pode gerar problemas de formata" +
                                "ção...";
                            t = "Remover linha";
                            b = MessageBoxButtons.OKCancel;
                            i = MessageBoxIcon.Warning;
                            break;
                        }
                    case 311:
                        {
                            m = "Selecione um evento.";
                            t = "Adicionar evento";
                            break;
                        }
                    case 312:
                        {
                            m = "A data digitada é invalida.";
                            t = "Adicionar evento";
                            break;
                        }
                    case 313:
                        {
                            m = "A matrícula digitada não foi encontrada, cadastre ou a corrija";
                            t = "Inserir horário";
                            break;
                        }
                    case 314:
                        {
                            m = "Selecione um evento registrado para excluir.";
                            t = "Remover evento";
                            break;
                        }
                    case 315:
                        {
                            m = "Já existe um motorista cadastrado com essa matrícula, remova-o ou insira uma nova.";
                            t = "Inserir motorista";
                            i = MessageBoxIcon.Warning;
                            break;
                        }
                    case 316:
                        {
                            m = "Essa linha já esta cadastrada, remova-a ou insira uma nova.";
                            t = "Adicionar linha";
                            i = MessageBoxIcon.Warning;
                            break;
                        }
                }
            }
            // Caso de erro204 não mapeados
            else
            {
                m = "Reporte o erro a criador: " + e.Message;
                t = "Erro crítico";
                i = MessageBoxIcon.Error;
            }
            return MessageBox.Show(m, t + " #" + erro, b, i);
        }
        private void Fun_OrganizarGridDados(List<Horario> horarios = null)
        {
            if (horarios == null) 
            {
                horarios = new List<Horario>();
                foreach (DataGridViewRow row in grid_Dados.Rows)
                {
                    Horario linha = new Horario();
                    linha.Linha = row.Cells[0].Value.ToString();
                    linha.InicioJornada = row.Cells[1].Value.ToString();
                    linha.Nome = row.Cells[2].Value.ToString();
                    linha.Matricula = row.Cells[3].Value.ToString();
                    horarios.Add(linha);
                }
            }
            grid_Dados.Rows.Clear();
            foreach (string chave in codlinha_apelido.Values.ToList())
            {
                List<Horario> horariosOrganizados = new List<Horario>();
                foreach (Horario horario in horarios)
                {
                    if (horario.Linha == chave)
                    {
                        horariosOrganizados.Add(horario);
                    }
                }
                horariosOrganizados.Sort((x, y) => x.InicioJornada.CompareTo(y.InicioJornada));
                foreach (Horario horario in horariosOrganizados)
                {
                    string nome = string.Empty;
                    try
                    {
                        nome = matricula_motorista[Convert.ToInt32(horario.Matricula)];
                        if (menu_CaixaAltaNomes.Checked) { nome = nome.ToUpper(); }
                    }
                    catch { }
                    finally
                    {
                        grid_Dados.Rows.Add(horario.Linha, horario.InicioJornada, nome, horario.Matricula);
                        if (nome == string.Empty) { grid_Dados.Rows[grid_Dados.Rows.Count - 1].ErrorText = $"A matrícula {horario.Matricula} não foi encontrada, cadastre-a ou altere."; }
                    }
                }
            }
        }
        private static void Fun_FiltrarDigitacaoNumeros(object sender, KeyPressEventArgs e)
        {
            if (!Array.Exists(new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' }, ch => ch == e.KeyChar) &&
                !char.IsControl(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back &&
                e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }
    }
}