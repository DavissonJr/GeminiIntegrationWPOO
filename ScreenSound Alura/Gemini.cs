using System.Net.Http.Json;

namespace ScreenSound.Alura.Modelos
{
    public class Gemini
    {
        private const string ApiKey = "chave_aqui";
        private const string BaseUrl = "https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-flash-latest:generateContent?key=";

        public async Task<string> RespostaAPI(Banda banda)
        {
            var prompt = $"me faça um resumo de 3 linhas sobre a banda {banda.Nome} de forma informal.";

            using var client = new HttpClient();

            var requestBody = new
            {
                contents = new[]
                {
                        new
                        {
                            parts = new[]
                            {
                                new { text = prompt }
                            }
                        }
                    }
            };

            // processo de requisicao
            var response = await client.PostAsJsonAsync($"{BaseUrl}{ApiKey}", requestBody);

            if (response.IsSuccessStatusCode)
            {
                var resultado = await response.Content.ReadFromJsonAsync<RespostaGemini>();

                if (resultado?.Candidates != null && resultado.Candidates.Count > 0)
                {
                    return resultado.Candidates[0].Content.Parts[0].Text;
                }
            }
            else
            {
                var errorResponse = await response.Content.ReadAsStringAsync();
                return $"Error: {errorResponse}";
            }

            return "Nenhum resumo disponível.";
        }

        public class RespostaGemini
        {
            public List<Candidate> Candidates { get; set; }
        }

        public class Candidate
        {
            public Content Content { get; set; }
        }

        public class Content
        {
            public List<Part> Parts { get; set; }
        }

        public class Part
        {
            public string Text { get; set; }
        }
    }
}
