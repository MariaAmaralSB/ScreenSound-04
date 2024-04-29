using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musicas> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos =>
        generos.Genero).Distinct().ToList();
        foreach(var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }
    public static void FiltrarArtistasPorGeneroMusical(List<Musicas> musicas,
        string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica =>
        musica.Genero!.Contains(genero)).Select(musica => 
        musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por genero musical >>>>> { genero} ");
        foreach(var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
