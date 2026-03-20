
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `ILicValidator` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicvalidator?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ILicValidator
{
  /// <summary>
  /// Gets or sets the `Products` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicvalidator.products?view=office-pia
  /// </remarks>
  public object Products { get; }
  /// <summary>
  /// Gets or sets the `Selection` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicvalidator.selection?view=office-pia
  /// </remarks>
  public int Selection { get; set; }
}
