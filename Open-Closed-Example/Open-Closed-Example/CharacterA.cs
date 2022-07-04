using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Example
{
    public class CharacterA : GameCharacter
    {
        public CharacterA():base()
        {

        }



        private string _Name {  get; set; }
        private string _CharacterType { get; set; }

        public override string Name { get { return _Name; } }
        public override string CharacterType { get { return _CharacterType; } }



        protected override void GameCharacterCreate()
        {
            _Name = "A Karekteri";
            _CharacterType = "Shoter";

            
        }
    }
}
