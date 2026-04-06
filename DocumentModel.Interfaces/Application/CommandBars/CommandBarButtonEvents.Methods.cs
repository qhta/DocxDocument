
namespace DocumentModel.Application;

/// <summary>
/// Represents the `CommandBarButtonEvents` interface.
/// </summary>
/// <remarks>
/// See `http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbuttonevents?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ICommandBarButtonEvents
{
  /// <summary>
  /// Invokes `Click`.
  /// </summary>
  /// <param name="Ctrl">The `Ctrl` parameter.</param>
  /// <param name="CancelDefault">The `CancelDefault` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbuttonevents.click?view=office-pia"/>
  public void Click(ICommandBarButton Ctrl, ref bool CancelDefault);
}


