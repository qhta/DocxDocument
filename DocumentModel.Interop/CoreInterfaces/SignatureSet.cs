using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SignatureSet` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureset?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ISignatureSet: IInteropCollection<Signature>
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


  #region methods

/// <summary>
  /// Invokes `Add`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureset.add?view=office-pia"/>
  public Signature Add();
  /// <summary>
  /// Invokes `Commit`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureset.commit?view=office-pia"/>
  public void Commit();
  /// <summary>
  /// Invokes `AddNonVisibleSignature`.
  /// </summary>
  /// <param name="varSigProv">The `varSigProv` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureset.addnonvisiblesignature?view=office-pia"/>
  public Signature AddNonVisibleSignature(object varSigProv);
  /// <summary>
  /// Invokes `AddSignatureLine`.
  /// </summary>
  /// <param name="varSigProv">The `varSigProv` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureset.addsignatureline?view=office-pia"/>
  public Signature AddSignatureLine(object varSigProv);

  #endregion methods
}

