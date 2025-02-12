namespace ScreenSound_Alura.Classes.Desafios
{
    class ContaBanco 
    {
        public ContaBanco(Titular titular, int numero, int agencia, double saldo, double limite, string informacoes)
        {
            Titular = titular;
            Numero = numero;
            Agencia = agencia;
            Saldo = saldo;
            Limite = limite;
        }

        public Titular Titular { get; set; }
        public int Numero { get; set; }
        public int Agencia { get; set; }
        public double Saldo { get; }
        public double Limite { get; set; }

        public string Informacoes => $"Titular: {Titular.Nome}\nCPF: {Titular.Cpf}\nEndereço: {Titular.Endereco}\nAgência: {Agencia}\nNúmero: {Numero}\nSaldo: {Saldo}\nLimite: {Limite}";
    }
}
