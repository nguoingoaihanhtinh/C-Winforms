using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;


namespace Circle_Game
{

    public partial class Form1 : Form
    {

        private const int circleDiameter = 40;
        private const int gameTimeInSeconds = 30;

        private int score = 0;
        private int timeRemaining = gameTimeInSeconds;
        private Random random = new Random();
        public Form1()
        {

            InitializeComponent();
            InitializeGame();
        }
        private void InitializeGame()
        {
            timer1.Interval = 500; // 0.5 seconds
            timer1.Tick += timer1_Tick;

            gamePanel.MouseClick += gamePanel_MouseClick;

            StartGame();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void StartGame()
        {
            score = 0;
            timeRemaining = gameTimeInSeconds;
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DrawGame();
            UpdateTimer();
        }
        private void DrawGame()
        {
            using (Graphics g = gamePanel.CreateGraphics())
            {
                g.Clear(Color.White);

                int redCircleIndex = random.Next(5);
                for (int i = 0; i < 5; i++)
                {
                    int x = random.Next(gamePanel.Width - circleDiameter);
                    int y = random.Next(gamePanel.Height - circleDiameter);
                    Color color = (i == redCircleIndex) ? Color.Red : Color.Green;

                    DrawCircle(g, x, y, color);
                }
            }
        }
        private void DrawCircle(Graphics g, int x, int y, Color color)
        {
            using (Brush brush = new SolidBrush(color))
            {
                g.FillEllipse(brush, x, y, circleDiameter, circleDiameter);
            }
        }
        private Color GetRandomColor()
        {
            Color[] colors = { Color.Blue, Color.Green, Color.Yellow };
            return colors[random.Next(colors.Length)];
        }

        private void UpdateTimer()
        {
            if (timeRemaining > 0)
            {
                timeRemaining--;
                timeLabel.Text = $"Time: {timeRemaining} seconds";
            }
            else
            {
                timer1.Stop();
                MessageBox.Show($"Game over! Your score is {score}", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                StartGame();
            }
        }
        private void gamePanel_MouseClick(object sender, MouseEventArgs e)
        {
            int redCircleIndex = random.Next(5);
            if (redCircleIndex == 4)
            {
                int x = e.X;
                int y = e.Y;
                if (x >= 0 && x <= gamePanel.Width - circleDiameter && y >= 0 && y <= gamePanel.Height - circleDiameter)
                {
                    score++;
                    scoreLabel.Text = $"Score: {score}";
                }
            }
        }
    }
}