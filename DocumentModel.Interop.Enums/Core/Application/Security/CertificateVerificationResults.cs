namespace DocumentModel.Interop.Core;

/// <summary>
/// Provides the results of verifying a digital certificate.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.certificateverificationresults?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.CertificateVerificationResults")]
public enum CertificateVerificationResults
{
  /// <summary>
  /// The verification resulted in an error.
  /// </summary>
  [InteropEnumValue("certverresError")]
  Error,
  /// <summary>
  /// The certificate is currently being verified.
  /// </summary>
  [InteropEnumValue("certverresVerifying")]
  Verifying,
  /// <summary>
  /// The certification is currently unverified.
  /// </summary>
  [InteropEnumValue("certverresUnverified")]
  Unverified,
  /// <summary>
  /// The certification is valid.
  /// </summary>
  [InteropEnumValue("certverresValid")]
  Valid,
  /// <summary>
  /// The certification is invalid.
  /// </summary>
  [InteropEnumValue("certverresInvalid")]
  Invalid,
  /// <summary>
  /// The certification has expired.
  /// </summary>
  [InteropEnumValue("certverresExpired")]
  Expired,
  /// <summary>
  /// The certification has been revoked.
  /// </summary>
  [InteropEnumValue("certverresRevoked")]
  Revoked,
  /// <summary>
  /// The certification is from an untrusted source.
  /// </summary>
  [InteropEnumValue("certverresUntrusted")]
  Untrusted
}
