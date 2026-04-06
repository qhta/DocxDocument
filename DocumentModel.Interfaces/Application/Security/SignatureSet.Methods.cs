using System.Collections;

namespace DocumentModel.Application;

/// <summary>
/// Represents the `SignatureSet` interface.
/// </summary>
/// <remarks>
/// See `http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureset?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ISignatureSet: IModelObject
{
  /// <summary>
  /// Invokes `Add`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureset.add?view=office-pia"/>
  public ISignature Add();
  /// <summary>
  /// Invokes `Commit`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureset.commit?view=office-pia"/>
  public void Commit();
  /// <summary>
  /// Invokes `AddNonVisibleSignature`.
  /// </summary>
  /// <param name="varSigProv">The `varSigProv` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureset.addnonvisiblesignature?view=office-pia"/>
  public ISignature AddNonVisibleSignature(object varSigProv);
  /// <summary>
  /// Invokes `AddSignatureLine`.
  /// </summary>
  /// <param name="varSigProv">The `varSigProv` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureset.addsignatureline?view=office-pia"/>
  public ISignature AddSignatureLine(object varSigProv);
}

