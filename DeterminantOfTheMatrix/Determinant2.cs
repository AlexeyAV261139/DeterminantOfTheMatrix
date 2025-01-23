namespace DeterminantOfTheMatrix;

public class Determinant2 : DeterminantBase
{
    public Determinant2(double[,] matrix)
    {
        Matrix = new double[2, 2];
        Matrix = matrix;
    }

    public override double GetDeterminant() => 
        Matrix[0, 0] * Matrix[1, 1] - Matrix[0, 1] * Matrix[1, 0];
}
