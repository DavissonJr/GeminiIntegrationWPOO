namespace ScreenSound_Alura.Classes.Desafios
{
    class Titular
    {
        // se passar um ctor vazio podemos passar como um objeto em javascript tipo
        //{
        //    Nome = "tal",
        //    Cpf = "123",
        //    Endereco = "Beco do mijo",
        //};
        public Titular()
        {
            
        }

        // assim temos que passar o dado pelo parametro
        public Titular(string nome, string cpf, string endereco)
        {
            Nome = nome;
            Cpf = cpf;
            Endereco = endereco;
        }

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }

    }
}