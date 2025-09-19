using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CRUD
{
    public class GradientSideBarPanel :Panel
    {
        public Color gradientTop {  get; set; }
        public Color gradientBottom {  get; set; }

        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush linear = new LinearGradientBrush(this.ClientRectangle, this.gradientTop, this.gradientBottom, 90F);
            Graphics g = e.Graphics;
            g.FillRectangle(linear, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
