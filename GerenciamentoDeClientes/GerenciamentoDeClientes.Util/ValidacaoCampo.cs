using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeClientes.Util
{
    public static class ValidacaoCampo
    {
        public static void DestacarLabel(Control lbl, bool destacar)
        {
            if (destacar)
                lbl.ForeColor = Color.Red;
            else
                lbl.ForeColor = Color.Black;
        }

        public static void AlteraBordaControl(Control control, PaintEventArgs e)
        {
            Rectangle rect = new Rectangle(control.Location.X - 2, control.Location.Y - 2, control.Width + 2, control.Height + 2);

            Pen pen = new Pen(Color.Red);
            Graphics g = e.Graphics;

            g.DrawRectangle(pen, rect);
        }
      
    }
}
