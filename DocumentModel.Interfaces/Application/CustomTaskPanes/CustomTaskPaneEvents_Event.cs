
namespace DocumentModel.Application;
#pragma warning disable CS1591
public delegate void _CustomTaskPaneEvents_VisibleStateChangeEventHandler(ICustomTaskPane CustomTaskPaneInst);
public delegate void _CustomTaskPaneEvents_DockPositionStateChangeEventHandler(ICustomTaskPane CustomTaskPaneInst);

/// <summary>
/// Events interface for CustomTaskPane object events.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customtaskpaneevents_event?view=office-pia"/>
public partial interface ICustomTaskPaneEvents_Event
{
}

