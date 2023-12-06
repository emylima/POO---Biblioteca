public class Biblioteca //Classe publica
{
    private List<ItemBiblioteca> colecao = new(); //Lista privada
    public void AdicionarItem(ItemBiblioteca item) //Método para adicionar itens na lista
    {
        colecao.Add(item);
        Console.WriteLine($"{item.Titulo} adicionado da biblioteca.");
    }
    public void RemoverItem(ItemBiblioteca item)
    {
        colecao.Remove(item);
        Console.WriteLine($"{item.Titulo} removido da biblioteca.");
    }
    public ItemBiblioteca BuscarItemPorTitulo (string tituloLivro)// SobreCarga de método - busca o livro pelo titulo
    {
        foreach(var item in colecao)
        {
            if(item.Titulo.Equals(tituloLivro)) 
            {
                Console.WriteLine("{tituloLivro} - Encontrado"); //Livro encontrado
                return item;
            }
        }
        Console.WriteLine($"{tituloLivro} - não encontrado"); //Livro não encontrado
        return null;
    }
    public ItemBiblioteca BuscarItemId (int buscarItemId)  // SobreCarga de método - busca o livro pelo Id
    {
        foreach(var item in colecao) // Percorre por toda a lista e exibe uma das mensagens conforme o resultado
    
        {
            if(item.Id == buscarItemId) //Livro encontrado
            {
                Console.WriteLine($"Buscando pelo Id {buscarItemId} - Encontrado");
                return item;
            }
        } 
        Console.WriteLine($"Buscando pelo Id {buscarItemId} - Não encontrado"); //Livro não encontrado
        return null;

    }
    
    
   
}
