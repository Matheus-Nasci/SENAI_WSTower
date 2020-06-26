using System;
using System.Collections.Generic;

namespace Senai.WSTowerWebApi.DataBaseFirst.Domains
{
    public partial class Selecao
    {
        public Selecao()
        {
            Jogador = new HashSet<Jogador>();
            JogoSelecaoCasaNavigation = new HashSet<Jogo>();
            JogoSelecaoVisitanteNavigation = new HashSet<Jogo>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public byte[] Bandeira { get; set; }
        public byte[] Uniforme { get; set; }
        public string Escalacao { get; set; }

        public ICollection<Jogador> Jogador { get; set; }
        public ICollection<Jogo> JogoSelecaoCasaNavigation { get; set; }
        public ICollection<Jogo> JogoSelecaoVisitanteNavigation { get; set; }
    }
}
