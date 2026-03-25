
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `WebComponentFormat` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentformat?view=office-pia"/>
public partial interface WebComponentFormat: InteropObject
{
  /// <summary>
  /// Invokes `LaunchPropertiesWindow`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentformat.launchpropertieswindow?view=office-pia"/>
  public void LaunchPropertiesWindow();
}

