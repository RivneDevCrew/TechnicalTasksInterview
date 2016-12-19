using SQLite;
using SQLiteNetExtensions.Attributes;

namespace PetsCatalog.Models
{
    [Table("Pets")]
    public class Pet
    {
        [PrimaryKey, AutoIncrement, Unique, NotNull]
        public int Id { get; set; }

        [ForeignKey(typeof(User))]
        public int UserId { get; set; }

        [NotNull]
        public string Name { get; set; }
    }
}