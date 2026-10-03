using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LabCSharp0._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox.Paint += PictureBox_Paint;
        }

        // Draw a rectangle on the PictureBox when it is painted
        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            e.Graphics.DrawRectangle(Pens.Black, 10, 10, 100, 100);
            e.Graphics.DrawLine(Pens.Red, 10, 10, 110, 110);
            e.Graphics.DrawLine(Pens.Red, 110,10, 10, 110);
        }
    }
}
