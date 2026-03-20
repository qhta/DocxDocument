
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarsevents?view=office-pia
/// </remarks>
public partial interface _CommandBarsEvents
{
  /// <summary>
  /// Occurs when any change is made to a command bar.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarsevents.onupdate?view=office-pia
  /// </remarks>
  public void OnUpdate();
}
