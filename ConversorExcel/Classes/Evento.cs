using System;
using System.Diagnostics;

namespace ConversorExcel
{
    public class Evento
    {
        private int matricula;
        private string razao;
        private DateTime fim;

        public int Matricula { get => matricula; set => matricula = value; }
        public string Razao { get => razao; set => razao = value; }
        public DateTime Fim { get => fim; set => fim = value; }
        public Horario EventoParaHorario
        {
            get
            {
                Horario horario = new Horario();
                horario.Matricula = matricula.ToString();
                horario.Nome = Variaveis.matricula_motorista[Matricula];
                horario.Linha = Razao;
                return horario;
            }
        }
    }
}
