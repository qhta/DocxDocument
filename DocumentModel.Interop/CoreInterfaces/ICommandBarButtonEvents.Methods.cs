
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icommandbarbuttonevents?view=office-pia
/// </remarks>
public partial interface ICommandBarButtonEvents
{
  /// <summary>
  /// Handles the click event for a command bar button.
  /// </summary>
  /// <param name="Ctrl">The `Ctrl` parameter.</param>
  /// <param name="CancelDefault">The `CancelDefault` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icommandbarbuttonevents.click?view=office-pia
  /// </remarks>
  public void Click(CommandBarButton Ctrl, ref bool CancelDefault);
}
