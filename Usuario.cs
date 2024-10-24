public class Usuario{
    public string Nome { get; set; }

    public string NumeroIdentificacao { get; set; }

    public string Endereco { get; set; }

    public string Contato { get; set; }

    public List<Livro> HistoricoDeEmprestimos { get; set; } = new List<Livro>();


    public Usuario(string nome, string numeroIdentificacao, string endereco, string contato)
    {
        Nome = nome;
        NumeroIdentificacao = numeroIdentificacao;
        Endereco = endereco;
        Contato = contato;
    }

    public void ExibirInformacoes(){
        Console.WriteLine($"Nome: {Nome}, Numero de Identificacao: {NumeroIdentificacao}, Endereço: {Endereco}, Contato: {Contato}");

    }

    public void AdicionarLivroEmprestimo(Livro livro){
        HistoricoDeEmprestimos.Add(livro);
    }
    public void ExibirHistorico(){
        Console.WriteLine("Histórico de Empréstimos");
        foreach(var l in HistoricoDeEmprestimos){
            Console.WriteLine($"Titulo: {l.Titulo}\n Autor: {l.Autor}\n Codigo: {l.Codigo}\n ISBN: {l.ISBN}");
       }
    }
}