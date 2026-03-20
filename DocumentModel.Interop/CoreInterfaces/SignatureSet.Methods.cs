using System.Collections;

namespace DocumentModel.Interop.Core;

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
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureset.add?view=office-pia
  /// </remarks>
  public Signature Add();
  /// <summary>
  /// Invokes `Commit`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureset.commit?view=office-pia
  /// </remarks>
  public void Commit();
  /// <summary>
  /// Invokes `AddNonVisibleSignature`.
  /// </summary>
  /// <param name="varSigProv">The `varSigProv` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureset.addnonvisiblesignature?view=office-pia
  /// </remarks>
  public Signature AddNonVisibleSignature(object varSigProv);
  /// <summary>
  /// Invokes `AddSignatureLine`.
  /// </summary>
  /// <param name="varSigProv">The `varSigProv` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureset.addsignatureline?view=office-pia
  /// </remarks>
  public Signature AddSignatureLine(object varSigProv);
}
