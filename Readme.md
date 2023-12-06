A Programação Orientada a Objetos (POO) é um paradigma de programação que utiliza conceitos de objetos, classes, herança, encapsulamento e polimorfismo para organizar e estruturar o código. O código é organizado em "objetos", que representam instâncias de conceitos do mundo real.

Classes e Objetos:
Classe é uma estrutura que define um tipo de objeto, serve como um modelo ou blueprint para criar objetos. 
Objeto é uma instância de uma classe. Contém dados e métodos relacionados à classe. 

Encapsulamento:
É o conceito de esconder os detalhes internos de implementação de um objeto e expor apenas o que é necessário. Utiliza-se o acesso restrito (public, private, protected) para controlar o acesso aos membros da classe.

Herança:
É um mecanismo que permite criar uma nova classe baseada em uma classe existente. A classe derivada herda as propriedades e métodos da classe base. Exemplo: Livro herda de ItemBiblioteca.

Polimorfismo:
Permite que objetos de diferentes classes sejam tratados como objetos da mesma classe por meio de interfaces comuns. Pode ser alcançado através de sobrecarga de método e interfaces.

Implementação Prática:
Classe ItemBiblioteca:
- Esta classe abstrata serve como uma base comum para itens de biblioteca. Ela possui propriedades para ID, título e descrição interna. O construtor inicializa essas propriedades, e há um método virtual para exibir a descrição interna.

Classe Livro (Herança):
- A classe Livro herda de ItemBiblioteca, demonstrando o conceito de herança. Ela adiciona uma propriedade específica para livros (Autor) e um construtor que inicializa tanto as propriedades da classe base quanto a propriedade específica da classe Livro.

Classe Biblioteca:
- Esta classe gerencia uma coleção de ItemBiblioteca. Ela possui métodos para adicionar, remover e buscar itens na coleção, demonstrando encapsulamento e o uso de coleções para armazenar objetos.






