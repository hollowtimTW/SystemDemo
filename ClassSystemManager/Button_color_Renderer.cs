using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassSystemManager
{
    public class Button_color_Renderer: ToolStripProfessionalRenderer
    {
        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            base.OnRenderButtonBackground(e);

            if (e.Item is ToolStripButton)
            {
                ToolStripButton button = (ToolStripButton)e.Item;

                // 設定按鈕的背景色
                using (Brush brush = new SolidBrush(Color.FromArgb(224,224,224)))  // 這裡可以替換為你想要的背景色
                {
                    e.Graphics.FillRectangle(brush, 0, 0, button.Width, button.Height);
                }
            }
        }
    }
}
