using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Senai.WSTowerWebApi.DataBaseFirst.Domains;
using Senai.WSTowerWebApi.DataBaseFirst.Interfaces;
using Senai.WSTowerWebApi.DataBaseFirst.Repositories;

namespace Senai.WSTowerWebApi.DataBaseFirst.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]

    [ApiController]
    public class JogadorController : ControllerBase
    {
        private IJogadorRepository _jogadorRepository;

        public JogadorController()
        {
            _jogadorRepository = new JogadorRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_jogadorRepository.Listar());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int Id)
        {
            return StatusCode(200, _jogadorRepository.BuscarPorId(Id));
        }

        [HttpPost]
        public IActionResult Post(Jogador novoJogador)
        {
            _jogadorRepository.Cadastrar(novoJogador);

            return StatusCode(201);
        }


        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _jogadorRepository.Deletar(id);

            return StatusCode(204);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Jogador jogadorAtualizado)
        {
            Jogador jogadorBuscado = _jogadorRepository.BuscarPorId(id);

            if (jogadorBuscado != null)
            {
                try
                {
                    _jogadorRepository.Atualizar(id, jogadorAtualizado);

                    return StatusCode(200);
                }
                catch (Exception erro)
                {
                    return BadRequest(erro);
                }
            }

            return StatusCode(404);
        }

    }
}