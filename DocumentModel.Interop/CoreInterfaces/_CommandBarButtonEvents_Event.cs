
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the event handler for the `Click` event of a `CommandBarButton` control.
/// </summary>
/// <param name="Ctrl">The `CommandBarButton` control that was clicked.</param>
/// <param name="CancelDefault">A boolean value that determines whether the default action should be canceled.</param>
public delegate void _CommandBarButtonEvents_ClickEventHandler(CommandBarButton Ctrl, ref bool CancelDefault);

/// <summary>
/// Represents the `_CommandBarButtonEvents_Event` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbuttonevents_event?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ICommandBarButtonEvents_Event
{
}
