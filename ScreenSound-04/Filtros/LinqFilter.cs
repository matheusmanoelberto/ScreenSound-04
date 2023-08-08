
using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros;

internal class LinqFilter
{
    public static void FiltraTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach(var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltraArtistaPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistaPorGeneroMusical = musicas.Where(musica => musica.Genero.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artitas por gênero musical >>>{genero}");
        foreach( var artista in artistaPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
