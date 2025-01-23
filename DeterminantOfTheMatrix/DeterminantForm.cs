namespace DeterminantOfTheMatrix;

public partial class DeterminantForm : Form
{   
    public DeterminantForm()
    {
        InitializeComponent();
    }
    private void Form1_Load(object sender, EventArgs e)
    {
        matrixDGV.AllowUserToAddRows = false;
        UpdateDGV(4);
    }

    private void UpdateDGV(int size)
    {
        matrixDGV.Columns.Clear();

        for (int i = 0; i < size; i++)
        {
            var column = new DataGridViewColumn();
            column.Width = 60;
            column.CellTemplate = new DataGridViewTextBoxCell();

            matrixDGV.Columns.Add(column);
            matrixDGV.Rows.Add();
        }
    }

    private void Det2Button_Click(object sender, EventArgs e)
    {
        UpdateDGV(2);
    }

    private void Det3Button_Click(object sender, EventArgs e)
    {
        UpdateDGV(3);

    }

    private void Det4Button_Click(object sender, EventArgs e)
    {
        UpdateDGV(4);
    }

    private void StartButton_Click(object sender, EventArgs e)
    {
        try
        {
            int size = matrixDGV.Columns.Count;
            var matrix = GetMatrixFromForm(size);

            double result = size switch
            {
                2 => new Determinant2(matrix).GetDeterminant(),
                3 => new Determinant3(matrix).GetDeterminant(),
                4 => new Determinant4(matrix).GetDeterminant(),
                _ => throw new Exception()
            };

            resultLabel.Text = $"Определитель равен: {result}";
        }
        catch
        {
            MessageBox.Show("Некорректные входные данные");
        }

    }

    private double[,] GetMatrixFromForm(int size)
    {
        double[,] matrix = new double[size, size];

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                matrix[i,j] = Convert.ToDouble(matrixDGV[i, j].Value);
            }
        }
        return matrix;
    }
}
