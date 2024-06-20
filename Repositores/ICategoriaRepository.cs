using CardapioWeb.Models;

namespace CardapioWeb.Repositores
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> GetAll();
    }
}
