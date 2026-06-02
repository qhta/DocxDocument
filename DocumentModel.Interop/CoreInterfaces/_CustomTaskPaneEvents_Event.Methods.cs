
namespace DocumentModel.Interop.Core;


/// <summary>
/// Exposes .NET event handlers for custom task pane events.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customtaskpaneevents_event?view=office-pia"/>
public partial interface _ICustomTaskPaneEvents_Event
{
  /// <summary>
  /// Occurs when the user changes the visibility of the custom task pane.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customtaskpaneevents_event.visiblestatechange?view=office-pia"/>
  public event _CustomTaskPaneEvents_VisibleStateChangeEventHandler VisibleStateChange;

  /// <summary>
  /// Occurs when the user changes the docking position of the active custom task pane.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customtaskpaneevents_event.dockpositionstatechange?view=office-pia"/>
  public event _CustomTaskPaneEvents_DockPositionStateChangeEventHandler DockPositionStateChange;
}

