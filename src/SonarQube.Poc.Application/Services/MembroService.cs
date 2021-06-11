using SonarQube.Poc.Domain.Entidades;
using SonarQube.Poc.Domain.Interfaces;
using SonarQube.Poc.Repository.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SonarQube.Poc.Application.Services
{
    public class MembroService : IMembroService
    {
        private readonly MembroRepository _membroRepository;
        public MembroService(MembroRepository membroRepository)
        {
            _membroRepository = membroRepository;
        }

        public IEnumerable<Membro> Listar()
        {
            return _membroRepository.Listar();
        }
    }
}
