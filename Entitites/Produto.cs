namespace ProdutosApp.Entitites
{
    public class Produto
    {
        #region Propriedades

        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
        public Guid CategoriaId { get; set; }

        #endregion

        #region Relacionamentos

        public Categoria? categoria { get; set; }

        #endregion
    }
}
