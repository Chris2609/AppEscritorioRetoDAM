using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppEscritorioRetoDAM
{
    public partial class AvisoUsuarioCreado : UserControl
    {
        public AvisoUsuarioCreado()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(AvisoUsuarioCreado_Paint);
        }

        private void AvisoUsuarioCreado_Load(object sender, EventArgs e)
        {

        }

        private void AvisoUsuarioCreado_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);
            int radius = 20;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y, radius, radius, 270, 90);
            path.AddArc(bounds.X + bounds.Width - radius, bounds.Y + bounds.Height - radius, radius, radius, 0, 90);
            path.AddArc(bounds.X, bounds.Y + bounds.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            this.Region = new Region(path);
        }
    }
}
