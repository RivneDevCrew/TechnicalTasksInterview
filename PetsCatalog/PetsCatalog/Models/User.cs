using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace PetsCatalog.Models
{
    [Table("Users")]
    public class User
    {
        [PrimaryKey, AutoIncrement, Unique, NotNull]
        public int Id { get; set; }

        [NotNull]
        public string Name { get; set; }

        [Ignore]
        public int PetsCount { get; set; }
    }
}