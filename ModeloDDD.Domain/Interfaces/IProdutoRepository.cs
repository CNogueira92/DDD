

using ModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ModeloDDD.Domain.Interfaces
{
    public interface IProdutoRepository : IRepositoryBase<Produtos>
    {
        IEnumerable<Produtos> BuscaPornome(string nome);
    }
}
