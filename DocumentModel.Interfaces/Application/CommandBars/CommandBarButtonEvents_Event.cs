
namespace DocumentModel.Application;
#pragma warning disable CS1591
public delegate void CommandBarButtonEvents_ClickEventHandler(ICommandBarButton Ctrl, ref bool CancelDefault);

/// <summary>
/// Represents the `CommandBarButtonEvents_Event` interface.
/// </summary>
/// <remarks>
/// See `http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbuttonevents_event?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ICommandBarButtonEventsEvent
{
}

