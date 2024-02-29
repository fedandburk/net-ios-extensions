using UIKit;

namespace Fedandburk.iOS.Extensions;

public interface IExpandableCellController
{
    void OnExpanded(UITableViewCell sourceCell, UITableViewCell expandedCell);
    void OnCollapsed(UITableViewCell sourceCell, UITableViewCell collapsedCell);
}