using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            List<GameCharacter> characters = new List<GameCharacter>();
            characters.Add(new CharacterA());
            characters.Add(new CharacterB());
            Console.WriteLine("Oyunda " +characters.Count() + " Adet Karekter Bulunmaktadır");
            Console.ReadLine();


        }
    }
}
