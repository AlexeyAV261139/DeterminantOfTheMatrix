using DeterminantOfTheMatrix;

namespace MathTest;

public class Determinant2Test
{
    [Fact]
    public void GetDeterminantTest()
    {
        double[,] matrix =
        {
            {1, 2 },
            {3, 4 }
        };

        var det = new Determinant2(matrix).GetDeterminant();

        Assert.Equal(-2, det);
    }
}
