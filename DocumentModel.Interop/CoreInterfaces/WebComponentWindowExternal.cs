
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
  /// Gets the `InterfaceVersion` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentwindowexternal.interfaceversion?view=office-pia
  /// </remarks>
  public int InterfaceVersion { get; }
  /// <summary>
  /// Gets the `ApplicationName` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentwindowexternal.applicationname?view=office-pia
  /// </remarks>
  public string ApplicationName { get; }
  /// <summary>
  /// Gets the `ApplicationVersion` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentwindowexternal.applicationversion?view=office-pia
  /// </remarks>
  public int ApplicationVersion { get; }
  /// <summary>
  /// Gets the `WebComponent` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentwindowexternal.webcomponent?view=office-pia
  /// </remarks>
  public WebComponent WebComponent { get; }
}
