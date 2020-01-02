using System;
using Xunit;

namespace GameEngine.Test
{
    public class PlayerCharacterShould
    {
        [Fact]
        public void BeInexperiencedWhenNew()
        {
            PlayerCharacter sut = new PlayerCharacter();
        }
    }
}
