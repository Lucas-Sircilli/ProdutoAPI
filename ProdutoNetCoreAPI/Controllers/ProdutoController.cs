using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProdutoNetCoreAPI.Data;
using ProdutoNetCoreAPI.Entities;

namespace ProdutoNetCoreAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ProdutoController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    private readonly ILogger<ProdutoController> _logger;

    public ProdutoController(ApplicationDbContext context, ILogger<ProdutoController> logger)
    {
        _context = context;
        _logger = logger;
    }

    [HttpPost(Name = "PostProduto")]
    public async Task<IActionResult> CreateProduto([FromBody] Produto produto)
    {
        try
        {
            if (await _context.Produtos.AnyAsync(x => x.EAN == produto.EAN))
            {
                return Conflict(new { Message = "Já existe um produto com o EAN informado." });
            }

            _context.Produtos.Add(produto);
            await _context.SaveChangesAsync();

            _logger.LogInformation("Produto criado com sucesso: {@Produto}", produto);

            return CreatedAtAction(nameof(GetProduto), new { id = produto.Id }, produto);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao criar produto.");
            return StatusCode(500, new { Message = "Ocorreu um erro inesperado. Tente novamente mais tarde." });
        }
    }

    [HttpGet(Name = "GetProduto")]
    public async Task<IActionResult> GetProduto([FromQuery] int? id)
    {
        if (id.HasValue)
        {
            var produto = await _context.Produtos.FindAsync(id.Value);
            if (produto == null)
                return NotFound(new { Message = $"Produto com Id {id.Value} não encontrado." });

            return Ok(produto);
        }

        var produtos = await _context.Produtos.ToListAsync();
        return Ok(produtos);
    }

    [HttpPut("{id:int}")]
    public async Task<IActionResult> UpdateProduto(int id, [FromBody] Produto produtoAtualizado)
    {
        if (id != produtoAtualizado.Id)
            return BadRequest(new { Message = "ID do produto não confere." });

        var produto = await _context.Produtos.FindAsync(id);
        if (produto == null)
            return NotFound(new { Message = "Produto não encontrado." });

        _context.Entry(produto).CurrentValues.SetValues(produtoAtualizado);

        try
        {
            await _context.SaveChangesAsync();
            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao atualizar produto");
            return StatusCode(500, new { Message = "Erro interno ao atualizar o produto." });
        }
    }

    [HttpDelete("{id:int}")]
    public async Task<IActionResult> DeleteProduto(int id)
    {
        var produto = await _context.Produtos.FindAsync(id);
        if (produto == null)
            return NotFound(new { Message = "Produto não encontrado." });

        _context.Produtos.Remove(produto);

        try
        {
            await _context.SaveChangesAsync();
            return NoContent();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Erro ao deletar produto");
            return StatusCode(500, new { Message = "Erro interno ao deletar o produto." });
        }
    }



}
