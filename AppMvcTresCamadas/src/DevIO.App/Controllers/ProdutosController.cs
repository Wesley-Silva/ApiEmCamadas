using AutoMapper;
using DevIO.App.Models;
using DevIO.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.App.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IProdutoRepository _produtoRepository;
        private readonly IProdutoService _produtoService;

        public ProdutosController(IMapper mapper, IProdutoRepository produtoRepository, IProdutoService produtoService)
        {
            _mapper = mapper;
            _produtoRepository = produtoRepository;
            _produtoService = produtoService;
        }

        [Route("lista-de-produtos")]
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<ProdutoViewModel>>(await _produtoRepository.ObterProdutosFornecedores()));
        }
    }
}
