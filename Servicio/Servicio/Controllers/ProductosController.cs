using Servicio.Entidades;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Servicio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly SqlConnection Con;

        public ProductosController ()
        {
            Con = new SqlConnection(Connection.ConnectionString);
            //Con = new SqlConnection("Data Source=JCHR\\SQLEXPRESS;Initial Catalog=prueba;User ID=admin;Password=admin");
        }



        // GET: api/<ProductosController>
        [HttpGet]
        public async Task<ActionResult<List<Producto>>>Get()
        {
            var sql = "execute FindAll";
            var result = Con.Query<Producto>(sql);
            return Ok(result);

        }

        // GET api/<ProductosController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Producto>> Get(int id)
        {
            var sql = $"execute find {id}";
            var result = Con.Query<Producto>(sql);
            return Ok(result.FirstOrDefault());
        }

        // POST api/<ProductosController>
        [HttpPost]
        public void Post(Producto producto)
        {


            var sql = "EXECUTE insertar @Nombre,@Precio,@Stock";
            var result = Con.Execute(sql, producto);

        }

        // PUT api/<ProductosController>/5
        [HttpPut]
        public void Put(Producto producto)
        {
        var sql = "Execute actualizar @Id,@Nombre,@Precio,@Stock";
        var result = Con.Execute(sql, producto);

    }

        // DELETE api/<ProductosController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            
            var sql = "execute Eliminar @Id";
            var result = Con.Execute(sql, new {Id = id });
            if (result== 0)
            {
                return NotFound();
            }
            else
            {
                return Ok();
            }



        }
    }
}
