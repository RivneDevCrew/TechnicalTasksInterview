using PetsCatalog.Models;
using SQLite;
using System.Collections.Generic;
using System.Linq;

namespace PetsCatalog.Helpers
{
    public class PetHelper
    {
        private string _connectionString;

        public PetHelper(string connectionString)
        {
            _connectionString = connectionString;
            using (var db = new SQLiteConnection(_connectionString))
            {
                db.CreateTable<Pet>();
            }
        }

        public IEnumerable<Pet> GetAll()
        {
            using (var db = new SQLiteConnection(_connectionString))
            {
                return db.Table<Pet>().ToList();
            }
        }

        public IEnumerable<Pet> GetByUserId(int userId)
        {
            using (var db = new SQLiteConnection(_connectionString))
            {
                return db.Table<Pet>().Where(p => p.UserId == userId).ToList();
            }
        }

        public void Add(Pet pet)
        {
            using (var db = new SQLiteConnection(_connectionString))
            {
                db.Insert(pet);
            }
        }

        public void Edit(Pet pet)
        {
            using (var db = new SQLiteConnection(_connectionString))
            {
                db.Update(pet);
            }
        }

        public void Delete(int id)
        {
            using (var db = new SQLiteConnection(_connectionString))
            {
                db.Delete<Pet>(id);
            }
        }
    }
}