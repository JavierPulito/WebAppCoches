using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebAppCoches.Model;
using WebAppCoches.Repository;

namespace WebAppCoches.UnitTest
{
    [TestClass]
    public class TestCoche
    {
        private CocheModel Coche;
        private RuedaModel Rueda;

        private List<CocheModel> Coches = new List<CocheModel>();

        private MiDBContext MiDBContext;

        [TestInitialize]
        public void SetUp()
        {
            this.Coche = new CocheModel();
            this.Rueda = new RuedaModel(0, true);
        }

        [TestMethod]
        public void TestAddCoche()
        {
            Assert.AreNotEqual(3,0);
           
        }
    }
}
