
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customtaskpaneevents?view=office-pia
/// </remarks>
public partial interface _CustomTaskPaneEvents
{
  /// <summary>
  /// Occurs when the user changes the visibility of the custom task pane.
  /// </summary>
  /// <param name="CustomTaskPaneInst">The active task pane.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customtaskpaneevents.visiblestatechange?view=office-pia
  /// </remarks>
  public void VisibleStateChange(CustomTaskPane CustomTaskPaneInst);

  /// <summary>
  /// Occurs when the user changes the docking position of the active custom task pane.
  /// </summary>
  /// <param name="CustomTaskPaneInst">The active custom task pane.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customtaskpaneevents.dockpositionstatechange?view=office-pia
  /// </remarks>
  public void DockPositionStateChange(CustomTaskPane CustomTaskPaneInst);
}
