namespace DocumentModel.Interop.Core;

/// <summary>
/// Provides information about the digital certificate.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.certificatedetail?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.CertificateDetail))]
public enum CertificateDetail
{
  /// <summary>
  /// Specifies that the digital certificate is available for signing.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.CertificateDetail.certdetAvailable))]
  Available,
  /// <summary>
  /// The holder of a Private Key corresponding to a Public Key.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.CertificateDetail.certdetSubject))]
  Subject,
  /// <summary>
  /// The issuing authority of the certification.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.CertificateDetail.certdetIssuer))]
  Issuer,
  /// <summary>
  /// The expiration date of the certificate.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.CertificateDetail.certdetExpirationDate))]
  ExpirationDate,
  /// <summary>
  /// A hash of the certificate's complete contents.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.CertificateDetail.certdetThumbprint))]
  Thumbprint
}
