using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConversorExcel
{
    internal class PDF
    {
        public static List<Horario> ultimaEscala;
        private static string BuscarCaminhoPDF
        {
            get
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
                    }
                    return string.Empty;
                }
            }
        }

        public static List<Horario> LerDados
        {
            get
            {
                string caminhoArquivo = BuscarCaminhoPDF;
                if (caminhoArquivo != "")
                {
                    List<Horario> listaComDicionario = null;
                    string dados = string.Empty;
                    try
                    {
                        using (PdfReader leitor = new PdfReader(caminhoArquivo))
                        {
                            StringBuilder texto = new StringBuilder();
                            for (int i = 1; i <= leitor.NumberOfPages; i++)
                            {
                                texto.Append(PdfTextExtractor.GetTextFromPage(leitor, i));
                            }
                            dados = texto.ToString();
                        }
                    }
                    finally
                    {
                        List<string> dadosFiltrados = new List<string>();
                        string sFiltrado = string.Empty;
                        foreach (char item in dados)
                        {
                            if (!"-_+ ".Contains(item))
                            {
                                sFiltrado += item;
                            }
                        }
                        sFiltrado.ToUpper();
                        foreach (string s in sFiltrado.Split('|'))
                        {
                            if (!string.IsNullOrWhiteSpace(s) && !string.IsNullOrEmpty(s))
                            {
                                s.TrimEnd(); dadosFiltrados.Add(s);
                            }
                        }
                        List<Horario> lista = new List<Horario>();
                        Horario modelo = new Horario
                        {
                            Linha = "",
                            InicioJornada = "",
                            Nome = "",
                            Matricula = "",
                            FimJornada = "",
                        };
                        foreach (string s in dadosFiltrados)
                        {
                            if (s.Contains("BOLETIM")) { modelo.Linha = ""; }
                            foreach (string linha in Variaveis.codlinha_apelido.Keys.ToList())
                            {
                                if (s.Contains(linha))
                                {
                                    modelo.Linha = s;
                                    modelo.InicioJornada = "";
                                    modelo.Nome = "";
                                    modelo.Matricula = "";
                                    modelo.FimJornada = "";
                                }
                            }
                            if (modelo.Linha != "")
                            {
                                if (modelo.InicioJornada == "") { if (DateTime.TryParse(s, out _)) { modelo.InicioJornada = s; } }
                                else if (modelo.Nome == "") { modelo.Nome = s; }
                                else if (modelo.Matricula == "")
                                {
                                    if (int.TryParse(s, out _)) { modelo.Matricula = s; }
                                    else { modelo.Nome = s; }
                                }
                                else if (modelo.FimJornada == "")
                                {
                                    if (DateTime.TryParse(s, out _))
                                    {
                                        modelo.FimJornada = s;
                                        Horario adicionar = new Horario
                                        {
                                            Linha = modelo.Linha,
                                            InicioJornada = modelo.InicioJornada,
                                            Nome = modelo.Nome,
                                            Matricula = modelo.Matricula,
                                            FimJornada = modelo.FimJornada,
                                        };
                                        lista.Add(adicionar);
                                        modelo.InicioJornada = "";
                                        modelo.Nome = "";
                                        modelo.Matricula = "";
                                        modelo.FimJornada = "";
                                    }
                                }
                            }
                        }
                        listaComDicionario = new List<Horario>();
                        foreach (Horario linhas in lista)
                        {
                            foreach (string lin in Variaveis.codlinha_apelido.Keys.ToList())
                            {
                                if (linhas.Linha.Contains(lin))
                                {
                                    Horario adicionar = new Horario
                                    {
                                        Linha = Variaveis.codlinha_apelido[lin],
                                        InicioJornada = linhas.InicioJornada,
                                        Nome = linhas.Nome,
                                        Matricula = linhas.Matricula,
                                        FimJornada = linhas.FimJornada,
                                    };
                                    listaComDicionario.Add(adicionar);
                                }
                            }
                        }
                    }
                    ultimaEscala = listaComDicionario;
                    return listaComDicionario;
                }
                else
                    return null;
            }
        }
    }
}