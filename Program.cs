﻿Biblioteca biblioteca = new Biblioteca();

Usuario usuario1 = new Usuario("Luis", "1", "Igra Sul", "91921827");
Usuario usuario2 = new Usuario("Fulano", "2", "Rua Caxias do Sul", "62832932");

biblioteca.CadastrarUsuario(usuario1);
biblioteca.CadastrarUsuario(usuario2);

Livro l1 = new Livro("Diário de um banana", "001", "Jeff Kinney", "1243", "Humor", 40);
Livro l2 = new Livro("Dom Quixote", "002", "Miguel de Cervantes", "9732", "História", 41);

biblioteca.CadastrarLivro(l1);
biblioteca.CadastrarLivro(l2);

l1.Emprestar(usuario1);
l2.Emprestar(usuario2);

l1.Devolver();

l1.PesquisarPorTitulo("Diário de um banana");
l1.PesquisarPorAutor("Jeff Kinney");
l1.PesquisarPorGenero("Humor");

usuario1.ExibirHistorico();