namespace DocumentModel.Interop.Core;

/// <summary>
/// Provides the results of verifying a digital certificate.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.certificateverificationresults?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.CertificateVerificationResults))]
public enum CertificateVerificationResults
{
  /// <summary>
  /// The verification resulted in an error.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.CertificateVerificationResults.certverresError))]
  Error,
  /// <summary>
  /// The certificate is currently being verified.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.CertificateVerificationResults.certverresVerifying))]
  Verifying,
  /// <summary>
  /// The certification is currently unverified.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.CertificateVerificationResults.certverresUnverified))]
  Unverified,
  /// <summary>
  /// The certification is valid.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.CertificateVerificationResults.certverresValid))]
  Valid,
  /// <summary>
  /// The certification is invalid.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.CertificateVerificationResults.certverresInvalid))]
  Invalid,
  /// <summary>
  /// The certification has expired.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.CertificateVerificationResults.certverresExpired))]
  Expired,
  /// <summary>
  /// The certification has been revoked.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.CertificateVerificationResults.certverresRevoked))]
  Revoked,
  /// <summary>
  /// The certification is from an untrusted source.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.CertificateVerificationResults.certverresUntrusted))]
  Untrusted
}
