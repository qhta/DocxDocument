
namespace DocumentModel.Interop.Core;


/// <summary>
/// Represents the `_CommandBarButtonEvents_Event` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbuttonevents_event?view=office-pia` for Office interop details.
/// </remarks>
public partial interface _CommandBarButtonEvents_Event
{
  /// <summary>
  /// Occurs when `Click` is raised.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbuttonevents_event.click?view=office-pia
  /// </remarks>
  public event _CommandBarButtonEvents_ClickEventHandler Click;
}
