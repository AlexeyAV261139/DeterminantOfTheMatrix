namespace DeterminantOfTheMatrix;

public class Determinant3 : DeterminantBase
{
    public Determinant3(double[,] matrix)
    {
        Matrix = new double[3, 3];
        Matrix = matrix;
    }

    public override double GetDeterminant()
    {
        double sumOfTriangles = GetPlusTriangle();
        double differenceOfTriangles = GetMinusTriangle();

        var result = sumOfTriangles - differenceOfTriangles;

        return result;
    }

    public double GetPlusTriangle()
    {
        double line = Matrix[0, 0] * Matrix[1, 1] * Matrix[2, 2];
        double tringle1 = Matrix[0, 2] * Matrix[1,0] * Matrix[2, 1];
        double tringle2 = Matrix[0, 1] * Matrix[1, 2] * Matrix[2, 0];

        double sum = line + tringle1 + tringle2;

        return sum;
    }

    public double GetMinusTriangle()
    {
        double line = Matrix[0, 2] * Matrix[1, 1] * Matrix[2, 0];
        double tringle1 = Matrix[0, 0] * Matrix[2, 1] * Matrix[1, 2];
        double tringle2 = Matrix[0, 1] * Matrix[1, 0] * Matrix [2, 2];

        double difference = line + tringle1 + tringle2;

        return difference;
    }
}