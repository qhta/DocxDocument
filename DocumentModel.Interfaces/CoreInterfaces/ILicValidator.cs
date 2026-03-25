
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicvalidator?view=office-pia"/>
public partial interface ILicValidator
{
  /// <summary>
  /// Gets the products collection used by the licensing validator.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicvalidator.products?view=office-pia"/>
  public object Products { get; }
  /// <summary>
  /// Gets or sets the selected product index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.ilicvalidator.selection?view=office-pia"/>
  public int Selection { get; set; }
}

