
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents events for a custom task pane.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customtaskpaneevents?view=office-pia
/// </remarks>
public partial interface CustomTaskPaneEvents
{
  /// <summary>
  /// Occurs when the user changes the visibility of the custom task pane.
  /// </summary>
  /// <param name="CustomTaskPaneInst">The `CustomTaskPaneInst` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customtaskpaneevents.visiblestatechange?view=office-pia
  /// </remarks>
  public void VisibleStateChange(CustomTaskPane CustomTaskPaneInst);
  /// <summary>
  /// Occurs when the user changes the docking position of the custom task pane.
  /// </summary>
  /// <param name="CustomTaskPaneInst">The `CustomTaskPaneInst` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customtaskpaneevents.dockpositionstatechange?view=office-pia
  /// </remarks>
  public void DockPositionStateChange(CustomTaskPane CustomTaskPaneInst);
}
