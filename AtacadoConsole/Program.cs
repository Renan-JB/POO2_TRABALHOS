namespace AtacadoConsole;

using Atacado.BD.EF.Database;
using Microsoft.EntityFrameworkCore;

public class Program
{
    public static void Main(string[] args)
    {
        //Criando a string de conexão com o banco de dados SQL Server.
        string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=bdAtacado;User=usrAtacado;Password=senha123;TrustServerCertificate=True;";
        var options = new DbContextOptionsBuilder<AtacadoContext>().UseSqlServer(connectionString).Options;
        var contexto = new AtacadoContext(options);

        //Executando a pesquisa para obter todos os registros de Categoria.
        //Em seguida, abrindo os resultados e exibindo um por um.
        Console.WriteLine("Executando pesquisa...");
        
foreach (Regiao item in contexto.Regioes.ToList())
        {
            Console.WriteLine($"{item.CodigoRegiao} - {item.Nome}"); 

            //Pesquisa de Regiao.
        } 

foreach (Estado item in contexto.Estados.ToList())
        {
            Console.WriteLine($"{item.CodigoEstado} - {item.Nome}"); 

            //Pesquisa de Estado.
        }  

foreach (Cidade item in contexto.Cidades.ToList())
        {
            Console.WriteLine($"{item.CodigoCidade} - {item.Nome}"); 

            //Pesquisa de Cidade.
        } 

        Console.WriteLine("Fim do programa");
        Console.ReadLine();
    }
}