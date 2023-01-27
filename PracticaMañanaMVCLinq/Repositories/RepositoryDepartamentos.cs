using PracticaMañanaMVCLinq.Data;
using PracticaMañanaMVCLinq.Models;

namespace PracticaMañanaMVCLinq.Repositories
{
    public class RepositoryDepartamentos
    {
        private HospitalContext context;
        public RepositoryDepartamentos(HospitalContext context)
        {
            this.context = context;
        }

        public List<Departamento> GetDepartamentos()
        {
            var consulta = from datos in this.context.Departamentos select datos;
            return consulta.ToList();
        }

        public void InsertarDepartamento(Departamento dept)
        {
            this.context.Departamentos.Add(dept);
            this.context.SaveChanges();
        }
    }
}
