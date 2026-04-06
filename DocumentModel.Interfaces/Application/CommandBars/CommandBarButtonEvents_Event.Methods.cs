
namespace DocumentModel.Application;


/// <summary>
/// Represents the `CommandBarButtonEvents_Event` interface.
/// </summary>
/// <remarks>
/// See `http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbuttonevents_event?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ICommandBarButtonEventsEvent
{
  /// <summary>
  /// Occurs when `Click` is raised.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbuttonevents_event.click?view=office-pia"/>
  public event CommandBarButtonEvents_ClickEventHandler Click;
}


