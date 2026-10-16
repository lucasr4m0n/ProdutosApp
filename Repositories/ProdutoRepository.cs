using ProdutosApp.Contexts;
using ProdutosApp.Entitites;

namespace ProdutosApp.Repositories
{
    /// <summary>
    /// Classe de repositório de dados para produto
    /// </summary>
    public class ProdutoRepository
    {
        //Método para inserir (gravar) um produto no banco de dados
        public void Inserir(Produto produto)
        {
            //abrindo conexao com o banco de dados através do EntityFramework
            using (var dataContext = new DataContext())
            {
                dataContext.Add(produto); //preparando o produto para ser cadastrado no banco de dados
                dataContext.SaveChanges(); //executando a operacao no banco de dados
            }
        }

        //Método para atualizar (modificar) um produto no banco de dados
        public void Atualizar(Produto produto)
        {
            //abrindo conexao com o banco de dados através do Entity Framework
            using (var dataContext = new DataContext())
            {
                dataContext.Update(produto); //preparando o produto para ser atualizado no banco de dados
                dataContext.SaveChanges(); //executando a operacao no banco de dados
            }
        }

        //Método para excluir (remover) um produto no banco de dados
        public void Excluir(Produto produto)
        {
            //abrindo conexao com o banco de dados através do Entity Framework
            using (var dataContext = new DataContext())
            {
                dataContext.Remove(produto); //preparando o produto para ser excluido no banco de dados
                dataContext.SaveChanges(); //executando a operacao no banco de dados
            }
        }

        //Método para consultar 1 produto através do ID
        public Produto? ObterPorId(Guid id)
        {
            // abrindo conexao com o banco de dados através do EntityFramework
            using (var dataContext = new DataContext())
            {
                return dataContext
                        .Set<Produto>() //consultando os dados da entidade produto
                        .Where(p => p.Id == id) //filtrando o produto pelo id
                        .FirstOrDefault(); //retornando o primeiro produto encontrado 
                                           // ou retornar nul se nenhum produto foi encontrado
            }   
        }
    }
}
