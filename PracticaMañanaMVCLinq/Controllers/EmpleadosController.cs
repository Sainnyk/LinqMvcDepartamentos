using Microsoft.AspNetCore.Mvc;
using PracticaMañanaMVCLinq.Models;
using PracticaMañanaMVCLinq.Repositories;

namespace PracticaMañanaMVCLinq.Controllers
{
    public class EmpleadosController : Controller
    {
        private RepositoryEmpleados repo;
        public EmpleadosController(RepositoryEmpleados repo)
        {
            this.repo = repo;
        }
        public IActionResult ListadoEmpleados(int id)
        {
            List<Empleado> empleados = this.repo.GetEmpleados(id);
            return View(empleados);
        }
    }
}
