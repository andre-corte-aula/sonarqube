using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SonarQube.Poc.Domain.Entidades;
using SonarQube.Poc.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SonarQube.Poc.Web.Controllers
{
    public class MembroController : Controller
    {
        private readonly ILogger<MembroController> _logger;
        private readonly IMembroService _membroService;

        public MembroController(ILogger<MembroController> logger, IMembroService membroService)
        {
            _logger = logger;
            _membroService = membroService;
        }

        public IActionResult Index()
        {
            IEnumerable<Membro> membros = _membroService.Listar();
            return View(membros);
        }
    }
}
