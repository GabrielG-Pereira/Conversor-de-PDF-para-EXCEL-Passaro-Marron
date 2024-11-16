using ClosedXML.Excel;
using System.Windows.Forms;
using static PDFparaEXCEL.Variaveis;

namespace PDFparaEXCEL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Linhas> Dados = new List<Linhas>();
        private void button1_Click(object sender, EventArgs e)
        {
            string texto = BuscarCaminhoPDF();
            if (texto != null)
            {
                ConvertePDF pdftxt = new ConvertePDF();
                Dados = SepararLinhas(TextosFiltrados(pdftxt.ExtrairTexto_PDF(texto)));
                foreach (Linhas l in Dados)
                {
                    dataGridView1.Rows.Add(l.Linha, l.MotoristaInicioJornada, l.MotoristaNome, l.MotoristaMatricula);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string caminho = textBox1.Text + ".xlsx";
            if (textBox1.Text != "")
            {
                XLWorkbook workbook = new XLWorkbook();
                IXLWorksheet worksheet = workbook.Worksheets.Add("Escala");
                int linha = 1;
                string registroA = "";
                foreach (Linhas l in Dados)
                {
                    if(registroA!= l.Linha)
                    {
                        linha++;
                        registroA = l.Linha;
                        IXLCell cellLinha = worksheet.Cell(column: "A", row: linha);
                        cellLinha.Value = l.Linha;
                    }
                    IXLCell cellHorario = worksheet.Cell(column: "B", row: linha);
                    IXLCell cellMotorista = worksheet.Cell(column: "C", row: linha);
                    IXLCell cellMatricula = worksheet.Cell(column: "D", row: linha);
                    cellHorario.Value = l.MotoristaInicioJornada;
                    cellMotorista.Value = l.MotoristaNome;
                    cellMatricula.Value = l.MotoristaMatricula;
                    linha++;
                }
                IXLCell cabecalhoLinha = worksheet.Cell("A1");
                IXLCell cabecalhoHorario = worksheet.Cell("B1");
                IXLCell cabecalhoMotorista = worksheet.Cell("C1");
                IXLCell cabecalhoMatricula = worksheet.Cell("D1");
                IXLCell cabecalhoObs = worksheet.Cell("E1");
                cabecalhoLinha.Value = "Linha";
                cabecalhoHorario.Value = "Horario";
                cabecalhoMotorista.Value = "Motorista";
                cabecalhoMatricula.Value = "Matrícula";
                cabecalhoObs.Value = "Observação";
                try
                {
                    workbook.SaveAs(caminho);
                }
                catch
                {
                    MessageBox.Show("Erro ao salvar, por favor tente dar outro nome ao arquivo!\n\n", "PDF para EXCEL");
                }
            }
            else
            {
                MessageBox.Show("Digite o nome do arquivo a salvar", "PDF para EXCEL");
            }
        }

        private List<Linhas> SepararLinhas(List<string> textos)
        {
            List<Linhas> lista = new List<Linhas>();
            Linhas modelo = new Linhas
            {
                Linha = "",
                MotoristaInicioJornada = "",
                MotoristaNome = "",
                MotoristaMatricula = "",
                MotoristaFimJornada = "",
            };
            foreach (string s in textos)
            {
                foreach (string marcadores in iniciadoresPaginas)
                {
                    if (s.Contains(marcadores))
                        modelo.Linha = "";
                }
                foreach (string linha in codLinhas)
                {
                    if (s.Contains(linha))
                    {
                        modelo.Linha = s;
                        modelo.MotoristaInicioJornada = "";
                        modelo.MotoristaNome = "";
                        modelo.MotoristaMatricula = "";
                        modelo.MotoristaFimJornada = "";
                    }
                }
                if (modelo.Linha != "")
                {
                    if (modelo.MotoristaInicioJornada == "")
                    {
                        if (DateTime.TryParse(s, out _))
                            modelo.MotoristaInicioJornada = s;
                    }
                    else if (modelo.MotoristaNome == "")
                        modelo.MotoristaNome = s;
                    else if (modelo.MotoristaMatricula == "")
                    {
                        if (int.TryParse(s, out _))
                            modelo.MotoristaMatricula = s;
                        else
                            modelo.MotoristaNome = s;
                    }
                    else if (modelo.MotoristaFimJornada == "")
                    {
                        if (DateTime.TryParse(s, out _))
                        {
                            modelo.MotoristaFimJornada = s;
                            Linhas adicionar = new Linhas
                            {
                                Linha = modelo.Linha,
                                MotoristaInicioJornada = modelo.MotoristaInicioJornada,
                                MotoristaNome = modelo.MotoristaNome,
                                MotoristaMatricula = modelo.MotoristaMatricula,
                                MotoristaFimJornada = modelo.MotoristaFimJornada,
                            };
                            lista.Add(adicionar);
                            modelo.MotoristaInicioJornada = "";
                            modelo.MotoristaNome = "";
                            modelo.MotoristaMatricula = "";
                            modelo.MotoristaFimJornada = "";
                        }
                    }
                }
            }
            List<Linhas> listaComDicionario = new List<Linhas>();
            foreach (Linhas linhas in lista)
            {
                foreach (string lin in codLinhas)
                {
                    if (linhas.Linha.Contains(lin))
                    {
                        Linhas adicionar = new Linhas
                        {
                            Linha = apelidoLinha[lin],
                            MotoristaInicioJornada = linhas.MotoristaInicioJornada,
                            MotoristaNome = linhas.MotoristaNome,
                            MotoristaMatricula = linhas.MotoristaMatricula,
                            MotoristaFimJornada = linhas.MotoristaFimJornada,
                        };
                        listaComDicionario.Add(adicionar);
                    }
                }
            }
            return listaComDicionario;
        }

        private List<string> TextosFiltrados(string texto)
        {
            List<string> textosFiltrados = new List<string>();
            string sFiltrado = string.Empty;
            foreach (char item in texto)
            {
                if (!filtro.Contains(item))
                {
                    sFiltrado += item;
                }
            }
            sFiltrado.ToUpper();
            foreach (string s in sFiltrado.Split(separador))
            {
                if (!string.IsNullOrWhiteSpace(s) && !string.IsNullOrEmpty(s))
                {
                    s.TrimEnd();
                    textosFiltrados.Add(s);
                }
            }
            return textosFiltrados;
        }

        private string BuscarCaminhoPDF()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos PDF (*.pdf)|*.pdf";
                openFileDialog.Title = "Selecione um arquivo PDF";
                DialogResult result = openFileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    if (selectedFilePath.EndsWith(".pdf"))
                        return selectedFilePath;
                    else
                        MessageBox.Show("O arquivo selecionado não é um PDF.");
                }
                return string.Empty;
            }
        }
        private string BuscarCaminhoExcel()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                openFileDialog.Title = "Selecione um local para salvar";
                DialogResult result = openFileDialog.ShowDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(openFileDialog.FileName))
                {
                    string selectedFilePath = openFileDialog.FileName;
                    string fileName = Path.GetFileName(selectedFilePath);
                    return fileName;
                }
                return string.Empty;
            }
        }
    }
}
