
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `WebComponentFormat` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentformat?view=office-pia` for Office interop details.
/// </remarks>
public partial interface WebComponentFormat
{
  /// <summary>
  /// Invokes `LaunchPropertiesWindow`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentformat.launchpropertieswindow?view=office-pia
  /// </remarks>
  public void LaunchPropertiesWindow();
}
