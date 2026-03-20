
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `WebComponentWindowExternal` interface.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentwindowexternal?view=office-pia
/// </remarks>
public partial interface WebComponentWindowExternal
{
  /// <summary>
  /// Invokes `CloseWindow`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentwindowexternal.closewindow?view=office-pia
  /// </remarks>
  public void CloseWindow();
}
