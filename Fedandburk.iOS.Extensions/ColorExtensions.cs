using System.Drawing;
using UIKit;

namespace Fedandburk.iOS.Extensions;

public static class ColorExtensions
{
    /// <summary>
    /// Converts provided <c>Color</c> to <c>UIColor</c>.
    /// </summary>
    /// <param name="color"></param>
    /// <returns>an instance of <c>UIColor</c></returns>
    public static UIColor ToColor(this Color color)
    {
        return UIColor.FromRGBA(color.R, color.G, color.B, color.A);
    }
}