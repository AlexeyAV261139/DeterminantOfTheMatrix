namespace DeterminantOfTheMatrix;

partial class DeterminantForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        matrixDGV = new DataGridView();
        det2Button = new Button();
        det3Button = new Button();
        det4Button = new Button();
        startButton = new Button();
        resultLabel = new Label();
        groupBox1 = new GroupBox();
        ((System.ComponentModel.ISupportInitialize)matrixDGV).BeginInit();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // matrixDGV
        // 
        matrixDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        matrixDGV.Location = new Point(149, 25);
        matrixDGV.Name = "matrixDGV";
        matrixDGV.Size = new Size(331, 179);
        matrixDGV.TabIndex = 0;
        // 
        // det2Button
        // 
        det2Button.Location = new Point(6, 35);
        det2Button.Name = "det2Button";
        det2Button.Size = new Size(75, 23);
        det2Button.TabIndex = 1;
        det2Button.Text = "2 порядок";
        det2Button.UseVisualStyleBackColor = true;
        det2Button.Click += Det2Button_Click;
        // 
        // det3Button
        // 
        det3Button.Location = new Point(6, 64);
        det3Button.Name = "det3Button";
        det3Button.Size = new Size(75, 23);
        det3Button.TabIndex = 2;
        det3Button.Text = "3 порядок";
        det3Button.UseVisualStyleBackColor = true;
        det3Button.Click += Det3Button_Click;
        // 
        // det4Button
        // 
        det4Button.Location = new Point(6, 93);
        det4Button.Name = "det4Button";
        det4Button.Size = new Size(75, 23);
        det4Button.TabIndex = 3;
        det4Button.Text = "4 порядок";
        det4Button.UseVisualStyleBackColor = true;
        det4Button.Click += Det4Button_Click;
        // 
        // startButton
        // 
        startButton.Location = new Point(531, 72);
        startButton.Name = "startButton";
        startButton.Size = new Size(75, 23);
        startButton.TabIndex = 4;
        startButton.Text = "Расчёт";
        startButton.UseVisualStyleBackColor = true;
        startButton.Click += StartButton_Click;
        // 
        // resultLabel
        // 
        resultLabel.AutoSize = true;
        resultLabel.Location = new Point(18, 205);
        resultLabel.Name = "resultLabel";
        resultLabel.Size = new Size(38, 15);
        resultLabel.TabIndex = 5;
        resultLabel.Text = "label1";
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(det3Button);
        groupBox1.Controls.Add(det2Button);
        groupBox1.Controls.Add(det4Button);
        groupBox1.Location = new Point(12, 28);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(113, 147);
        groupBox1.TabIndex = 6;
        groupBox1.TabStop = false;
        groupBox1.Text = "Режим работы";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(683, 294);
        Controls.Add(groupBox1);
        Controls.Add(resultLabel);
        Controls.Add(startButton);
        Controls.Add(matrixDGV);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Name = "Form1";
        Text = "Определитель матрицы";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)matrixDGV).EndInit();
        groupBox1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView matrixDGV;
    private Button det2Button;
    private Button det3Button;
    private Button det4Button;
    private Button startButton;
    private Label resultLabel;
    private GroupBox groupBox1;
}
