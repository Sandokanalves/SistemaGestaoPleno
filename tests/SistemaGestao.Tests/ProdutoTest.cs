using SistemaGestao.Domain.Entities;
using Xunit;

namespace SistemaGestao.Tests;

public class ProdutoTest
{
    [Fact]
    public void Deve_Criar_Produto_Com_Sucesso()
    {
        var produto = new Produtos { Id = 1, Nome = "Teclado", Preco = 150.00m, Quantidade = 10 };

        Assert.Equal("Teclado", produto.Nome);
        Assert.True(produto.Preco > 0);
    }
}