
namespace DocumentModel.Application;

/// <summary>
/// Represents the `SignatureInfo` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureinfo?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ISignatureInfo: IModelObject
{
  /// <summary>
  /// Gets the `ReadOnly` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureinfo.readonly?view=office-pia"/>
  public bool ReadOnly { get; }
  /// <summary>
  /// Gets the `SignatureProvider` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureinfo.signatureprovider?view=office-pia"/>
  public string SignatureProvider { get; }
  /// <summary>
  /// Gets or sets the `SignatureText` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureinfo.signaturetext?view=office-pia"/>
  public string SignatureText { get; set; }
  /// <summary>
  /// Gets or sets the `SignatureImage` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureinfo.signatureimage?view=office-pia"/>
  public object SignatureImage { get; set; }
  /// <summary>
  /// Gets or sets the `SignatureComment` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureinfo.signaturecomment?view=office-pia"/>
  public string SignatureComment { get; set; }
  /// <summary>
  /// Gets the `ContentVerificationResults` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureinfo.contentverificationresults?view=office-pia"/>
  public ContentVerificationResults ContentVerificationResults { get; }
  /// <summary>
  /// Gets the `CertificateVerificationResults` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureinfo.certificateverificationresults?view=office-pia"/>
  public CertificateVerificationResults CertificateVerificationResults { get; }
  /// <summary>
  /// Gets the `IsValid` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureinfo.isvalid?view=office-pia"/>
  public bool IsValid { get; }
  /// <summary>
  /// Gets the `IsCertificateExpired` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureinfo.iscertificateexpired?view=office-pia"/>
  public bool IsCertificateExpired { get; }
  /// <summary>
  /// Gets the `IsCertificateRevoked` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureinfo.iscertificaterevoked?view=office-pia"/>
  public bool IsCertificateRevoked { get; }
  /// <summary>
  /// Gets the `IsCertificateUntrusted` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureinfo.iscertificateuntrusted?view=office-pia"/>
  public bool IsCertificateUntrusted { get; }
}

