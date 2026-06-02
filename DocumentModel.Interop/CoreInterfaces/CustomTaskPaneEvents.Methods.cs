
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents events for a custom task pane.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customtaskpaneevents?view=office-pia"/>
public partial interface ICustomTaskPaneEvents
{
  /// <summary>
  /// Occurs when the user changes the visibility of the custom task pane.
  /// </summary>
  /// <param name="CustomTaskPaneInst">The `CustomTaskPaneInst` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customtaskpaneevents.visiblestatechange?view=office-pia"/>
  public void VisibleStateChange(CustomTaskPane CustomTaskPaneInst);
  /// <summary>
  /// Occurs when the user changes the docking position of the custom task pane.
  /// </summary>
  /// <param name="CustomTaskPaneInst">The `CustomTaskPaneInst` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customtaskpaneevents.dockpositionstatechange?view=office-pia"/>
  public void DockPositionStateChange(CustomTaskPane CustomTaskPaneInst);
}

