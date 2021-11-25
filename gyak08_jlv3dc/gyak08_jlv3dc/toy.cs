using System;
using System.Windows.Forms;
using System.Drawing;

namespace gyak08_jlv3dc
{
    public abstract class toy : Label
    {
        public toy()
        {
            AutoSize = false;
            Width = 50;
            Height = 50;
            Paint += toy_paint;
        }

        private void toy_paint(object sender, PaintEventArgs e)
        {
            draw(e.Graphics);
        }

        protected abstract void draw(Graphics g);

        public virtual void moving()
        {
            Left += 1;
        }
    }
}