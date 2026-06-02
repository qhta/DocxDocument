
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `_CommandBarButtonEvents` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbuttonevents?view=office-pia` for Office interop details.
/// </remarks>
public partial interface _ICommandBarButtonEvents
{
  /// <summary>
  /// Invokes `Click`.
  /// </summary>
  /// <param name="Ctrl">The `Ctrl` parameter.</param>
  /// <param name="CancelDefault">The `CancelDefault` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbuttonevents.click?view=office-pia"/>
  public void Click(CommandBarButton Ctrl, ref bool CancelDefault);
}

