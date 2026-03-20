
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SignatureInfo` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureinfo?view=office-pia` for Office interop details.
/// </remarks>
public partial interface SignatureInfo: InteropObject
{
  /// <summary>
  /// Gets or sets the `ReadOnly` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureinfo.readonly?view=office-pia
  /// </remarks>
  public bool ReadOnly { get; }
  /// <summary>
  /// Gets the `SignatureProvider` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureinfo.signatureprovider?view=office-pia
  /// </remarks>
  public string SignatureProvider { get; }
  /// <summary>
  /// Gets or sets the `SignatureText` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureinfo.signaturetext?view=office-pia
  /// </remarks>
  public string SignatureText { get; set; }
  /// <summary>
  /// Gets or sets the `SignatureImage` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureinfo.signatureimage?view=office-pia
  /// </remarks>
  public object SignatureImage { get; set; }
  /// <summary>
  /// Gets or sets the `SignatureComment` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureinfo.signaturecomment?view=office-pia
  /// </remarks>
  public string SignatureComment { get; set; }
  /// <summary>
  /// Gets the `ContentVerificationResults` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureinfo.contentverificationresults?view=office-pia
  /// </remarks>
  public ContentVerificationResults ContentVerificationResults { get; }
  /// <summary>
  /// Gets the `CertificateVerificationResults` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureinfo.certificateverificationresults?view=office-pia
  /// </remarks>
  public CertificateVerificationResults CertificateVerificationResults { get; }
  /// <summary>
  /// Gets the `IsValid` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureinfo.isvalid?view=office-pia
  /// </remarks>
  public bool IsValid { get; }
  /// <summary>
  /// Gets the `IsCertificateExpired` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureinfo.iscertificateexpired?view=office-pia
  /// </remarks>
  public bool IsCertificateExpired { get; }
  /// <summary>
  /// Gets the `IsCertificateRevoked` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureinfo.iscertificaterevoked?view=office-pia
  /// </remarks>
  public bool IsCertificateRevoked { get; }
  /// <summary>
  /// Gets the `IsCertificateUntrusted` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signatureinfo.iscertificateuntrusted?view=office-pia
  /// </remarks>
  public bool IsCertificateUntrusted { get; }
}
