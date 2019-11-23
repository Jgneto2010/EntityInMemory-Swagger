using Domain.Models;
using Infra.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Users.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly EntityContext _entity;

        public UserController(EntityContext entity)
        {
            _entity = entity;
        }


        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return _entity.Usuarios.ToList();
        }

        [HttpGet]
        [Route("/BuscaPeloNome")]
        public ActionResult<IEnumerable<User>> GetByName()
        {
            return _entity.Usuarios.OrderBy(x => x.Name).ToList();
        }

        [HttpPost]
        public void Post([FromBody] User usuario)
        {
            _entity.Add(usuario);
            _entity.SaveChanges();
        }

    }
}
