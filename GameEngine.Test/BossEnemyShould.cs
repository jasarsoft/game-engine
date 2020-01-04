﻿using System;
using Xunit;
using Xunit.Abstractions;

namespace GameEngine.Test
{
    public class BossEnemyShould
    {
        private readonly ITestOutputHelper _output;

        public BossEnemyShould(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        [Trait("Category", "Boss")]
        public void HaveCorrectPower()
        {
            _output.WriteLine("Creating Boss Enemy");

            BossEnemy sut = new BossEnemy();

            Assert.Equal(166.667, sut.TotalSpecialPower, 3);
        }
    }
}
