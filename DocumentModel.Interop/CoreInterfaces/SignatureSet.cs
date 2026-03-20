using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SignatureSet` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureset?view=office-pia` for Office interop details.
/// </remarks>
public partial interface SignatureSet: InteropCollection<Signature>
{
  /// <summary>
  /// Gets or sets the `CanAddSignatureLine` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureset.canaddsignatureline?view=office-pia
  /// </remarks>
  public bool CanAddSignatureLine { get; }
  /// <summary>
  /// Gets or sets the `Subset` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureset.subset?view=office-pia
  /// </remarks>
  public MsoSignatureSubset Subset { get; set; }
  public bool ShowSignaturesPane { set; }
}
