
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icommandbarsevents?view=office-pia
/// </remarks>
public partial interface ICommandBarsEvents
{
  /// <summary>
  /// Handles updates to command bars.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icommandbarsevents.onupdate?view=office-pia
  /// </remarks>
  public void OnUpdate();
}
