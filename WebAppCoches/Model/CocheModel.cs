namespace WebAppCoches.Model
{
    public class CocheModel
    {
        public int Id { get; set; }

        public bool Estado { get; set; }

        public string Color { get; set; }

        public RuedaModel Rueda { get; set; }

        public CocheModel(int id, bool estado, string color, RuedaModel rueda)
        {
            this.Id = id;
            this.Estado = estado;
            this.Color = color;
            this.Rueda = rueda;
        }

    }
}
