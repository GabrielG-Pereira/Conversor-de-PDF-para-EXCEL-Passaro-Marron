using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDFparaEXCEL
{
    public class Linhas
    {

        private string linha;
        private string motoristaNome;
        private string motoristaMatricula;
        private string motoristaInicioJornada;
        private string motoristaFimJornada;

        public string Linha { get => linha; set => linha = value; }
        public string MotoristaNome { get => motoristaNome; set => motoristaNome = value; }
        public string MotoristaMatricula { get => motoristaMatricula; set => motoristaMatricula = value; }
        public string MotoristaInicioJornada { get => motoristaInicioJornada; set => motoristaInicioJornada = value; }
        public string MotoristaFimJornada { get => motoristaFimJornada; set => motoristaFimJornada = value; }
    }
}
