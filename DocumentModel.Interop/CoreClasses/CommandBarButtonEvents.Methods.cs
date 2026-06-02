
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icommandbarbuttonevents?view=office-pia"/>
public partial class CommandBarButtonEvents
{
  /// <summary>
  /// Handles the click event for a command bar button.
  /// </summary>
  /// <param name="Ctrl">The `Ctrl` parameter.</param>
  /// <param name="CancelDefault">The `CancelDefault` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icommandbarbuttonevents.click?view=office-pia"/>
  public void Click(CommandBarButton Ctrl, ref bool CancelDefault) { throw new NotImplementedException(); }
}


