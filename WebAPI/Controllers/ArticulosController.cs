using Dominio;
using Negocio;
using WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.UI.WebControls.WebParts;

namespace WebAPI.Controllers
{
    public class ArticulosController : ApiController
    {
        // GET: api/Articulos
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Articulos/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Articulos
        public void Post([FromBody]ArticulosDto art)
        {
            ArticulosNegocio artNeg = new ArticulosNegocio();
            Articulos nuevo = new Articulos();
            nuevo.Marca = new Marcas();
            nuevo.Categoria = new Categorias();

            nuevo.Codigo = art.Codigo;
            nuevo.Nombre = art.Nombre;
            nuevo.Descripcion = art.Descripcion;
            nuevo.Precio = art.Precio;
            nuevo.Marca.Id = art.IdMarca;
            nuevo.Categoria.Id = art.IdCategoria;
            artNeg.Agregar(nuevo);
        }

        // PUT: api/Articulos/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Articulos/5
        public void Delete(int id)
        {
        }
    }
}
