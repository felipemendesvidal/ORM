using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.ef.core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private IProdutoRepository _produtoRepository;

        public ProdutoController()
        {
            _produtoRepository = new ProdutoRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {

                var produtos = _produtoRepository.Listar();

                if (produtos.Count == 0)
                    return NoContent();

                return Ok(produtos);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            try
            {
                Produto produto = _produtoRepository.BuscarPorId(id);

                if (produto == null)
                    return NotFound();
                return Ok(produto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //FromForm - Recebe os dados do produto via form-Data
        [HttpPost]
        public IActionResult Post([FromForm] Produto produto)
        {
            try
            {
                //Verifico se foi enviado uma arquivo com a imagem
                if (produto.Imagem != null)
                {
                    var urlImagem = Upload.Local(produto.Imagem);

                    produto.UrlImagem = urlImagem;

                }
                _produtoRepository.Adicionar(produto);

                return Ok(produto);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Put(Guid id, Produto produto)
        {
            try
            {
                produto.Id = id;
                _produtoRepository.Editar(produto);

                return Ok(produto);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                var produto = _produtoRepository.BuscarPorId(id);

                if (produto == null)
                    return NotFound();
                _produtoRepository.Remover(id);

                return Ok(produto);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
