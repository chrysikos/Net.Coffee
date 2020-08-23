using Microsoft.VisualStudio.TestTools.UnitTesting;
using Net.Coffee.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Net.Coffee.Domain.Tests
{
    [TestClass()]
    public class MoneyTests
    {
        [TestMethod()]
        public void Operator_equal_should_return_true_if_amount_is_the_same()
        {
            //Arrange
            var x = Money.FromEuro("1.25");
            var y = Money.FromEuro(1.25m);

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
            var x = Money.FromEuro("1.26");
            var y = Money.FromEuro(1.25m);

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
            var x = Money.FromEuro("1.30");
            var y = Money.FromEuro(1.70m);

            //Act
            Money actualValue = x + y;
            Money expectedValue = Money.FromEuro(3.00m);

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod()]
        public void Operator_minus_should_return_the_numeric_negation_of_its_operands()
        {
            //Arrange
            var x = Money.FromEuro("3.54");
            var y = Money.FromEuro(3.10m);

            //Act
            Money actualValue = x - y;
            Money expectedValue = Money.FromEuro(0.44m);

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod()]
        public void Operator_multiplication_should_return_the_product_of_its_operands()
        {
            //Arrange
            var x = Money.FromEuro("1.22");
            var y = Money.FromEuro(1.10m);

            //Act
            Money actualValue = x * y;
            Money expectedValue = Money.FromEuro(1.34m);

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
        [TestMethod()]
        public void Operator_division_should_divide_its_left_hand_operand_by_its_right_hand_operand()
        {
            //Arrange
            var x = Money.FromEuro("0.50");
            var y = Money.FromEuro(1.10m);

            //Act
            Money actualValue = x / y;
            Money expectedValue = Money.FromEuro(0.45m);

            //Assert
            Assert.AreEqual(expectedValue, actualValue);
        }
    }
}