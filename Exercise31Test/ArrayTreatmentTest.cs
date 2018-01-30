using System;
using Xunit;

namespace Exercise31Test
{
    public class ArrayTreatmentTest
    {
        [Fact]
        public void ArrayTreatment_ArrayMultiplier_AllOk_Success()
        {
            // Arrange
            var at = new Exercise31.ArrayTreatment();
            at.Array1 = new int[] { 1, 2, 3, 4 };
            at.Array2 = new int[] { 1, 2, 3, 4 };

            //Act
            int[] actual = at.ArrayMultiplier();

            //Assert
            Assert.Equal(new int[] { 1, 4, 9, 16 }, actual);
        }

        [Fact]
        public void ArrayTreatment_ArrayMultiplier_DifferentLegnthArray_ArgumentedExceptionArray()
        {
            // Arrange
            var at = new Exercise31.ArrayTreatment();
            at.Array1 = new int[] { 1, 2, 3, 4 };
            at.Array2 = new int[] { 1, 2, 3 };

            //Act & Assert
            Assert.Throws<ArgumentNullException>(() => at.ArrayMultiplier());          
        }
    }
}
