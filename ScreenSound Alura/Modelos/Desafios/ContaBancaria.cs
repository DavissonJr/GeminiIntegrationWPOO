class ContaBancaria
{
    public int NumeroConta { get; set; }
    public string Titulo { get; set; }
    public double Saldo { get; set; }
    public int Senha { get; set; }

    public void MostrarInformacoesConta()
    {
        Console.WriteLine($"Número da Conta: {NumeroConta}");
        Console.WriteLine($"Titulo: {Titulo}");
        Console.WriteLine($"Saldo: {Saldo}");
        Console.WriteLine($"Senha: {Senha}");
    }
}