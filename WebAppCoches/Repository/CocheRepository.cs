using WebAppCoches.Model;

namespace WebAppCoches.Repository
{
    public class CocheRepository
    {
        private List<CocheModel> Coches = new List<CocheModel>();

        private MiDBContext MiDBContext;

        public CocheRepository(MiDBContext miDBC)
        {
            this.MiDBContext = miDBC;
        }

        public void AddCoche(CocheModel coche)
        {
            MiDBContext.Coches.Add(coche);
            MiDBContext.SaveChanges();
        }

        public List<CocheModel> GetAll()
        {
            return MiDBContext.Coches.ToList();
        }

        public CocheModel FindId(int id)
        {
            IEnumerable<CocheModel> valores = MiDBContext.Coches.Where(p => p.Id == id);

            return valores.First();
        }

        public void Delete(int id)
        {
            CocheModel c = MiDBContext.Coches.Where(p => p.Id == id).First();
            MiDBContext.Coches.Remove(c);
            MiDBContext.SaveChanges();
        }

        public void UpdateValues(int id, bool estado, string color, bool movimiento)
        {
            CocheModel c = MiDBContext.Coches.Where(p => p.Id == id).First();
            c.Estado = estado;
            c.Color = color;
            c.Rueda.Movimiento = movimiento;
            MiDBContext.SaveChanges();
        }
    }
}
