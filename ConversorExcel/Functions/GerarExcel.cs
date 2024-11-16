using ClosedXML.Excel;
using System;
using System.Collections.Generic;

namespace ConversorExcel
{
    internal class GerarExcel
    {
        private static Dictionary<char, string> cabecalho_texto = new Dictionary<char, string>()
        {
            { 'A', "LINHA"},
            { 'B', "OBS"},
            { 'C', "HORÁRIO"},
            { 'D', "MOTORISTA"},
            { 'F', "LINHA"},
            { 'G', "OBS"},
            { 'H', "HORÁRIO"},
            { 'I', "MOTORISTA"}
        };
        private static Dictionary<char, int> coluna_largura = new Dictionary<char, int>()
        {
            { 'A', 22 },
            { 'B', 25 },
            { 'C', 12 },
            { 'D', 22 },
            { 'E', 15 },
            { 'F', 22 },
            { 'G', 25 },
            { 'H', 12 },
            { 'I', 22 }
        };

        public static void fun_GerarExcel(string caminho, List<Horario> linhas)
        {
            XLWorkbook workbook = new XLWorkbook();
            IXLWorksheet worksheet = workbook.Worksheets.Add("Escala");
            for (char c = 'A'; c < 'J'; c++)
                worksheet.Column(c.ToString()).Width = coluna_largura[c];
            int linha = 4;
            int linhaEsquerda = linha;
            int linhaDireita = linha;
            string registroLinha = "";
            foreach (Horario l in linhas)
            {
                // Define a coluna a inserir os dados e a posição
                List<char> coluna = new List<char>();
                if (Variaveis.linhasDireita.Contains(l.Linha)) { coluna = new List<char> { 'F', 'G', 'H', 'I', 'J' }; linha = linhaDireita; }
                else { coluna = new List<char> { 'A', 'B', 'C', 'D', 'E' }; linha = linhaEsquerda; }
                
                if (registroLinha != l.Linha)
                {
                    for (char c = coluna[0]; c < coluna[4]; c++)
                    {
                        if (linha > 4)
                        {
                            IXLCell ultimoDado = worksheet.Cell(column: c.ToString(), row: linha);
                            ultimoDado.Style.Border.TopBorder = XLBorderStyleValues.Medium;
                        }
                    }
                    linha++;
                    for (char c = coluna[0]; c < coluna[4]; c++)
                    {
                        IXLCell cabecalholinha = worksheet.Cell(column: c.ToString(), row: linha);
                        cabecalholinha.Value = cabecalho_texto[c];
                        cabecalholinha.Style.Font.Bold = true;
                        cabecalholinha.Style.Font.FontSize = 14;
                        cabecalholinha.Style.Fill.BackgroundColor = XLColor.LavenderGray;
                        cabecalholinha.Style.Border.OutsideBorder = XLBorderStyleValues.Medium;
                        cabecalholinha.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        cabecalholinha.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    }
                    linha++;
                    registroLinha = l.Linha;
                    int mergeLim = 0;
                    foreach (Horario lim in linhas)
                    {
                        if (lim.Linha == l.Linha)
                        {
                            mergeLim++;
                            IXLCell cell_LinhaBorda = worksheet.Cell(column: coluna[0].ToString(), row: linha + mergeLim - 1);
                            cell_LinhaBorda.Style.Border.OutsideBorder = XLBorderStyleValues.Medium;
                        }
                    }
                    if (mergeLim > 0)
                    {
                        string range = coluna[0].ToString() + linha + ":" + coluna[0].ToString() + (mergeLim + linha - 1);
                        worksheet.Range(range).Merge();
                    }
                    IXLCell cell_Linha = worksheet.Cell(column: coluna[0].ToString(), row: linha);
                    cell_Linha.Value = l.Linha;
                    cell_Linha.Style.Font.Bold = true;
                    cell_Linha.Style.Font.FontSize = 20;
                    cell_Linha.Style.Font.FontColor = XLColor.Red;
                    cell_Linha.Style.Fill.BackgroundColor = XLColor.LightGray;
                    cell_Linha.Style.Border.OutsideBorder = XLBorderStyleValues.Medium;
                    cell_Linha.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    cell_Linha.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                    cell_Linha.Style.Alignment.WrapText = true;
                }
                // Insere os dados
                for (char c = coluna[1]; c < coluna[4]; c++)
                {
                    IXLCell cell = worksheet.Cell(column: c.ToString(), row: linha);
                    if (c == coluna[1])
                    {
                        cell.Value = "";
                        cell.Style.Font.FontColor = XLColor.Red;
                        cell.Style.Fill.BackgroundColor = XLColor.Yellow;
                    }
                    else if (c == coluna[2] && l.Linha != "Folga")
                    {
                        cell.Value = Convert.ToDateTime(l.InicioJornada).ToString("HH:mm:ss");
                        cell.Style.DateFormat.Format = "hh:mm";
                    }
                    else if (c == coluna[3])
                        cell.Value = l.Matricula + " " + l.Nome;
                    cell.Style.Font.Bold = true;
                    cell.Style.Font.FontSize = 12;
                    cell.Style.Border.TopBorder = XLBorderStyleValues.Thin;
                    cell.Style.Border.LeftBorder = cell.Style.Border.RightBorder = XLBorderStyleValues.Medium;
                    cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                    cell.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
                }
                linha++;
                if (coluna[0] == 'F') { linhaDireita = linha; }
                else { linhaEsquerda = linha; }
            }
            // Finalização da ultima borda 
            foreach(string s in new List<string>() { "AE", "FJ" })
            {
                for (char c = s[0]; c < s[1]; c++)
                {
                    if (c == 'F') { linhaEsquerda = linhaDireita; }
                    IXLCell ultimoDado = worksheet.Cell(column: c.ToString(), row: linhaEsquerda);
                    ultimoDado.Style.Border.TopBorder = XLBorderStyleValues.Medium;
                }
            }
            // Insere o cabeçalho do arquivo
            worksheet.Range("A1:I3").Merge();
            worksheet.Range("A4:I4").Merge();
            foreach (int i in new List<int> { 1, 4 })
            {
                IXLCell cabecalho = worksheet.Cell(column: "A", row: i);
                switch (i)
                {
                    case 1:
                        cabecalho.Value = "ESCALA – MATRIZ";
                        cabecalho.Style.Font.FontSize = 24;
                        break;
                    case 4:
                        cabecalho.Value = "Divulgação de Escala de Serviço para Profissionais";
                        cabecalho.Style.Font.FontSize = 18;
                        break;
                }
                cabecalho.Style.Font.Bold = true;
                cabecalho.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                cabecalho.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;
            }
            workbook.SaveAs(caminho);
        }
    }
}
