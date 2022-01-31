namespace WebAppCoches.Model
{
    public class RuedaModel
    {
        public int Id { get; set; }
        public bool Movimiento { get; set; }

        public RuedaModel(int id, bool movimiento) 
        {
            this.Id = id;
            this.Movimiento = movimiento;
        }
    }
}
