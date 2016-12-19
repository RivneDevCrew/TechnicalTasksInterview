using PetsCatalog.Helpers;
using PetsCatalog.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace PetsCatalog.Controllers
{
    public class PetController : ApiController
    {
        PetHelper dbHelper = new PetHelper(AppDomain.CurrentDomain.BaseDirectory + "/App_Data/database.db");

        // GET: api/Pet
        public IEnumerable<Pet> Get()
        {
            return dbHelper.GetAll();
        }

        // GET: api/Pet/5
        public IEnumerable<Pet> Get(int id)
        {
            return dbHelper.GetByUserId(id);
        }

        // POST: api/Pet
        public void Post([FromBody]string value)
        {
            Pet pet = new Pet
            {
                Name = value.Split(',')[0],
                UserId = Convert.ToInt32(value.Split(',')[1])
            };
            dbHelper.Add(pet);
        }

        // PUT: api/Pet/5
        public void Put(int id, [FromBody]Pet pet)
        {
            dbHelper.Edit(pet);
        }

        // DELETE: api/Pet/5
        public void Delete(int id)
        {
            dbHelper.Delete(id);
        }
    }
}
