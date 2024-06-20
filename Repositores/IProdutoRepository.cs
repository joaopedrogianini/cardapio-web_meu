using CardapioWeb.Models;

namespace CardapioWeb.Repositores
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> GetAll();
        IEnumerable<Produto> GetByPreferido();
        Produto GetById(int id);
    }
}
