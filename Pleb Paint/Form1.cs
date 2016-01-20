using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;
using System.Drawing.Imaging;


namespace Pleb_Paint
{
    public partial class MainForm : Form
    {
        //global variables
        SoundPlayer pleblifesound = new SoundPlayer(Properties.Resources.The_more_you_know);
        SoundPlayer backgroundTheme = new SoundPlayer(Properties.Resources.MC_Bach_Concerto_For_Flute_In_D_Minor_Second_Movement);
        int red, green, blue;
        Random randNum = new Random();
        SolidBrush drawBrush = new SolidBrush(Color.Black);
        Boolean squarebrushSelected = false;
        Boolean circlebrushSelected = false;
        bool draw = false;
        Graphics g;

        int size = 50;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SplashScreen();

        }
        //square button press
        private void squarebrushButton_Click(object sender, EventArgs e)
        {
            squarebrushSelected = true;
            circlebrushSelected = false;
            squarebrushButton.BackColor = Color.SandyBrown;
            circlebrushButton.BackColor = Color.NavajoWhite;
            largebrushButton.BackColor = Color.NavajoWhite;

        }
        //circle button press
        private void circlebrushButton_Click(object sender, EventArgs e)
        {
            circlebrushSelected = true;
            squarebrushSelected = false;
            circlebrushButton.BackColor = Color.SandyBrown;
            squarebrushButton.BackColor = Color.NavajoWhite;
            largebrushButton.BackColor = Color.NavajoWhite;
        }

        //shows colour picker
        private void colourpickerButton_Click(object sender, EventArgs e)
        {
            DialogResult result = colourDialog.ShowDialog();         
            if (result == DialogResult.OK)//if user clicks ok
            {
                drawBrush.Color = colourDialog.Color;//sets brush to selected colour
                currentcolourPanel.Refresh();//refreshes panel
            }
        }

        //large brush
        private void largebrushButton_Click(object sender, EventArgs e)
        {
            size = 40;
            largebrushButton.BackColor = Color.SandyBrown;
            mediumbrushButton.BackColor = Color.NavajoWhite;
            smallbrushButton.BackColor = Color.NavajoWhite;
        }
        //release mouse
        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            draw = false;
        }
        //move mouse while pressed down
        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                int mouseX = Cursor.Position.X;
                int mouseY = Cursor.Position.Y;

                g = this.CreateGraphics();
                if (squarebrushSelected == true)
                {
                    mouseX = mouseX - this.Left - 30;
                    mouseY = mouseY - this.Top - 50;
                    g.FillRectangle(drawBrush, mouseX, mouseY, size, size);
                }
                if (circlebrushSelected == true)
                {
                    mouseX = mouseX - this.Left - 30;
                    mouseY = mouseY - this.Top - 50;
                    g.FillEllipse(drawBrush, mouseX, mouseY, size, size);
                }
            }
        }
        //medium brush
        private void mediumbrushButton_Click(object sender, EventArgs e)
        {
            size = 20;
            largebrushButton.BackColor = Color.NavajoWhite;
            mediumbrushButton.BackColor = Color.SandyBrown;
            smallbrushButton.BackColor = Color.NavajoWhite;
        }
        //small brush
        private void smallbrushButton_Click(object sender, EventArgs e)
        {
            size = 10;
            largebrushButton.BackColor = Color.NavajoWhite;
            mediumbrushButton.BackColor = Color.NavajoWhite;
            smallbrushButton.BackColor = Color.SandyBrown;
        }

        private void currentcolourPanel_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.FillRectangle(drawBrush, 1, 8, 10, 10);
        }
        //save as button
        private void saveasButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefileDialog = new SaveFileDialog();

            savefileDialog.Filter = "jpg files (*.jpg)|*.jpg";
            savefileDialog.FilterIndex = 2;
            savefileDialog.RestoreDirectory = true;
            savefileDialog.OverwritePrompt = true;

            DialogResult result1 = savefileDialog.ShowDialog();
            //show save as window
            if (savefileDialog.ShowDialog() == DialogResult.OK)
            {
                Thread.Sleep(500);

                Rectangle bounds = this.Bounds;
                using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
                {
                    using (Graphics g = Graphics.FromImage(bitmap))
                    {
                        g.CopyFromScreen(new Point(bounds.Left + 2, bounds.Top), Point.Empty, bounds.Size);
                    }
                    bitmap.Save(savefileDialog.FileName, ImageFormat.Jpeg);
                }
            }
        }
        //Clear Canvas
        private void clearcanvasButton_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Clear the Canvas?", "Clear Canvas", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result1 == DialogResult.Yes)
            {
                Refresh();
            }
        }


        //start drawing
        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;

            if (draw)
            {
                int mouseX = Cursor.Position.X;
                int mouseY = Cursor.Position.Y;

                g = this.CreateGraphics();
                if (squarebrushSelected == true)
                {
                    mouseX = mouseX - this.Left - 30;
                    mouseY = mouseY - this.Top - 50;
                    g.FillRectangle(drawBrush, mouseX, mouseY, size, size);
                }
                if (circlebrushSelected == true)
                {
                    mouseX = mouseX - this.Left - 30;
                    mouseY = mouseY - this.Top - 50;
                    g.FillEllipse(drawBrush, mouseX, mouseY, size, size);
                }
            }
        }

        /// <summary>
        /// Splash Screen
        /// </summary>
        public void SplashScreen()
        {
            pleblifesound.PlayLooping();
            Form ss = new Form();
            ss.FormBorderStyle = FormBorderStyle.None;
            ss.Size = new Size(400, 400);
            ss.StartPosition = FormStartPosition.CenterScreen;
            ss.BackColor = Color.Blue;
            ss.TransparencyKey = Color.Blue;
            ss.Show();
            Graphics ssGraphics = ss.CreateGraphics();
            SolidBrush ssBrush = new SolidBrush(Color.DimGray);
            SolidBrush textBrush = new SolidBrush(Color.Green);
            Font ssFont = new Font("Impact", 30);
            ssGraphics.FillEllipse(ssBrush, 0, 0, 400, 400);
            ssBrush.Color = Color.Green;
            ssGraphics.DrawImage(Properties.Resources.KAPPA, 100, 55, 200, 200);
            for (int i = 50; i < 200; i++)
            {
                red = randNum.Next(1, 256);
                green = randNum.Next(1, 256);
                blue = randNum.Next(1, 256);
                textBrush.Color = Color.FromArgb(red, green, blue, 0);
                ssGraphics.DrawString("Pleb life studios", ssFont, textBrush, 70, 270);
                ssBrush.Color = Color.FromArgb(red, green, blue, 0);
                ssGraphics.FillRectangle(ssBrush, 400 - i, 330, 3, 3);
                ssGraphics.FillRectangle(ssBrush, i, 330, 3, 3);
                Thread.Sleep(10);
            }
            Thread.Sleep(3000);
            pleblifesound.Stop();
            backgroundTheme.PlayLooping();
            ss.Close();
        }
    }
}
