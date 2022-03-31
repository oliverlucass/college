namespace BaseDeDados.Usuario;


public class UsuarioManager
{
    List<Usuario> usuarios = new List<Usuario>(); 

    public void AdicionarUsuarioNaBase()
    {
        Console.Clear();
        Usuario novoUsuario = new Usuario();

        Console.WriteLine("Digite o Nome Completo:");
        novoUsuario.Nome = Console.ReadLine();

        Console.WriteLine("\nDigite o CPF:");
        string cpf = Console.ReadLine();
        novoUsuario.CPF = long.Parse(cpf);

        Console.WriteLine("\nDigite o Email:");
        novoUsuario.Email = Console.ReadLine();
        
        Console.WriteLine("\nDigete a Data de Nascimento(AA/MM/DD):");
        novoUsuario.DataDeNascimento = new DateTime(
            int.Parse(Console.ReadLine()),
            int.Parse(Console.ReadLine()),
            int.Parse(Console.ReadLine())
        );
        
        Console.WriteLine(novoUsuario.DataDeNascimento);
        usuarios.Add(novoUsuario);
        Console.ReadLine();
    }

    public void RemoverUsuarioDaBase()
    {
        Console.Clear();
        Console.WriteLine("\nLISTA DE USUÁRIOS:\n");

        foreach(Usuario user in usuarios)
        {
            Console.WriteLine(user);
        }

        // Console.WriteLine("\nDIGITE O NOME DO USUÁRIO QUE DESEJA REMOVER:");
        // string usuarioASerRemovido = Console.ReadLine();

        // usuarios.Remove(usuarioASerRemovido);
        // Console.WriteLine("\n" + usuarioASerRemovido + " REMOVIDO COM SUCESSO!!");

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
        Console.WriteLine("===========================");
        foreach(Usuario user in usuarios)
        {
            Console.WriteLine(user.Nome);
            Console.WriteLine(user.CPF);
            Console.WriteLine(user.Email);
            Console.WriteLine(user.DataDeNascimento);
            Console.WriteLine("*");
        }
        Console.WriteLine("===========================");

        Console.ReadLine();
    }

}