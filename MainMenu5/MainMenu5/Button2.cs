﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MainMenu5
{
    public class Button2 : Button
    {
        public Button2()
        {
            this.MouseEnter += Button2_MouseEnter;
            this.MouseLeave += Button2_MouseLeave;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 1;
            this.FlatAppearance.BorderColor = Color.Black;
            this.Font = new Font("Tahoma", 14, FontStyle.Regular);
            this.Size = new Size(140,140);
            this.BackgroundImage = Image.FromFile("E:\\نمونه فرم\\MainMenu5\\MainMenu5\\Resources\\Button2.png");
            this.UseCompatibleTextRendering = true;
            this.ForeColor = Color.White;
            this.Padding = new Padding(3, 0, 0, 6);
            this.TextAlign = ContentAlignment.BottomLeft;
            this.BackgroundImageLayout = ImageLayout.Center;
            // this.Cursor = Cursors.Hand;

        }

        Color backcolor;
        Color forColor;

        Color _backcolor;
        Color _forColor;

        public Color MSEBColor
        {
            get { return backcolor; }
            set { backcolor = value; }
        }
        public Color MSEFColor
        {
            get { return forColor; }
            set { forColor = value; }

        }
        public Color MSLBColor
        {
            get { return _backcolor; }
            set { _backcolor = value; }

        }
        public Color MSLFColor
        {
            get { return _forColor; }
            set { _forColor = value; }

        }




        private void Button2_MouseLeave(object? sender, EventArgs e)
        {
            this.FlatAppearance.BorderColor = Color.Black;
        }

        private void Button2_MouseEnter(object? sender, EventArgs e)
        {
            this.FlatAppearance.BorderColor = Color.White;
        }
    }
}
