# BibliotecaOOP

Passo a passo para utilização do código no VS CODE


Abra a pasta Program.cs e execute no terminal: 


Começamos instanciando a Biblioteca:

Biblioteca biblioteca = new Biblioteca();


Logo após, estamos cadastrando dois novos usuários fictícios:

Usuario usuario1 = new Usuario("Luis", "1", "Igra Sul", "91921827");

Usuario usuario2 = new Usuario("Fulano", "2", "Rua Caxias do Sul", "62832932");


Em seguida, estamos cadastrando os usuários na biblioteca:

biblioteca.CadastrarUsuario(usuario1);

biblioteca.CadastrarUsuario(usuario2);


Nesta etapa estamos cadastrando dois novos livros fictícios na biblioteca:

Livro l1 = new Livro("Diário de um banana", "001", "Jeff Kinney", "1243", "Humor", 40);

Livro l2 = new Livro("Dom Quixote", "002", "Miguel de Cervantes", "9732", "História", 41);


Aqui estamos cadastrando os livros na biblioteca:

biblioteca.CadastrarLivro(l1);

biblioteca.CadastrarLivro(l2);


Agora estamos emprestando o livro L1 (“Diário de um Banana”) para o Usuário 1 (“Luis”), e o livro L2 (“Dom Quixote”) para o Usuário 2 (“Fulano”):

l1.Emprestar(usuario1);

l2.Emprestar(usuario2);


Aqui o Usuário 1 (“Luis”) está devolvendo o livro L1 (“Diário de um Banana”) para a biblioteca:

l1.Devolver();


Agora vamos pesquisar os livros cadastrados na biblioteca, buscando por Título, Autor e Gênero:

l1.PesquisarPorTitulo("Diário de um banana");

l1.PesquisarPorAutor("Jeff Kinney");

l1.PesquisarPorGenero("Humor");


Por último, estamos exibindo o histórico de empréstimos dos livros:

usuario1.ExibirHistorico();


Video mostrando o passo a passo de execução do código:
https://drive.google.com/file/d/1WoSESCjwZdBB6nyGJgXXZv-USszVSbvI/view?usp=sharing

Texto acadêmico contendo:
Introdução ao projeto e à importância da programação orientada a objetos.
Explicação detalhada dos quatro pilares da programação orientada a objetos.
Conclusão sobre o aprendizado obtido com o desenvolvimento do projeto.
https://1drv.ms/w/c/3421f873fc9c325f/ETdHUBz6vztOimfdBw-Kc1gBYknmzpmJNlrEsh0aKmDVOQ?e=JYCpLF
