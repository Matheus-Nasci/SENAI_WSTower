using Senai.WSTowerWebApi.DataBaseFirst.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.WSTowerWebApi.DataBaseFirst.Interfaces
{
    interface IJogoRepository
    {
        List<Jogo> Listar();

        void Cadastrar(Jogo novoJogo);

        void Atualizar(int id, Jogo jogoAtualizado);

        void Deletar(int id);

        Jogo BuscarPorId(int id);
    }
}
