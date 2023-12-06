public class Livro : ItemBiblioteca
{
    public string Autor { get; set; }
    public Livro(int id, string titulo, string autor) : base(id, titulo)
    {
        Autor = autor; //Inicializa a propriedade Autor com o valor fornecido
    }
    public override void ExibirDescricaoInterna() //Método sobrescrito
    {
        Console.WriteLine(DescricaoInterna);
    }
}