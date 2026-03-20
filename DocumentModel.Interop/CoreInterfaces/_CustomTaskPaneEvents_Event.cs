
namespace DocumentModel.Interop.Core;

public delegate void _CustomTaskPaneEvents_VisibleStateChangeEventHandler(CustomTaskPane CustomTaskPaneInst);
public delegate void _CustomTaskPaneEvents_DockPositionStateChangeEventHandler(CustomTaskPane CustomTaskPaneInst);

/// <summary>
/// Events interface for CustomTaskPane object events.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customtaskpaneevents_event?view=office-pia
/// </remarks>
public partial interface _CustomTaskPaneEvents_Event
{
}
