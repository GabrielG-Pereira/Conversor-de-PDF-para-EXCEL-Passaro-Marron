using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using static ConversorExcel.Variaveis;

namespace ConversorExcel
{
    internal class Registros
    {
        public static void Carregar()
        {
            // Lê as Linhas 
            if (File.Exists("Linhas.json"))
            {
                foreach (Linha linha in JsonConvert.DeserializeObject<List<Linha>>(File.ReadAllText("Linhas.json")))
                {
                    if (linha.Direita) linhasDireita.Add(linha.LinhaApelido);
                    codlinha_apelido.Add(linha.LinhaCod, linha.LinhaApelido);
                }
            }
            else
            {
                linhasDireita = new List<string> { "CAÇAPAVA 5111", "PINDA 5211EX1", "PINDA 5211", "RESERVA", "Folga", "Atestado", "Férias", "Afastamento" };
                codlinha_apelido = new Dictionary<string, string>() { { "5111V", "CAÇAPAVA 5111" }, { "5206V", "PINDA 5206" }, { "5207V", "SÃO JOSÉ" }, { "6290T", "CAMPINAS" }, { "5211EX1V", "PINDA 5211EX1" }, { "5211I", "PINDA 5211" }, { "5212V", "CAMPOS DO JORDÃO" }, { "5306V", "LORENA" }, { "5501V", "SÃO SEBASTIÃO" }, { "8322V", "SÃO PAULO" }, { "RESERVA", "RESERVA" }, { "Folga", "Folga" }, { "Atestado", "Atestado" }, { "Férias", "Férias" }, { "Afastamento", "Afastamento" } };
            }
            // Lê os Motoristas
            if (File.Exists("Motoristas.json"))
            {
                foreach (Motoristas motorista in JsonConvert.DeserializeObject<List<Motoristas>>(File.ReadAllText("Motoristas.json")))
                {
                    matricula_localidade.Add(motorista.Matricula, motorista.Localidade);
                    matricula_motorista.Add(motorista.Matricula, motorista.Nome);
                }
            }
            else
            {
                matricula_motorista = new Dictionary<int, string>() { { 184144, "Rogerio" }, { 182609, "Viana" }, { 132136, "A. Jesus" }, { 180606, "Hermes" }, { 184711, "Eduardo" }, { 183745, "Lira" }, { 178344, "Jorme" }, { 182279, "P. Oliveira" }, { 183654, "Waldir" }, { 182441, "Alexsander" }, { 184169, "Florentino" }, { 141232, "Moraes" }, { 184385, "Carlos Alb" }, { 178626, "Ribeiro" }, { 181353, "R. Braga" }, { 182093, "Valdineia" }, { 182323, "Ademilson" }, { 178782, "Osmar" }, { 181992, "Benedito" }, { 180655, "Valdenildo" }, { 184387, "Washington" }, { 180983, "Roberto" }, { 184168, "Denis" }, { 176354, "Mayer" }, { 181752, "Alexandre" }, { 172545, "Marcelo" }, { 177881, "Paulo Coel" }, { 181885, "Elielton" }, { 179805, "Jarbas" }, { 141968, "Rocha" }, { 184108, "Rubian" }, { 182475, "Elaine" }, { 182331, "Luiz Ribeiro" }, { 178963, "Kleber" }, { 179965, "Manuel" }, { 182131, "Altamir" }, { 181689, "William" }, { 181529, "Galvão" }, { 181200, "Andre Luiz" }, { 177890, "Fagner" }, { 149047, "Vasconcelos" }, { 168629, "S. Santos" }, { 171361, "Rodrigo" }, { 182012, "Geann" }, { 143642, "Agostinho" }, { 181876, "Ciro" }, { 184677, "Noelito" }, { 173894, "Jefferson" }, { 136794, "Ronildo" }, { 179839, "M. Oliveira" }, { 138622, "Idalecio" }, { 168955, "J. Benedito" }, { 178420, "Expedito" }, { 178447, "Luiz Carlos" }, { 177067, "Paulo" }, { 181549, "Correa" }, { 184754, "Almir" }, { 183743, "Jussier" }, { 181877, "Flavio" }, { 176761, "Lucas" }, { 178765, "Geovani" }, { 181154, "Edivaldo" }, { 109568, "Matos" }, { 181042, "A. Trindade" }, { 184141, "Anderson" }, { 179916, "Leandro" }, { 184146, "João Paulo" }, { 138266, "Wallace" }, { 184567, "Diego" }, { 184529, "Reginaldo" }, { 182202, "J. Durval" }, { 184050, "Celso" }, { 182267, "Waldemir" }, { 180561, "Decio" }, { 58653, "Claudio" }, { 173363, "Edilson" }, { 132268, "Aristides" }, { 182344, "Everaldo" }, { 179643, "Altair" }, { 169072, "Portes" }, { 182526, "Luciano S." }, { 182668, "Marcos" }, { 181499, "Denival" }, { 181553, "Dias" }, { 181332, "Aroldo" }, { 184763, "Ricardo" }, { 146269, "Rivelino" }, { 175943, "L. Braga" }, { 178156, "A. Costa" }, { 176893, "Devanir" } };
                matricula_localidade = new Dictionary<int, string>() { { 184144, "Caçapava" }, { 182609, "Caçapava" }, { 181154, "Pinda" }, { 109568, "Pinda" }, { 181042, "Pinda" }, { 184141, "Pinda" }, { 184754, "Pinda" }, { 179916, "Pinda" }, { 184146, "Pinda" }, { 138266, "Pinda" }, { 184567, "Pinda" }, { 184529, "Pinda" }, { 182202, "Pinda" }, { 184050, "Pinda" }, { 182267, "Pinda" }, { 180561, "Pinda" }, { 58653, "Pinda" }, { 173363, "Pinda" }, { 132268, "Pinda" }, { 182344, "Pinda" }, { 179643, "Pinda" }, { 169072, "Pinda" }, { 182526, "Pinda" }, { 182668, "Pinda" }, { 181499, "Pinda" }, { 181553, "Pinda" }, { 181332, "Pinda" }, { 184763, "Pinda" }, { 146269, "Pinda" }, { 175943, "Pinda" }, { 181549, "Pinda" }, { 178156, "Pinda" }, { 177067, "Pinda" }, { 176893, "Pinda" }, { 132136, "Taubaté" }, { 180606, "Taubaté" }, { 184711, "Taubaté" }, { 183745, "Taubaté" }, { 178344, "Taubaté" }, { 182279, "Taubaté" }, { 183654, "Taubaté" }, { 182441, "Taubaté" }, { 184169, "Taubaté" }, { 141232, "Taubaté" }, { 184385, "Taubaté" }, { 178626, "Taubaté" }, { 181353, "Taubaté" }, { 182093, "Taubaté" }, { 182323, "Taubaté" }, { 178782, "Taubaté" }, { 181992, "Taubaté" }, { 180655, "Taubaté" }, { 184387, "Taubaté" }, { 180983, "Taubaté" }, { 184168, "Taubaté" }, { 176354, "Taubaté" }, { 181752, "Taubaté" }, { 172545, "Taubaté" }, { 177881, "Taubaté" }, { 181885, "Taubaté" }, { 179805, "Taubaté" }, { 141968, "Taubaté" }, { 184108, "Taubaté" }, { 182475, "Taubaté" }, { 182331, "Taubaté" }, { 178963, "Taubaté" }, { 179965, "Taubaté" }, { 182131, "Taubaté" }, { 181689, "Taubaté" }, { 180200, "Taubaté" }, { 181529, "Taubaté" }, { 181200, "Taubaté" }, { 177890, "Taubaté" }, { 149047, "Taubaté" }, { 168629, "Taubaté" }, { 171361, "Taubaté" }, { 182012, "Taubaté" }, { 143642, "Taubaté" }, { 181876, "Taubaté" }, { 184677, "Taubaté" }, { 173894, "Taubaté" }, { 136794, "Taubaté" }, { 179839, "Taubaté" }, { 138622, "Taubaté" }, { 168955, "Taubaté" }, { 178420, "Taubaté" }, { 184383, "Taubaté" }, { 178447, "Taubaté" }, { 183743, "Taubaté" }, { 181877, "Taubaté" }, { 176761, "Pinda" }, { 178765, "Taubaté" } };
            }
            // Lê os eventos
            if (File.Exists("Eventos.json"))
            {
                foreach (Evento evento in JsonConvert.DeserializeObject<List<Evento>>(File.ReadAllText("Eventos.json")))
                {
                    if (DateTime.Compare(evento.Fim, DateTime.Now) > 0)
                    {
                        eventosDeMotorista.Add(evento);
                    }
                }
            }
        }
        public static void Salvar()
        {
            // Salva as linhas
            List<Linha> linhas = new List<Linha>();
            foreach(string key in codlinha_apelido.Keys)
            {
                Linha linha = new Linha();
                if (linhasDireita.Contains(codlinha_apelido[key]))
                    linha.Direita = true;
                linha.LinhaCod = key;
                linha.LinhaApelido = codlinha_apelido[key];
                linhas.Add(linha);
            }
            File.WriteAllText("Linhas.json", JsonConvert.SerializeObject(linhas, Formatting.Indented));
            // Salva os motoristas
            List<Motoristas> motoristas = new List<Motoristas>();
            foreach (int key in matricula_motorista.Keys)
            {
                Motoristas motorista = new Motoristas();
                motorista.Matricula = key;
                motorista.Nome = matricula_motorista[key];
                motorista.Localidade = matricula_localidade[key];
                motoristas.Add(motorista);
            }
            File.WriteAllText("Motoristas.json", JsonConvert.SerializeObject(motoristas, Formatting.Indented));
            // Salva os eventos
            File.WriteAllText("Eventos.json", JsonConvert.SerializeObject(eventosDeMotorista, Formatting.Indented));
        }
    }
}
