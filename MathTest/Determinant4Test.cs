using DeterminantOfTheMatrix;

namespace MathTest;

public class Determinant4Test
{
    private double[,] _matrix4 =
        {
            { 3, -7, 1, 4 },
            { 6, 2, -1, 8 },
            { -9, 5, 7, -3 },
            { -2, -6, -5, 0 }
        };

    [Fact]
    public void GetDeterminantTest()
    {
        double expectedValue = -14580;
        double[,] matrix =
        {
            { 33, -7, 1, 45 },
            { 6, 2, -1, 8 },
            { 0, 5, 7, -3 },
            { -2, -6, -55, 0 }
        };

        GetTeterminant(expectedValue, matrix);
    }

    [Fact]
    public void GetDeterminantTest2()
    {
        double expectedValue = 3632; 
        GetTeterminant(expectedValue, _matrix4);
    }

    private static void GetTeterminant(double expectedValue, double[,] matrix)
    {
        Determinant4 determinant4 = new(matrix);
        var determinant = determinant4.GetDeterminant();
        Assert.Equal(expectedValue, determinant);
    }

    [Fact]
    public void CutMatrixTest0()
    {
        double[,] expectedMatrix =
        {
            { 2, -1, 8},
            { 5, 7, -3},
            { -6, -5, 0 }
        };

        var column = 0;

        CutMatrix(expectedMatrix, column);
    }

    [Fact]
    public void CutMatrixTest1()
    {
        double[,] expectedMatrix =
        {
            { 6, -1, 8},
            { -9, 7, -3},
            { -2, -5, 0 }
        };

        var column = 1;

        CutMatrix(expectedMatrix, column);
    }

    [Fact]
    public void CutMatrixTest2()
    {
        double[,] expectedMatrix =
         {
            { 6, 2, 8},
            { -9, 5, -3},
            { -2, -6, 0 }
        };

        var column = 2;

        CutMatrix(expectedMatrix, column);
    }

    [Fact]
    public void CutMatrixTest3()
    {
        double[,] expectedMatrix =
         {
            { 6, 2, -1},
            { -9, 5, 7},
            { -2, -6, -5 }
        };

        var column = 3;

        CutMatrix(expectedMatrix, column);
    }

    [Theory]
    [InlineData(0, 3)]
    [InlineData(1, 7)]
    [InlineData(2, 1)]
    [InlineData(3, -4)]
    public void GetMultiplierTest(int column, double expectedValue)
    {
        Determinant4 determinant4 = new(_matrix4);

        var value = determinant4.GetMultiplier(column);

        Assert.Equal(expectedValue, value);
    }

    private void CutMatrix(double[,] expectedMatrix, int column)
    {
        Determinant4 determinant4 = new(_matrix4);


        var resultMatrix = determinant4.CutMatrix(column);


        for (var i = 0; i < 3; i++)
        {
            for (var j = 0; j < 3; j++)
            {
                if (expectedMatrix[i, j] != resultMatrix[i, j])
                    Assert.Fail($"{i}, {j} value expected: {expectedMatrix[i, j]}. Actual: {resultMatrix[i, j]}");
            }
        }
    }
}