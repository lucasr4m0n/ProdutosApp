using ProdutosApp.Contexts;
using ProdutosApp.Entitites;

namespace ProdutosApp.Repositories
{
    /// <summary>
    /// Classe de repositório de dados para categoria
    /// </summary>
    public class CategoriaRepository
    {
        //Método para consultar todas as categorias do banco de dados
        public List<Categoria> Consultar()
        {
            //abrindo conexao com o banco de dados através do EntityFramework
            using (var dataContext = new DataContext())
            {
                return dataContext
                        .Set<Categoria>() //consultando dados da tabela de categoria
                        .OrderBy(p => p.Nome) //ordem alfabética de nome
                        .ToList(); //retornando uma listagem com todas as categorias
            }
        }
    }
}
