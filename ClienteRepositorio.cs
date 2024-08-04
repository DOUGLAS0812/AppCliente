using Cadastro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio;

public class ClienteRepositorio
{
    public List<Cliente> clientes = new List<Cliente>();

    public void ExcluirCliente()
    {
        Console.Clear();
        Console.Write("informe o codigo do cliente: ");
        var codigo = Console.ReadLine();

        var cliente = clientes.FirstOrDefault(p => p.Id == int.Parse(codigo));

        if (cliente == null)
        {
            Console.WriteLine("Cliente não encontrado! [Enter]");
            Console.ReadKey();
            return;
        }

        imprimirCliente(cliente);
        
        clientes.Remove(cliente);
        Console.WriteLine("Cliente Removido com Sucesso [Enter]");
        Console.ReadKey();

    }

    public void EditarCliente()
    {
        Console.Clear();
        Console.Write("informe o codigo do cliente: ");
        var codigo = Console.ReadLine();

        var cliente = clientes.FirstOrDefault(p => p.Id == int.Parse(codigo));
        
        if (cliente == null)
        {
            Console.WriteLine("Cliente não encontrado! [Enter]");
            Console.ReadKey();
            return;
        }
        imprimirCliente(cliente);

        Console.Write("Nome do cliente: ");
        var nome = Console.ReadLine();
        Console.Write(Environment.NewLine);

        Console.Write("Data de Nascimento: ");
        var dataNascimento = DateOnly.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);

        Console.Write("Desconto: ");
        var desconto = decimal.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);

      
        cliente.Nome = nome;
        cliente.DataNascimento = dataNascimento;
        cliente.Desconto = desconto;
        cliente.CadastradoEm = DateTime.Now;

        Console.WriteLine("Cliente Alterado  com sucesso! [Enter] ");
        imprimirCliente(cliente);
        Console.ReadKey();
    }

    public void CadastrarCliente()
    {
        Console.Clear();

        Console.Write("Nome do cliente: ");
        var nome = Console.ReadLine();
        Console.Write(Environment.NewLine);

        Console.Write("Data de Nascimento: ");
        var dataNascimento = DateOnly.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);

        Console.Write("Desconto: ");
        var desconto = decimal.Parse(Console.ReadLine());
        Console.Write(Environment.NewLine);

        var cliente = new Cliente();
        cliente.Id = clientes.Count + 1 ;
        cliente.Nome = nome;
        cliente.DataNascimento = dataNascimento;
        cliente.Desconto = desconto;
        cliente.CadastradoEm = DateTime.Now;

        clientes.Add(cliente);

        Console.WriteLine("Cliente Cadastrado com sucesso");
        imprimirCliente(cliente);
        Console.ReadKey();  


    }

    public void imprimirCliente(Cliente cliente)
    {
        Console.WriteLine("ID................." + cliente.Id);
        Console.WriteLine("Nome..........." + cliente.Nome);
        Console.WriteLine("Desconto..........." + cliente.Desconto.ToString("0.00"));
        Console.WriteLine("Data Nascimento:" + cliente.DataNascimento);
        Console.WriteLine("Data Cadastro...:" + cliente.CadastradoEm);
        Console.WriteLine("-----------------------------");
    
    }

    public void ExibirClientes()
    {
        Console.Clear();

        foreach (var cliente in clientes)
        {
            imprimirCliente (cliente); 
        }

        Console.ReadKey();
    }
}
