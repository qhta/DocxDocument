
namespace DocumentModel.Application;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoeservicesdialog?view=office-pia"/>
public partial interface EServicesDialog: InteropObject
{
  /// <summary>
  /// Gets the `ApplicationName` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoeservicesdialog.applicationname?view=office-pia"/>
  public string ApplicationName { get; }
  /// <summary>
  /// Gets the `WebComponent` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoeservicesdialog.webcomponent?view=office-pia"/>
  public object WebComponent { get; }
  /// <summary>
  /// Gets the `ClipArt` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoeservicesdialog.clipart?view=office-pia"/>
  public object ClipArt { get; }
}

