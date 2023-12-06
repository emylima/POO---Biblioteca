Livro livro1 = new(1, "A coragem de ser imperfeito", "Brené Brown");

Livro livro2 = new(2, "O lar da Srta. Peregrine", "Ranson Riggs");

Livro livro3 = new(3, "As vantagens de ser invisível", "Stephen Chbosky");



Biblioteca biblioteca = new();
biblioteca.AdicionarItem(livro1);
biblioteca.AdicionarItem(livro2);
biblioteca.AdicionarItem(livro3);

biblioteca.BuscarItemPorTitulo("O lar da Srta. Peregrine");
biblioteca.BuscarItemPorTitulo("Quem é você Alasca?");

biblioteca.BuscarItemId(5);
biblioteca.BuscarItemId(3);
biblioteca.RemoverItem(livro1);