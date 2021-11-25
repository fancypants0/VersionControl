using System;
using System.Drawing;
using System.Windows.Forms;

namespace gyak08_jlv3dc
{
    public class ball : toy
    {
        protected override void draw(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Blue), 0, 0, Width, Height);
        }
    }
}