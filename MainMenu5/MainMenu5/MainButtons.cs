using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Text;
using System.Drawing.Design;

namespace MainMenu5
{
    public class MainButtons:Button
    {
        public MainButtons()
        {
            this.MouseEnter += MainButtons_MouseEnter;
            this.MouseLeave += MainButtons_MouseLeave;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Font = new Font("Microsoft New Tai Lue", 12, FontStyle.Regular);
            this.Size = new Size(247, 34);
            this.BackColor = Color.Transparent;
            this.TextAlign = ContentAlignment.MiddleLeft;

        }

        Color backcolor = Color.Transparent;
        Color forColor = Color.Black;

        Color _backcolor = Color.Transparent;
        Color _forColor= Color.Black;

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




        private void MainButtons_MouseLeave(object? sender, EventArgs e)
        {
            this.BackColor = _backcolor;
            this.ForeColor = _forColor;
            this.FlatAppearance.BorderSize = 0;

        }

        private void MainButtons_MouseEnter(object? sender, EventArgs e)
        {
            this.BackColor = backcolor;
            this.ForeColor = forColor;
            this.FlatAppearance.BorderSize = 1;
            this.FlatAppearance.BorderColor = Color.White;
        }
    }
}
