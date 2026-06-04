namespace DocumentModel.Interop.Core;

/// <summary>
/// Provides the results of verifying a digital certificate.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.certificateverificationresults?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("CertificateVerificationResults")]
public enum CertificateVerificationResults
{
  /// <summary>
  /// The verification resulted in an error.
  /// </summary>
  [OfficeInteropEnumValue("certverresError")]
  Error,
  /// <summary>
  /// The certificate is currently being verified.
  /// </summary>
  [OfficeInteropEnumValue("certverresVerifying")]
  Verifying,
  /// <summary>
  /// The certification is currently unverified.
  /// </summary>
  [OfficeInteropEnumValue("certverresUnverified")]
  Unverified,
  /// <summary>
  /// The certification is valid.
  /// </summary>
  [OfficeInteropEnumValue("certverresValid")]
  Valid,
  /// <summary>
  /// The certification is invalid.
  /// </summary>
  [OfficeInteropEnumValue("certverresInvalid")]
  Invalid,
  /// <summary>
  /// The certification has expired.
  /// </summary>
  [OfficeInteropEnumValue("certverresExpired")]
  Expired,
  /// <summary>
  /// The certification has been revoked.
  /// </summary>
  [OfficeInteropEnumValue("certverresRevoked")]
  Revoked,
  /// <summary>
  /// The certification is from an untrusted source.
  /// </summary>
  [OfficeInteropEnumValue("certverresUntrusted")]
  Untrusted
}
