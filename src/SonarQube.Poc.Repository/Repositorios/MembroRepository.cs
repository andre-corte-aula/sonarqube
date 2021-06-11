using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SonarQube.Poc.Domain.Entidades;

namespace SonarQube.Poc.Repository.Repositorios
{
    public class MembroRepository
    {
        private readonly string _db = $"{Environment.CurrentDirectory}\\App_Data\\data.json";

        public IEnumerable<Membro> Listar()
        {
            IList<Membro> membros = JsonConvert.DeserializeObject<IList<Membro>>(System.IO.File.ReadAllText(_db));
            return membros.AsEnumerable();
        }
    }
}
