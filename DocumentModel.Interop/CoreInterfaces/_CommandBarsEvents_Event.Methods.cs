
namespace DocumentModel.Interop.Core;


/// <summary>
/// Events interface for CommandBars object events.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarsevents_event?view=office-pia"/>
public partial interface _ICommandBarsEvents_Event
{
  /// <summary>
  /// Occurs when any change is made to a command bar.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarsevents_event.onupdate?view=office-pia"/>
  public event _CommandBarsEvents_OnUpdateEventHandler OnUpdate;
}

