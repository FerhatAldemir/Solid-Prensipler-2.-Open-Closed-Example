using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Example
{
    public abstract class GameCharacter
    {
        public GameCharacter()
        {
            GameCharacterCreate();

            Console.WriteLine(Name + " Karekteri Oluşturuldu");
        }

       

        public abstract string Name { get; }
        public abstract string CharacterType { get; }

        protected abstract void GameCharacterCreate();

    }
}
