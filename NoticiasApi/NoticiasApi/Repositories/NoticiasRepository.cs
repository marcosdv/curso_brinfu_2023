using Dapper;
using Microsoft.Data.SqlClient;
using NoticiasApi.Models;
using NoticiasApi.Repositories.Interfaces;

namespace NoticiasApi.Repositories;

public class NoticiasRepository : INoticiasRepository
{
    private readonly SqlConnection connection;

    public NoticiasRepository()
    {
        var connectionString = "Server=WINMACDELL-PRFO\\SQLEXPRESS;Database=NoticiasDb;Encrypt=False;Trusted_Connection=True";
        connection = new SqlConnection(connectionString);
    }

    public int Adicionar(Noticia noticia)
    {
        return connection.Execute(@"
          INSERT INTO TbNoticia (Titulo, Texto, DataHora)
            VALUES (@titulo, @texto, @dataHora)",
          new {
              titulo = noticia.Titulo,
              texto = noticia.Texto,
              dataHora = DateTime.Now,
          }
        );
    }

    public int Alterar(Noticia noticia)
    {
        throw new NotImplementedException();
    }

    public Noticia? BuscarPorId(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Noticia> BuscarTodas()
    {
        return connection.Query<Noticia>("SELECT * FROM TbNoticia");
    }

    public int Excluir(int id)
    {
        throw new NotImplementedException();
    }
}
