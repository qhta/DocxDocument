
namespace DocumentModel.Application;

public delegate void _CommandBarButtonEvents_ClickEventHandler(ICommandBarButton Ctrl, ref bool CancelDefault);

/// <summary>
/// Represents the `_CommandBarButtonEvents_Event` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbuttonevents_event?view=office-pia` for Office interop details.
/// </remarks>
public partial interface I_CommandBarButtonEvents_Event
{
}
