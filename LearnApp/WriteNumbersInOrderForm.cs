using System;
using System.Linq;
using System.Windows.Forms;

namespace MathGame
{
    public partial class WriteNumbersInOrderForm : Form
    {
        private Random random = new Random();
        private int[] shuffledNumbers;
        private Timer colorResetTimer;

        public WriteNumbersInOrderForm()
        {
            InitializeComponent();
            InitializeTimer();
        }

        private void WriteNumbersInOrderForm_Load(object sender, EventArgs e)
        {
            GenerateNewQuestion();
        }

        private void InitializeTimer()
        {
            colorResetTimer = new Timer();
            colorResetTimer.Interval = 1200; // 1.2 seconds
            colorResetTimer.Tick += ColorResetTimer_Tick;
        }

        private void ColorResetTimer_Tick(object sender, EventArgs e)
        {
            trfl.BackColor = System.Drawing.Color.White;
            colorResetTimer.Stop();
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            string[] inputNumbers = txtNumbers.Text.Split(' ');
            bool isCorrect = inputNumbers.Length == shuffledNumbers.Length &&
                             inputNumbers.Select(int.Parse).SequenceEqual(shuffledNumbers.OrderBy(n => n));

            if (isCorrect)
            {
                trfl.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                trfl.BackColor = System.Drawing.Color.Red;
            }

            colorResetTimer.Start(); // Start the timer
            GenerateNewQuestion();
            txtNumbers.Clear();
        }

        private void GenerateNewQuestion()
        {
            int start = random.Next(1, 20);
            int count = random.Next(5, 11); // Generates a count between 5 and 10
            shuffledNumbers = Enumerable.Range(start, count).OrderBy(x => random.Next()).ToArray();
            lblInstruction.Text = $"Arrange these numbers in ascending order: {string.Join(" ", shuffledNumbers)}";
        }

        private void lblInstruction_Click(object sender, EventArgs e)
        {

        }

        private void txtNumbers_TextChanged(object sender, EventArgs e)
        {

        }

        private void trfl_Click(object sender, EventArgs e)
        {

        }
    }
}
