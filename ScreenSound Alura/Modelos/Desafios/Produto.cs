class Produto
{
    public string nomeProduto { get; set; }
    public string marca { get; set; }

    public double preco { get; set; }
    public int estoque { get; set; }

    public string DetalheProduto => $"O produto {nomeProduto} da marca {marca} custa {preco} e tem {estoque} unidades em estoque";

    public void ExibeDetalhes()
    {
        if (!VerificacaoPreco() || !VerificacaoEstoque())
        {
            return;
        }

        Console.WriteLine($"Nome do produto: {nomeProduto}");
        Console.WriteLine($"Marca: {marca}");
        Console.WriteLine($"Preço: {preco}");
        Console.WriteLine($"Estoque: {estoque}");
    }

    public bool VerificacaoPreco()
    {
        if (preco > 0)
        {
            Console.WriteLine("Preço válido");
            return true;
        }
        else
        {
            Console.WriteLine("Preço inválido");
            return false;
        }
    }

    public bool VerificacaoEstoque()
    {
        if (estoque > 0)
        {
            Console.WriteLine("Estoque válido");
            return true;
        }
        else
        {
            Console.WriteLine("Estoque inválido");
            return false;
        }
    }
}

