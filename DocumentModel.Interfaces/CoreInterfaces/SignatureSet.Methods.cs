using System.Collections;

namespace DocumentModel.Interfaces;

/// <summary>
/// Represents the `SignatureSet` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureset?view=office-pia` for Office interop details.
/// </remarks>
public partial interface SignatureSet
{
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
}

