
namespace DocumentModel.Application;


/// <summary>
/// Events interface for CommandBars object events.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarsevents_event?view=office-pia"/>
public partial interface ICommandBarsEvents_Event
{
  /// <summary>
  /// Occurs when any change is made to a command bar.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarsevents_event.onupdate?view=office-pia"/>
  public event CommandBarsEvents_OnUpdateEventHandler OnUpdate;
}


