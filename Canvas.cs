using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacroHard_Paint
{
    public partial class Canvas : Form
    {
        // Pen and Coords Fields
        private Pen pen;
        private LinkedList<Coords> points;
        private Graphics graphics;

        // Color Properties
        private int Red { get; set; }
        private int Green { get; set; }
        private int Blue { get; set; }
        private new int Opacity { get; set; }

        public Canvas()
        {
            InitializeComponent();
            Red = 0;
            Green = 0;
            Blue = 0;
            Opacity = 255;
            pen = new Pen(Color.FromArgb(Opacity, Red, Green, Blue));
            points = new LinkedList<Coords>();
            graphics = CreateGraphics();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            if (points.Count > 1)
            {
                for (int i = 0; i < points.Count - 1; i++)
                {
                    int x1 = points.ElementAt(i).X;
                    int y1 = points.ElementAt(i).Y;
                    int x2 = points.ElementAt(i + 1).X;
                    int y2 = points.ElementAt(i + 1).Y;
                    e.Graphics.DrawLine(pen, x1, y1, x2, y2);
                }
            }
        }

        private void OnMouseClick(object sender, MouseEventArgs e)
        {
            points.AddLast(new Coords(e.X, e.Y));
            DrawingCanvas.Refresh();
        }

        /*private void OnMouseDown(object sender, MouseEventArgs e)
        {
            points.AddLast(new Coords(e.X, e.Y));
            DrawingCanvas.Refresh();   
        }*/

        private void BtnClear_Click(object sender, EventArgs e)
        {
            points.Clear();
            DrawingCanvas.Refresh();
        }

        private void TxtRed_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Red = int.Parse(txtRed.Text);
            }
            catch (Exception)
            {
                Red = 0;
            }
            finally
            {
                UpdatePen(Color.FromArgb(Opacity, Red, Green, Blue));
            }
        }

        private void TxtGreen_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Green = int.Parse(txtGreen.Text);
            }
            catch (Exception)
            {
                Green = 0;
            }
            finally
            {
                UpdatePen(Color.FromArgb(Opacity, Red, Green, Blue));
            }
        }

        private void TxtBlue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Blue = int.Parse(txtBlue.Text);
            }
            catch (Exception)
            {
                Blue = 0;
            }
            finally
            {
                UpdatePen(Color.FromArgb(Opacity, Red, Green, Blue));
            }
        }

        private void TxtOpacity_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Opacity = int.Parse(txtOpacity.Text);
            } catch (Exception)
            {
                Opacity = 255;

            } finally
            {
                UpdatePen(Color.FromArgb(Opacity, Red, Green, Blue));
            }
        }

        private void UpdatePen(Color c)
        {
            pen = new Pen(c);
        }

        private void SaveDrawingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bitmap drawing = new Bitmap(DrawingCanvas.Width, DrawingCanvas.Height);
            DrawingCanvas.DrawToBitmap(drawing, new Rectangle(0, 0, DrawingCanvas.Width, DrawingCanvas.Height));

            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png|Tiff Image (.tiff)|*.tiff|Wmf Image (.wmf)|*.wmf";
            sf.ShowDialog();
            var path = sf.FileName;

            drawing.Save(@"" + path, ImageFormat.Bmp);
        }
    }
}
