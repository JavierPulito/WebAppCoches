using WebAppCoches.Model;

namespace WebAppCoches.Repository
{
    public class CocheRepository
    {
        private List<CocheModel> Coches = new List<CocheModel>();

        public void AddCoche(CocheModel coche)
        {
            Coches.Add(coche);
        }

        public List<CocheModel> GetAll()
        {
            return Coches;
        }

        public CocheModel FindId(int id)
        {
            return Coches.Find(c => c.Id == id);
        }

        public void Delete(int id)
        {
            CocheModel c = FindId(id);
            Coches.Remove(c);
        }

        public void UpdateValues(int id, bool estado, string color, bool movimiento)
        {
            CocheModel c = FindId(id);
            c.Estado = estado;
            c.Color = color;
            c.Rueda.Movimiento = movimiento;
        }
    }
}
