using SonarQube.Poc.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonarQube.Poc.Domain.Interfaces
{
    public interface IMembroService
    {
        IEnumerable<Membro> Listar();
    }
}
