
using System.Text.Json.Serialization;

namespace ScreenSound_04.Modelos;

internal class Musica
{
    [JsonPropertyName("song")]
    public string Name { get; set; }
    [JsonPropertyName("artist")]
    public string Artista { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }
    [JsonPropertyName("genre")]
    public string Genero { get; set; }

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"ARTISTA: {Artista}");
        Console.WriteLine($"NOME: {Name}");
        Console.WriteLine($"DURAÇÃO  EM SEGUNDOS: {Duracao/1000}");
        Console.WriteLine($"GENERO: {Genero}");
    }
}
