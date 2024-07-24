using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class CircularButton : Button
{
    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);
        GraphicsPath graphicsPath = new GraphicsPath();
        graphicsPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
        this.Region = new Region(graphicsPath);

        // Draw the circular button
        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        pevent.Graphics.FillEllipse(new SolidBrush(this.BackColor), 0, 0, ClientSize.Width, ClientSize.Height);
        pevent.Graphics.DrawEllipse(new Pen(this.ForeColor), 0, 0, ClientSize.Width - 1, ClientSize.Height - 1);

        // Draw the text
        TextRenderer.DrawText(pevent.Graphics, this.Text, this.Font, this.ClientRectangle, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }
}
