using System.Linq;
using UIKit;

namespace Fedandburk.iOS.Extensions;

public static class UiApplicationExtensions
{
    /// <summary>
    /// Searches for a topmost presented <c>UIViewController</c>.
    /// </summary>
    /// <param name="application"></param>
    /// <returns>The topmost <c>UIViewController</c> or <c>null</c> if not found.</returns>
    public static UIViewController? GetTopViewController(this UIApplication application)
    {
        var window = application.ConnectedScenes
            .ToArray()
            .OfType<UIWindowScene>()
            .Select(item => item.KeyWindow)
            .FirstOrDefault();

        var topViewController = window?.RootViewController;

        if (topViewController == null)
        {
            return null;
        }

        while (topViewController.PresentedViewController != null)
        {
            topViewController = topViewController.PresentedViewController;
        }

        var navigationController = topViewController as UINavigationController;

        if (navigationController != null)
        {
            topViewController = navigationController.ViewControllers?.LastOrDefault();
        }

        return topViewController ?? navigationController;
    }
}