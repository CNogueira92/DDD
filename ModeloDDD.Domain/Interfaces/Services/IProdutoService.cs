using ModeloDDD.Domain.Entities;
using System.Collections.Generic;

namespace ModeloDDD.Domain.Interfaces.Services
{
    interface IProdutoService : IServiceBase<Produtos>
    {

        IEnumerable<Produtos> BuscaPornome(string nome);
    }
}
