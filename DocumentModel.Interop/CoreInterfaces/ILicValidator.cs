
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicvalidator?view=office-pia
/// </remarks>
public partial interface ILicValidator
{
  /// <summary>
  /// Gets the products collection used by the licensing validator.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicvalidator.products?view=office-pia
  /// </remarks>
  public object Products { get; }
  /// <summary>
  /// Gets or sets the selected product index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicvalidator.selection?view=office-pia
  /// </remarks>
  public int Selection { get; set; }
}
