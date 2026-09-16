using Microsoft.AspNetCore.Mvc;
using SistemaGestao.Domain.Entities;
using SistemaGestao.Infra.Data;

public class ProdutoController : Controller
{
    private readonly AppDbContext _context;

    public ProdutoController(AppDbContext context) => _context = context;

    public IActionResult Index() => View();

    [HttpGet]
    public IActionResult ObterProdutos() => Json(_context.Produtos.ToList());

    [HttpPost]
    public IActionResult Criar([FromBody] Produtos produto)
    {
        if (!ModelState.IsValid) return BadRequest();
        _context.Produtos.Add(produto);
        _context.SaveChanges();
        return Ok(produto);
    }
}