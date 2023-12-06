public abstract class ItemBiblioteca //Classe abstrata
{
    //Propriedades
    public int Id { get; set; }
    public string Titulo { get; set; }
    protected string DescricaoInterna { get; set; } //Propriedade protegida
    protected ItemBiblioteca(int id, string titulo) //Método protegido
    {
        Id = id; //Inicializando a propriedade Id com o valor fornecido
        Titulo = titulo; //Inicializando a propriedade Título com o valor fornecido
        DescricaoInterna = "Descrição Padrão";
    }
    public virtual void ExibirDescricaoInterna() //Método publico
    {
        Console.WriteLine(DescricaoInterna);
    }
    
}