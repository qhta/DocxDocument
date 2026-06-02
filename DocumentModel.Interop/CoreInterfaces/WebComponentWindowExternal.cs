
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `WebComponentWindowExternal` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentwindowexternal?view=office-pia"/>
public partial interface IWebComponentWindowExternal
{
  /// <summary>
  /// Gets the `InterfaceVersion` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentwindowexternal.interfaceversion?view=office-pia"/>
  public int InterfaceVersion { get; }
  /// <summary>
  /// Gets the `ApplicationName` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentwindowexternal.applicationname?view=office-pia"/>
  public string ApplicationName { get; }
  /// <summary>
  /// Gets the `ApplicationVersion` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentwindowexternal.applicationversion?view=office-pia"/>
  public int ApplicationVersion { get; }
  /// <summary>
  /// Gets the `WebComponent` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentwindowexternal.webcomponent?view=office-pia"/>
  public WebComponent WebComponent { get; }


  #region methods

/// <summary>
  /// Invokes `CloseWindow`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentwindowexternal.closewindow?view=office-pia"/>
  public void CloseWindow();

  #endregion methods
}

