namespace DocumentModel.Interop.Core;

/// <summary>
/// Provides the results of verifying a digital certificate.
/// </summary>
public enum CertificateVerificationResults
{
  /// <summary>
  /// The verification resulted in an error.
  /// </summary>
  certverresError,
  /// <summary>
  /// The certificate is currently being verified.
  /// </summary>
  certverresVerifying,
  /// <summary>
  /// The certification is currently unverified.
  /// </summary>
  certverresUnverified,
  /// <summary>
  /// The certification is valid.
  /// </summary>
  certverresValid,
  /// <summary>
  /// The certification is invalid.
  /// </summary>
  certverresInvalid,
  /// <summary>
  /// The certification has expired.
  /// </summary>
  certverresExpired,
  /// <summary>
  /// The certification has been revoked.
  /// </summary>
  certverresRevoked,
  /// <summary>
  /// The certification is from an untrusted source.
  /// </summary>
  certverresUntrusted
}
