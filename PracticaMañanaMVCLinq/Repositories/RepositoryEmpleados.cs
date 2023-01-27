using PracticaMañanaMVCLinq.Data;
using PracticaMañanaMVCLinq.Models;

namespace PracticaMañanaMVCLinq.Repositories
{
    public class RepositoryEmpleados
    {
        private HospitalContext context;
        public RepositoryEmpleados(HospitalContext context)
        {
            this.context = context;
        }   

        public List<Empleado> GetEmpleados(int id)
        {
            var consulta = from datos in this.context.Empleados where datos.IdDept == id select datos;
            return consulta.ToList();
        }

    }
}
