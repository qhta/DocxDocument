
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents events for a custom task pane.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customtaskpaneevents?view=office-pia"/>
public partial class CustomTaskPaneEvents
{
  /// <summary>
  /// Occurs when the user changes the visibility of the custom task pane.
  /// </summary>
  /// <param name="CustomTaskPaneInst">The `CustomTaskPaneInst` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customtaskpaneevents.visiblestatechange?view=office-pia"/>
  public void VisibleStateChange(CustomTaskPane CustomTaskPaneInst) { throw new NotImplementedException(); }
  /// <summary>
  /// Occurs when the user changes the docking position of the custom task pane.
  /// </summary>
  /// <param name="CustomTaskPaneInst">The `CustomTaskPaneInst` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customtaskpaneevents.dockpositionstatechange?view=office-pia"/>
  public void DockPositionStateChange(CustomTaskPane CustomTaskPaneInst) { throw new NotImplementedException(); }
}

