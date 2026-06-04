namespace DocumentModel.Interop.Core;

/// <summary>
/// Provides information about the digital certificate.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.certificatedetail?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("CertificateDetail")]
public enum CertificateDetail
{
  /// <summary>
  /// Specifies that the digital certificate is available for signing.
  /// </summary>
  [OfficeInteropEnumValue("certdetAvailable")]
  Available,
  /// <summary>
  /// The holder of a Private Key corresponding to a Public Key.
  /// </summary>
  [OfficeInteropEnumValue("certdetSubject")]
  Subject,
  /// <summary>
  /// The issuing authority of the certification.
  /// </summary>
  [OfficeInteropEnumValue("certdetIssuer")]
  Issuer,
  /// <summary>
  /// The expiration date of the certificate.
  /// </summary>
  [OfficeInteropEnumValue("certdetExpirationDate")]
  ExpirationDate,
  /// <summary>
  /// A hash of the certificate's complete contents.
  /// </summary>
  [OfficeInteropEnumValue("certdetThumbprint")]
  Thumbprint
}
