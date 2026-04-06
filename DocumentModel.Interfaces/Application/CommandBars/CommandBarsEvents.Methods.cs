
namespace DocumentModel.Application;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarsevents?view=office-pia"/>
public partial interface ICommandBarsEvents
{
  /// <summary>
  /// Occurs when any change is made to a command bar.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarsevents.onupdate?view=office-pia"/>
  public void OnUpdate();
}

