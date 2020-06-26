using Senai.WSTowerWebApi.DataBaseFirst.Domains;
using Senai.WSTowerWebApi.DataBaseFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.WSTowerWebApi.DataBaseFirst.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        WSTowerContext ctx = new WSTowerContext();

        public void Atualizar(int id, Jogo jogoAtualizado)
        {
            Jogo jogoBuscado = ctx.Jogo.Find(id);

            jogoBuscado.SelecaoCasa = jogoAtualizado.SelecaoCasa;

            jogoBuscado.SelecaoVisitante = jogoAtualizado.SelecaoVisitante;

            jogoBuscado.PlacarCasa = jogoAtualizado.PlacarCasa;

            jogoBuscado.PlacarVisitante = jogoAtualizado.PlacarVisitante;

            jogoBuscado.PenaltisCasa = jogoAtualizado.PenaltisCasa;

            jogoBuscado.PenaltisVisitante = jogoAtualizado.PenaltisVisitante;

            jogoBuscado.Data = jogoAtualizado.Data;

            jogoBuscado.Estadio = jogoAtualizado.Estadio;
        }

        public Jogo BuscarPorId(int id)
        {
            return ctx.Jogo.FirstOrDefault(j => j.Id == id);
        }

        public void Cadastrar(Jogo novoJogo)
        {
            ctx.Jogo.Add(novoJogo);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Jogo jogoBuscado = ctx.Jogo.Find(id);

            ctx.Jogo.Remove(jogoBuscado);

            ctx.SaveChanges();
        }

        public List<Jogo> Listar()
        {
            return ctx.Jogo.ToList();
        }
    }
}
