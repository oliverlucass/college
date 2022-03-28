namespace BaseDeDados.Usuario;


public class UsuarioManager
{
    List<string> usuarios = new List<string>(); 

    public void AdicionarUsuarioNaBase()
    {
        Console.Clear();
        Console.WriteLine("\nDIGITE SEU NOME:");
        string nomeDoUsuario = Console.ReadLine();
        usuarios.Add(nomeDoUsuario);
        Console.WriteLine("\nUSUÁRIO " + nomeDoUsuario + " ADICIONADO!!");
        Console.ReadLine();
    }

    public void RemoverUsuarioDaBase()
    {
        Console.Clear();
        Console.WriteLine("\nLISTA DE USUÁRIOS:\n");

        foreach(string user in usuarios)
        {
            Console.WriteLine(user);
        }

        Console.WriteLine("\nDIGITE O NOME DO USUÁRIO QUE DESEJA REMOVER:");
        string usuarioASerRemovido = Console.ReadLine();

        usuarios.Remove(usuarioASerRemovido);
        Console.WriteLine("\n" + usuarioASerRemovido + " REMOVIDO COM SUCESSO!!");

        Console.ReadLine();
    }

    public void AlterarUsuarioNaBase()
    {
        Console.WriteLine("Método Não Implementado (AINDA)");
        Console.ReadLine();
    }

    public void PesquisarUsuarioNaBase()
    {
        Console.WriteLine("Método Não Implementado (AINDA)");
        Console.ReadLine();
    }

    public void ListarTodosOsUsuariosDaBase()
    {
        Console.Clear();
        Console.WriteLine("LISTA DE TODOS OS USUÁRIOS:\n");

        foreach(string user in usuarios)
        {
            Console.WriteLine(user);
        }

        Console.ReadLine();
    }

}