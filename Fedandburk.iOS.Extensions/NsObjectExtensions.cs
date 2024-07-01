using System;
using Foundation;

namespace Fedandburk.iOS.Extensions;

public static class NsObjectExtensions
{
    /// <summary>
    /// Invokes provided action on main UI thread.
    /// </summary>
    /// <param name="object">Source object.</param>
    /// <param name="action">Action to invoke.</param>
    public static void InvokeOnMainThreadIfNeeded(this NSObject @object, Action action)
    {
        ArgumentNullException.ThrowIfNull(@object);
        ArgumentNullException.ThrowIfNull(action);

        if (NSThread.IsMain)
        {
            action.Invoke();
        }
        else
        {
            @object.InvokeOnMainThread(action);
        }
    }
}