public class Biblioteca
{
    private static List<Livro> livros = new List<Livro>();
    private List<Usuario> usuarios = new List<Usuario>();

    public static IReadOnlyList<Livro> Livros => livros;

    public List<Usuario> Usuarios => usuarios;

    public void CadastrarLivro(Livro livro)
    {
        livros.Add(livro);
        Console.WriteLine($"{livro.Titulo} cadastrado.");
    }

    public void CadastrarUsuario(Usuario usuario)
    {
        usuarios.Add(usuario);
        Console.WriteLine($"{usuario.Nome} cadastrado.");
    }

    public void EmprestarLivro(string codLivro, string numUsuario)
    {
    }

    public void DevolverLivro(string codLivro)
    {
    }

    public void ListarLivros()
    {
        foreach (var l in livros)
        {
            Console.WriteLine($"Título: {l.Titulo}\n Autor: {l.Autor}\n ISBN: {l.ISBN} Gênero: {l.Genero}\n Código: {l.Codigo}\n Quantidade: {l.QuantidadeEmEstoque}");
        }
    }

    public void ListarUsuarios()
    {
        foreach (var cliente in usuarios)
        {
            Console.WriteLine($"Nome do cliente: {cliente.Nome}\n Id: {cliente.NumeroIdentificacao}\n Endereço: {cliente.Endereco}\n Contatos: {cliente.Contato}");
        }
    }
}