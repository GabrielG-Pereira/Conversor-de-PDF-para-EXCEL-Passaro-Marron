using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ConversorExcel
{
    public class Variaveis
    {
        // Dados da dll
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        
        public static List<Evento> eventosDeMotorista = new List<Evento>();
        // Variáveis
        public static List<string> linhasDireita = new List<string>();
        public static Dictionary<string, string> codlinha_apelido = new Dictionary<string, string>();
        public static Dictionary<int, string> matricula_motorista = new Dictionary<int, string>();
        public static Dictionary<int, string> matricula_localidade = new Dictionary<int, string>();
        
    }
}