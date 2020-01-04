using System;
using Xunit;

namespace GameEngine.Test
{
    public class BossEnemyShould
    {
        [Fact]
        [Trait("Category", "Boss")]
        public void HaveCorrectPower()
        {
            BossEnemy sut = new BossEnemy();

            Assert.Equal(166.667, sut.TotalSpecialAttackPower, 3);
        }
    }
}
