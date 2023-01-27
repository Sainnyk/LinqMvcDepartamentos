using Microsoft.AspNetCore.Mvc;
using PracticaMañanaMVCLinq.Models;
using PracticaMañanaMVCLinq.Repositories;

namespace PracticaMañanaMVCLinq.Controllers
{
    public class DepartamentosController : Controller
    {
        private RepositoryDepartamentos repo;
        public DepartamentosController(RepositoryDepartamentos repo)
        {
            this.repo = repo;
        }
        public IActionResult ListadoDepartamentos()
        {
            List<Departamento> dept = this.repo.GetDepartamentos();
            return View(dept);
        }
    }
}
