using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFparaEXCEL
{
    internal class Variaveis
    {
        public static List<string> iniciadoresPaginas = new List<string> { "BOLETIM" };
        public static List<string> codLinhas = new List<string> { "5111V", "5207V", "5211EX1V", "5211I", "5212V", "5306V", "5501V", "8322V", "RESERVA" };
        public static string filtro = "-_+ ";
        public static string separador = "|";
        public static Dictionary<string, string> apelidoLinha = new Dictionary<string, string>()
        {
            { "5111V", "TAU X CCP"},
            { "5207V", "TAU X SJC"},
            { "5211EX1V", "TAU X PIN EX1"},
            { "5211I", "TAU X PIN EV"},
            { "5212V", "TAU X CJO"},
            { "5306V", "TAU X LOR"},
            { "5501V", "TAU X SSB"},
            { "8322V", "TAU X SPO"},
            { "RESERVA", "Reserva"}
        };
    }
}
