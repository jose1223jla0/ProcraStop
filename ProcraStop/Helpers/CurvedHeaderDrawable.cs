namespace ProcraStop.Helpers;

public class CurvedHeaderDrawable : IDrawable
{
    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        canvas.FillColor = Color.FromArgb("ff7f7f");
        var path = new PathF();

        path.MoveTo(0, dirtyRect.Height * 0.5f);//donde inicia

        path.CurveTo(
            dirtyRect.Width * 0.30f, dirtyRect.Height * 0.35f,   // arriba
            dirtyRect.Width * 0.50f, dirtyRect.Height * 0.98f,   // abajo
            dirtyRect.Width * 1.00f, dirtyRect.Height * 1.00f    // punto final
        );

        path.LineTo(dirtyRect.Width, 0);//donde termina
        path.LineTo(0, 0);
        path.Close();
        canvas.FillPath(path);
    }
}
