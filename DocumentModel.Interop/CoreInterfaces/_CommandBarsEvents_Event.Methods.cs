
namespace DocumentModel.Interop.Core;


/// <summary>
/// Events interface for CommandBars object events.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarsevents_event?view=office-pia
/// </remarks>
public partial interface _CommandBarsEvents_Event
{
  /// <summary>
  /// Occurs when any change is made to a command bar.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarsevents_event.onupdate?view=office-pia
  /// </remarks>
  public event _CommandBarsEvents_OnUpdateEventHandler OnUpdate;
}
