using System.Collections;

namespace DocumentModel.Application;

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
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureset.canaddsignatureline?view=office-pia"/>
  public bool CanAddSignatureLine { get; }
  /// <summary>
  /// Gets or sets the `Subset` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureset.subset?view=office-pia"/>
  public SignatureSubset Subset { get; set; }
  /// <summary>
  /// Sets the `ShowSignaturesPane` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureset.showsignaturespane?view=office-pia"/>
  public bool ShowSignaturesPane { set; }
}

