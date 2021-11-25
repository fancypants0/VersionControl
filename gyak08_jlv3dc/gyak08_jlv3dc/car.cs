using System;
using System.Drawing;
using System.Windows.Forms;

namespace gyak08_jlv3dc
{
    public class car : toy
    {
        protected override void draw(Graphics g)
        {
            Image src = Image.FromFile("images/car.png");
            g.DrawImage(src, new Rectangle(0, 0, Width, Height));
        }
    }
}