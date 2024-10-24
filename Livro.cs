public class Livro : ItemBiblioteca, IEmprestavel, IPesquisavel
{
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public string Genero { get; set; }
    public int QuantidadeEmEstoque { get; set; }

    public Livro(string titulo, string codigo, string autor, string isbn, string genero, int QuantidadeEmEstoque)
    :base(titulo, codigo)
    {
        Autor = autor;
        ISBN = isbn;
        Genero = genero;
        this.QuantidadeEmEstoque = QuantidadeEmEstoque;
    }
    public override void Emprestar(Usuario usuario)
    {
        if (QuantidadeEmEstoque > 0)
        {
            QuantidadeEmEstoque--;
            usuario.AdicionarLivroEmprestimo(this);
            Console.WriteLine($"O livro '{Titulo}' foi emprestado para o cliente {usuario.Nome}");
        }
        else
        {
            Console.WriteLine($"Não existem exemplares do livro '{Titulo}' no momento");
        }
    }
    public override void Devolver()
    {
        QuantidadeEmEstoque++;
        Console.WriteLine($"O livro '{Titulo}' foi devolvido para o estoque");
    }
    public void PesquisarPorTitulo(string titulo)
    {
        Console.WriteLine($"Busca por título '{titulo}'");
        foreach (var l in Biblioteca.Livros)
        {
            if (l.Titulo.IndexOf(titulo, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                Console.WriteLine($"Título: {l.Titulo}\n Autor: {l.Autor}\n Código: {l.Codigo}\n ISBN: {l.ISBN}\n Quantidade: {l.QuantidadeEmEstoque}");
            }
        }
    }
    public void PesquisarPorAutor(string autor)
    {
        Console.WriteLine($"Busca por autor '{autor}'");
        foreach (var l in Biblioteca.Livros)
        {
            if (l.Autor.IndexOf(autor, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                Console.WriteLine($"Título: {l.Titulo}\n Autor: {l.Autor}\n Código: {l.Codigo}\n ISBN: {l.ISBN}");
            }
        }
    }
    public void PesquisarPorGenero(string genero)
    {
        Console.WriteLine($"Busca por gênero '{genero}'");
        foreach (var l in Biblioteca.Livros)
        {
            if (l.Genero.IndexOf(genero, StringComparison.OrdinalIgnoreCase) >= 0)
            {
                Console.WriteLine($"Título: {l.Titulo}\n Autor: {l.Autor}\n Código: {l.Codigo}\n ISBN: {l.ISBN}");
            }
        }
    }
}