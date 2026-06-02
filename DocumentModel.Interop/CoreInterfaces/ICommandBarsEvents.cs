
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icommandbarsevents?view=office-pia"/>
public partial interface ICommandBarsEvents
{


  #region methods

/// <summary>
  /// Handles updates to command bars.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icommandbarsevents.onupdate?view=office-pia"/>
  public void OnUpdate();

  #endregion methods
}

