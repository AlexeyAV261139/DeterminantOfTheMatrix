namespace DeterminantOfTheMatrix;

public abstract class DeterminantBase
{
    public double[,] Matrix { get; init; }

    public abstract double GetDeterminant();
}
