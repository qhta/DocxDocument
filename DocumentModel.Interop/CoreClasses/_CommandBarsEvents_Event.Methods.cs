
namespace DocumentModel.Interop.Core;


/// <summary>
/// Events class for CommandBars object events.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarsevents_event?view=office-pia"/>
public partial class _CommandBarsEvents_Event
{
  /// <summary>
  /// Occurs when any change is made to a command bar.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarsevents_event.onupdate?view=office-pia"/>
  public event _CommandBarsEvents_OnUpdateEventHandler OnUpdate { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }
}

