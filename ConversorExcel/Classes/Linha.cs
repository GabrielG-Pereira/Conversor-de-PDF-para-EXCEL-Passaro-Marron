namespace ConversorExcel
{
    public class Linha
    {
        private string linhaCod;
        private string linhaApelido;
        private bool direita = false;
        public string LinhaCod { get => linhaCod; set => linhaCod = value; }
        public string LinhaApelido { get => linhaApelido; set => linhaApelido = value; }
        public bool Direita { get => direita; set => direita = value; }

    }
}
