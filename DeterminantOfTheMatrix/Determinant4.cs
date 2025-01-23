namespace DeterminantOfTheMatrix;

public class Determinant4 : DeterminantBase
{
    public Determinant4(double[,] matrix4x4)
    {
        Matrix = new double[4, 4];
        Matrix = matrix4x4;
    }

    public override double GetDeterminant()
    {
        double sum = 0;
        for (int i = 0; i < 4; i++)
        {
            double multiplier = GetMultiplier(i);

            double[,] matrix3x3 = CutMatrix(i);            
            double determinant4 = new Determinant3(matrix3x3).GetDeterminant();

            sum += multiplier * determinant4;
        }
        return sum;
    }

    public double GetMultiplier(int column) =>
        Matrix[0, column] * Math.Pow(-1, 2 + column);
    

    public double[,] CutMatrix(int column)
    {
        double[,] matrix3 = new double[3, 3];

        int summand = 0;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3 ; j++)
            {
                if (j == column)
                    summand = 1;
                matrix3[i, j] = Matrix[i + 1, j + summand];
            }
            summand = 0;
        }

        return matrix3;
    }
}

