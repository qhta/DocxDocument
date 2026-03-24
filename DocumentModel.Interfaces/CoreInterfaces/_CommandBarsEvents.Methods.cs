
namespace DocumentModel.Interfaces;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarsevents?view=office-pia"/>
public partial interface _CommandBarsEvents
{
  /// <summary>
  /// Occurs when any change is made to a command bar.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarsevents.onupdate?view=office-pia"/>
  public void OnUpdate();
}

