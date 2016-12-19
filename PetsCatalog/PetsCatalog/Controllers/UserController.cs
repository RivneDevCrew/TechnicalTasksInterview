using PetsCatalog.Helpers;
using PetsCatalog.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace PetsCatalog.Controllers
{
    public class UserController : ApiController
    {
        UserHelper dbHelper = new UserHelper(AppDomain.CurrentDomain.BaseDirectory + "/App_Data/database.db");

        // GET: api/User
        public IEnumerable<User> Get()
        {
            return dbHelper.GetAll();
        }

        // GET: api/User/5
        public User Get(int id)
        {
            return dbHelper.GetById(id);
        }

        // POST: api/User
        public void Post([FromBody]string value)
        {
            User user = new User
            {
                Name = value
            };
            dbHelper.Add(user);
        }

        // PUT: api/User/5
        public void Put(int id, [FromBody]User user)
        {
            dbHelper.Edit(user);
        }

        // DELETE: api/User/5
        public void Delete(int id)
        {
            dbHelper.Delete(id);
        }
    }
}
