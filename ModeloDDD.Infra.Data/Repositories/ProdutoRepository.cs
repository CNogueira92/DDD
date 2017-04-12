using ModeloDDD.Domain.Entities;
using ModeloDDD.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace ModeloDDD.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produtos>, IProdutoRepository
    {
        public IEnumerable<Produtos> BuscaPornome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome == nome);
        }
    }
}
