using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu.Drinks;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        //The correct default price, calories, ice, size, and lemon properties.
        /// <summary>
        /// Checks for the correct default price
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Water water = new Water();
            Assert.Equal<double>(0.10, water.Price);
        }

        /// <summary>
        /// Checks for the correct default calories
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Water water = new Water();
            Assert.Equal<uint>(0, water.Calories);
        }

        /// <summary>
        /// Checks that the default is no ice
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultNoIce()
        {
            Water water = new Water();
            Assert.True(water.Ice);
        }
        
        /// <summary>
        /// Tests that there is no lemon default
        /// </summary>
        [Fact]
        public void ShouldHaveNoLemonDefault()
        {
            Water water = new Water();
            Assert.False(water.Lemon);
        }


        /// <summary>
        /// Checks for the correct default size
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Water water = new Water();
            Assert.Equal<Size>(Size.Small, water.Size);
        }


        //The correct price and calories after changing to small, medium, and large sizes.

        /// <summary>
        /// Checks for the correct calories for a small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesSmall()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Small;
            Assert.Equal<uint>(0, water.Calories);
        }

        /// <summary>
        /// Checks for the correct calories for a medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<uint>(0, water.Calories);
        }

        /// <summary>
        /// Checks for the correct calories for a large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<uint>(0, water.Calories);
        }

        /// <summary>
        /// Checks for the correct price for a small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceSmall()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            water.Size = Size.Small;
            Assert.Equal<double>(0.10, water.Price);
        }

        /// <summary>
        /// Checks for the correct price for a medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceMedium()
        {
            Water water = new Water();
            water.Size = Size.Medium;
            Assert.Equal<double>(0.10, water.Price);
        }

        /// <summary>
        /// Checks for the correct price for a large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceLarge()
        {
            Water water = new Water();
            water.Size = Size.Large;
            Assert.Equal<double>(0.10, water.Price);
        }


        //That invoking HoldIce() results in the Ice property being false

        /// <summary>
        /// invoking HoldIce() results in the Ice property being false.
        /// </summary>
        [Fact]
        public void ShouldHoldIce()
        {
            Water water = new Water();
            water.HoldIce();
            Assert.False(water.Ice);
        }


        //That invoking AddLemon() sets results in the Lemon property being true.

        /// <summary>
        /// invoking AddLemon() results in the Ice property being true.
        /// </summary>
        [Fact]
        public void ShouldAddLemon()
        {
            Water water = new Water();
            water.AddLemon();
            Assert.True(water.Lemon);
        }


        //The correct ingredients are given.
        
        /// <summary>
        /// The correct ingredients are given
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Water water = new Water();
            Assert.Contains<string>("Water", water.Ingredients);
            Assert.Single(water.Ingredients);
        }



    }
}
