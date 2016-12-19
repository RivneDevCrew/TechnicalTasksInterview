using PetsCatalog.Models;
using SQLite;
using System.Collections.Generic;
using System.Linq;

namespace PetsCatalog.Helpers
{
    public class UserHelper
    {
        private string _connectionString;

        public UserHelper(string connectionString)
        {
            _connectionString = connectionString;
            using (var db = new SQLiteConnection(_connectionString))
            {
                db.CreateTable<User>();
                db.CreateTable<Pet>();
            }
        }

        public IEnumerable<User> GetAll()
        {
            using (var db = new SQLiteConnection(_connectionString))
            {
                var data = db.Table<User>().ToList();
                var tmpHelper = new PetHelper(_connectionString);

                foreach (var user in data)
                {
                    user.PetsCount = tmpHelper.GetByUserId(user.Id).Count();
                }

                db.UpdateAll(data);
                return data;
            }
        }

        public User GetById(int id)
        {
            using (var db = new SQLiteConnection(_connectionString))
            {
                return db.Get<User>(id);
            }
        }

        public void Add(User user)
        {
            using (var db = new SQLiteConnection(_connectionString))
            {
                db.Insert(user);
            }
        }

        public void Edit(User newUser)
        {
            using (var db = new SQLiteConnection(_connectionString))
            {
                db.Update(newUser);
            }
        }

        public void Delete(int id)
        {
            using (var db = new SQLiteConnection(_connectionString))
            {
                db.BeginTransaction();
                db.Delete<User>(id);
                db.Commit();
            }
        }
    }
}