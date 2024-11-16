namespace ConversorExcel
{
    public class Horario
    {

        private string linha;
        private string nome;
        private string matricula;
        private string inicioJornada = "";
        private string fimJornada;

        public string Linha { get => linha; set => linha = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string InicioJornada { get => inicioJornada; set => inicioJornada = value; }
        public string FimJornada { get => fimJornada; set => fimJornada = value; }
    }
}
