using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        //The correct default price, calories, ice, size, lemon, and sweet properties.

        /// <summary>
        /// Checks for the correct defsult price
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<double>(0.99, tea.Price);
        }

        /// <summary>
        /// Checks for the correct defsult calories
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<uint>(8, tea.Calories);
        }

        /// <summary>
        /// Checks that the default is ice
        /// </summary>
        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.True(tea.Ice);
        }


        /// <summary>
        /// Checks for the correct defsult size
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Equal<Size>(Size.Small, tea.Size);
        }

        /// <summary>
        /// Checks for the correct default lemon property
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Lemon);
        }

        /// <summary>
        /// Checks for the correct default sweet property
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectDefaultSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.False(tea.Sweet);
        }

        //The correct price and calories after changing to small, medium, and large sizes.
        /// <summary>
        /// Checks for correct Price after setting to a small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<double>(0.99, tea.Price);
        }

        /// <summary>
        /// Checks for correct calories after setting to a small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            Assert.Equal<uint>(8, tea.Calories);
        }

        /// <summary>
        /// Checks for correct Price after setting to a medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<double>(1.49, tea.Price);
        }

        /// <summary>
        /// Checks for correct calories after setting to a medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            Assert.Equal<uint>(16, tea.Calories);
        }

        /// <summary>
        /// Checks for correct Price after setting to a large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<double>(1.99, tea.Price);
        }

        /// <summary>
        /// Checks for correct calories after setting to a large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            Assert.Equal<uint>(32, tea.Calories);
        }

        //That invoking HoldIce() results in the Ice property being false
        /// <summary>
        /// invoking HoldIce() results in the Ice property being false.
        /// </summary>
        [Fact]
        public void ShouldHoldIce()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.HoldIce();
            Assert.False(tea.Ice);
        }

        
        /// <summary>
        /// invoking the add lemon method results in the Lemon property being true
        /// </summary>
        [Fact]
        public void ShouldAddLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.True(tea.Lemon);
        }

        //That setting the sweet property to true results in the right calories for each size
        /// <summary>
        /// setting the sweet property to true results in the right calories for small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesWhenSmallSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            tea.Sweet = true;
            Assert.Equal<uint>(16, tea.Calories);
        }

        /// <summary>
        /// setting the sweet property to true results in the right calories for medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesWhenMediumSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Sweet = true;
            Assert.Equal<uint>(32, tea.Calories);
        }

        /// <summary>
        /// setting the sweet property to true results in the right calories for large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesWhenLargeSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            tea.Sweet = true;
            Assert.Equal<uint>(64, tea.Calories);
        }

        //That setting the sweet property to false (after it has been set to true) results in the right calories for each size.
        /// <summary>
        /// setting the sweet property to false (after it has been set to true) results in the right calories for small
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesWhenSmallSweetReversed()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Size = Size.Small;
            tea.Sweet = true;
            tea.Sweet = false;
            Assert.Equal<uint>(8, tea.Calories);
        }

        /// <summary>
        /// setting the sweet property to false (after it has been set to true) results in the right calories for medium
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesWhenMediumSweetReversed()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Medium;
            tea.Sweet = true;
            tea.Sweet = false;
            Assert.Equal<uint>(16, tea.Calories);
        }

        /// <summary>
        /// setting the sweet property to false (after it has been set to true) results in the right calories for large
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectCaloriesWhenLargeSweetReversed()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Size = Size.Large;
            tea.Sweet = true;
            tea.Sweet = false;
            Assert.Equal<uint>(32, tea.Calories);
        }

        //The correct ingredients are given.
        /// <summary>
        /// The correct ingredients are given for default
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngedientsDefault()
        {
            Tyrannotea tea = new Tyrannotea();
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Equal<int>(2, tea.Ingredients.Count);
        }

        /// <summary>
        /// The correct ingredients are given for add lemon
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngedientsAddLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.AddLemon();
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Contains<string>("Lemon", tea.Ingredients);
            Assert.Equal<int>(3, tea.Ingredients.Count);
        }

        /// <summary>
        /// The correct ingredients are given for sweet
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngedientsSweet()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Contains<string>("Cane Sugar", tea.Ingredients);
            Assert.Equal<int>(3, tea.Ingredients.Count);
        }

        /// <summary>
        /// The correct ingredients are given for sweet add lemon
        /// </summary>
        [Fact]
        public void ShouldHaveCorrectIngedientsSweetAddLemon()
        {
            Tyrannotea tea = new Tyrannotea();
            tea.Sweet = true;
            tea.AddLemon();
            Assert.Contains<string>("Water", tea.Ingredients);
            Assert.Contains<string>("Tea", tea.Ingredients);
            Assert.Contains<string>("Cane Sugar", tea.Ingredients);
            Assert.Contains<string>("Lemon", tea.Ingredients);
            Assert.Equal<int>(4, tea.Ingredients.Count);
        }
    }
}
