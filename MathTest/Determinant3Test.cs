using DeterminantOfTheMatrix;

namespace MathTest;

public class Determinant3Test
{
    private double[,] matrix =
    {
        {2, 0, 1 },
        {-1, 3, 1 },
        {0, 1, 0}
    };

    [Fact]
    public void GetPlusTriangleTest()
    {       
        Determinant3 det = new(matrix);


        var plusSum = det.GetPlusTriangle();

        Assert.Equal(-1, plusSum);
    }

    [Fact]
    public void GetMinusTriangleTest()
    {
        Determinant3 det = new(matrix);

        var minusDiff = det.GetMinusTriangle();

        Assert.Equal(2, minusDiff);
    }

    [Fact]
    public void GetDeterminantTest()
    {
        Determinant3 det = new(matrix);

        var determinant = det.GetDeterminant();

        Assert.Equal(-3, determinant);
    }
}
