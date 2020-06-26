using Microsoft.AspNetCore.Mvc;
using Senai.WSTowerWebApi.DataBaseFirst.Domains;
using Senai.WSTowerWebApi.DataBaseFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.WSTowerWebApi.DataBaseFirst.Repositories
{
    public class JogadorRepository : IJogadorRepository
    {
        WSTowerContext ctx = new WSTowerContext();

        public void Atualizar(int id, Jogador jogadorAtualizado)
        {
            Jogador jogarBuscado = ctx.Jogador.Find(id);

            jogarBuscado.Nome = jogadorAtualizado.Nome;

            jogarBuscado.Nascimento = jogadorAtualizado.Nascimento;

            jogarBuscado.Posicao = jogadorAtualizado.Posicao;

            jogarBuscado.Qtdefaltas = jogadorAtualizado.Qtdefaltas;

            jogarBuscado.QtdecartoesAmarelo = jogadorAtualizado.QtdecartoesAmarelo;

            jogarBuscado.QtdecartoesVermelho = jogadorAtualizado.QtdecartoesVermelho;

            jogarBuscado.Qtdegols = jogadorAtualizado.Qtdegols;

            jogarBuscado.Informacoes = jogadorAtualizado.Informacoes;

            jogarBuscado.NumeroCamisa = jogadorAtualizado.NumeroCamisa;

            jogarBuscado.SelecaoId = jogadorAtualizado.SelecaoId;

            ctx.SaveChanges();
        }

        public Jogador BuscarPorId(int id)
        {
            return ctx.Jogador.FirstOrDefault(j => j.Id == id) ;
        }

        public void Cadastrar(Jogador novoJogador)
        {
            ctx.Jogador.Add(novoJogador);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Jogador jogadorBuscado = ctx.Jogador.Find(id);

            ctx.Jogador.Remove(jogadorBuscado);

            ctx.SaveChanges();
        }

        public List<Jogador> Listar()
        {
            return ctx.Jogador.ToList();
        }
    }
}
