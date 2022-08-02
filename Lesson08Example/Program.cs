using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08Example
{
    class PetShop
    {
        private string strPetShopName;
        private string strAddress;
        public PetShop(string strPetShopName, string strAddress)
        {
            this.strPetShopName = strPetShopName;
            this.strAddress = strAddress;
        }
        public string PetShopInfo()
        {
            return ("Pet Shop Name: " + strPetShopName + "Address: " + strAddress);
            //return ("Pet Shop Name: {0} Address: {1}")
        }
        public virtual string Sound()
        {
            return ("The animal makes a sound ");
        }
    }
    class Dog : PetShop
    {
        private string strName;
        public Dog(string strPetShopName, string strAddress, string strName) : base(strPetShopName, strAddress)
        { 
            this.strName = strName;
                //this.strPetShopName = strPetShopName;

        }
        public override string Sound()
        {
            return ("My dog barks");
        }
    }
    class Cat : PetShop
    {
        private string strName;
        public Cat(string strPetShopName, string strAddress, string strName) : base(strPetShopName, strAddress)
        {
            this.strName = strName;
                //this.strPetShopName = strPetShopName;

        }
        public override string Sound()
        {
            return ("My cat meow");
        }

    }
    
        
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Enter the name of dog: ");
                string MyBestPet = Console.ReadLine();
                Console.Write("Enter the name of the pet shop: ");
                string ILovePet = Console.ReadLine();
                Console.Write("Enter the address: ");
                string PetShopAddress = Console.ReadLine();


                Dog objDog = new Dog(ILovePet, PetShopAddress, MyBestPet);
                Console.WriteLine("Pet Shop Name: {0}, Address: {1}", MyBestPet, PetShopAddress);
                Console.WriteLine("The animal makes a sound {0}", objDog.Sound());
        }
    }
}
