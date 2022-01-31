using Microsoft.AspNetCore.Mvc;
using WebAppCoches.Model;
using WebAppCoches.Repository;

namespace WebAppCoches.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CocheController : ControllerBase
    {
        private CocheRepository CocheRepositorio;

        public CocheController(CocheRepository coche)
        {
            this.CocheRepositorio = coche;
        }

        [HttpPost]
        public void CreateCoche(CocheModel coche)
        {
            CocheRepositorio.AddCoche(coche);
        }

        [HttpGet]
        [Route("api/[controller]")]
        public List<CocheModel> GetCoches()
        {
            return CocheRepositorio.GetAll();
        }

        [HttpGet]
        [Route("/{id}")]
        public CocheModel GetCoche(int id)
        {
            return CocheRepositorio.FindId(id);
        }

        [HttpDelete]
        [Route("/{id}")]
        public void DeleteCoche(int id)
        {
            CocheRepositorio.Delete(id);
        }

        [HttpPut]
        public void UpdateCoche(int id, bool estado, string color, bool movimiento)
        {
            CocheRepositorio.UpdateValues(id, estado, color, movimiento);
        }

    }
}