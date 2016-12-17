using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServeTestTask
{
    //    Create next classes: Cat, Dog and Petshop.
    //Types Cat and Dog have fields Name and Breed and method Introduce() which prints text “I’m(Name) of(Breed). I’m a cat(or dog)”.
    //The class Petshop collects in its container different pets.
    //We may add new pet to container by method AddPet() and we may display information about all pets by method IntroduceAll().
    //Which hierarchy of classes is the best solution of this problem?
    //Write short code to demonstrate your solution. Your code should include class (interface) aggregation, inheritance, should use.NET BCL collections or generics, should implement exception handling.

    public abstract class Pet
    {

        public Pet(String name, String breed)
        {
           // if (String.IsNullOrEmpty(Breed) || String.IsNullOrEmpty(Breed))
            //{
              //  throw new Exception("Invalid input");
            //}
            this.Breed = breed;
            this.Name = name;
        }
        public readonly String Name;
        public readonly String Breed;
        public virtual void Introduce()
        {

        }

    }

    public class PetShop
    {
        private List<Pet> PetsList = new List<Pet>();
        public PetShop()
        {

        }
        public void IntroduceAll()
        {
            foreach (var pet in PetsList)
            {
                pet.Introduce();
            }
        }
        public void AddPet(Pet item)
        {
            try
            {
                if (String.IsNullOrEmpty(item.Breed) || String.IsNullOrEmpty(item.Name))
                {
                    throw new Exception("Invalid input.");
                }
                else this.PetsList.Add(item);
                
            }
            catch (Exception e)
            {
               Console.WriteLine("Exception {0} {1}", e.Data, e.Message);
               
            }
            
        }
    }
    public class Cat : Pet
    {
        public Cat(String name, String breed)
            : base(name, breed)
        {

        }
        public override void Introduce()
        {
            Console.WriteLine("I am {0} of {1}. I am cat.", this.Name, this.Breed);
        }
        //“I’m(Name) of(Breed). I’m a cat(or dog)”.

    }
    public class Dog : Pet
    {
        public Dog(String name, String breed)
            : base(name, breed)
        {

        }
        public override void Introduce()
        {
            Console.WriteLine("I am {0} of {1}. I am dog.", this.Name, this.Breed);
        }
        //“I’m(Name) of(Breed). I’m a cat(or dog)”.

    }

    class Program
    {
        static void Main(string[] args)
        {
            PetShop shop = new PetShop();
            shop.AddPet(new Cat("Charlie", "Bengal"));
            shop.AddPet(new Dog("", "Haskie"));
            Cat kitty = new Cat("Molly", "Birman");
            shop.AddPet(kitty);
            shop.AddPet(new Cat(null, "Persian"));
            shop.IntroduceAll();
        }
    }
}
