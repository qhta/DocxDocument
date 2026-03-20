
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `ICommandBarButtonEvents` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icommandbarbuttonevents?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ICommandBarButtonEvents
{
  /// <summary>
  /// Invokes `Click`.
  /// </summary>
  /// <param name="Ctrl">The `Ctrl` parameter.</param>
  /// <param name="CancelDefault">The `CancelDefault` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.icommandbarbuttonevents.click?view=office-pia
  /// </remarks>
  public void Click(CommandBarButton Ctrl, ref bool CancelDefault);
}
