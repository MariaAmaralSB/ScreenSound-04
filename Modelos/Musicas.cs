

using System.Text.Json.Serialization;

namespace ScreenSound_04.Modelos
{
    internal class Musicas
    {
        [JsonPropertyName("song")]
        public string? Nome { get; set; }
        [JsonPropertyName("artist")]
        public string? Artista { get; set; }
        [JsonPropertyName("duration_ms")]
        public int? Duracao{ get; set; }
        [JsonPropertyName("genre")]
        public string Genero { get; set; }

        public void ExibirDetalhesdaMusica()
        {
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Musica: {Nome}");
            Console.WriteLine($"Duraçãp: {Duracao /1000}");
            Console.WriteLine($"Genero musica: {Genero}");
        }
    }
}
