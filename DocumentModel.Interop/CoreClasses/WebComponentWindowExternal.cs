
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `WebComponentWindowExternal` class.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentwindowexternal?view=office-pia"/>
public partial class WebComponentWindowExternal
{
  /// <summary>
  /// Gets the `InterfaceVersion` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentwindowexternal.interfaceversion?view=office-pia"/>
  public int InterfaceVersion { get; }
  /// <summary>
  /// Gets the `ApplicationName` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentwindowexternal.applicationname?view=office-pia"/>
  public string ApplicationName { get; }
  /// <summary>
  /// Gets the `ApplicationVersion` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentwindowexternal.applicationversion?view=office-pia"/>
  public int ApplicationVersion { get; }
  /// <summary>
  /// Gets the `WebComponent` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentwindowexternal.webcomponent?view=office-pia"/>
  public WebComponent WebComponent { get; }
}

