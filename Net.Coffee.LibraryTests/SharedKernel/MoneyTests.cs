using Microsoft.VisualStudio.TestTools.UnitTesting;
using Net.Coffee.Library.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Coffee.Library.SharedKernel.Tests
{
    [TestClass()]
    public class MoneyTests
    {
        [TestMethod()]
        public void Operator_equal_should_return_true_if_amount_is_the_same()
        {
            //Arrange
            var x = Money.FromString("1.25");
            var y = Money.FromAmount(1.25m);

            //Act
            bool actualValue = x == y;
            bool expectedValue = true;

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod()]
        public void Operator_not_equal_should_return_true_if_amount_is_not_the_same()
        {
            //Arrange
            var x = Money.FromString("1.26");
            var y = Money.FromAmount(1.25m);

            //Act
            bool actualValue = x != y;
            bool expectedValue = true;

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod()]
        public void Operator_plus_should_return_numeric_negation_of_its_operands()
        {
            //Arrange
            var x = Money.FromString("1.30");
            var y = Money.FromAmount(1.70m);

            //Act
            Money actualValue = x + y;
            Money expectedValue = Money.FromAmount(3.00m);

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod()]
        public void Operator_minus_should_return_the_numeric_negation_of_its_operands()
        {
            //Arrange
            var x = Money.FromString("3.54");
            var y = Money.FromAmount(3.10m);

            //Act
            Money actualValue = x - y;
            Money expectedValue = Money.FromAmount(0.44m);

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod()]
        public void Operator_multiplication_should_return_the_product_of_its_operands()
        {
            //Arrange
            var x = Money.FromString("1.22");
            var y = Money.FromAmount(1.10m);

            //Act
            Money actualValue = x * y;
            Money expectedValue = Money.FromAmount(1.34m);

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod()]
        public void Operator_division_should_divide_its_left_hand_operand_by_its_right_hand_operand()
        {
            //Arrange
            var x = Money.FromString("0.50");
            var y = Money.FromAmount(1.10m);

            //Act
            Money actualValue = x / y;
            Money expectedValue = Money.FromAmount(0.45m);

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}