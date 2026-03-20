
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoeservicesdialog?view=office-pia
/// </remarks>
public partial interface IMsoEServicesDialog
{
  /// <summary>
  /// Gets the `ApplicationName` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoeservicesdialog.applicationname?view=office-pia
  /// </remarks>
  public string ApplicationName { get; }
  /// <summary>
  /// Gets the `WebComponent` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoeservicesdialog.webcomponent?view=office-pia
  /// </remarks>
  public object WebComponent { get; }
  /// <summary>
  /// Gets the `ClipArt` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoeservicesdialog.clipart?view=office-pia
  /// </remarks>
  public object ClipArt { get; }
}
