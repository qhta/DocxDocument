
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `_CommandBarButtonEvents_Event` class.
/// </summary>
/// <remarks>
/// See `http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbuttonevents_event?view=office-pia` for Office interop details.
/// </remarks>
public partial class _CommandBarButtonEvents_Event
{
  /// <summary>
  /// Occurs when `Click` is raised.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbuttonevents_event.click?view=office-pia"/>
  public event _CommandBarButtonEvents_ClickEventHandler Click { add { throw new NotImplementedException(); } remove { throw new NotImplementedException(); } }
}
