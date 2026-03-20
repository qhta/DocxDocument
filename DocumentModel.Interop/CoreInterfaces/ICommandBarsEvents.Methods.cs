
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `ICommandBarsEvents` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icommandbarsevents?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ICommandBarsEvents
{
  /// <summary>
  /// Invokes `OnUpdate`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icommandbarsevents.onupdate?view=office-pia
  /// </remarks>
  public void OnUpdate();
}
