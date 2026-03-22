namespace DocumentModel.Interop.Core;

/// <summary>
/// Provides information about the digital certificate.
/// </summary>
public enum CertificateDetail
{
  /// <summary>
  /// Specifies that the digital certificate is available for signing.
  /// </summary>
  certdetAvailable,
  /// <summary>
  /// The holder of a Private Key corresponding to a Public Key.
  /// </summary>
  certdetSubject,
  /// <summary>
  /// The issuing authority of the certification. certdetExpirationDate3 The expiration date of the certificate.
  /// </summary>
  certdetIssuer,
  /// <summary>
  /// Provides information about the digital certificate.
  /// </summary>
  certdetExpirationDate,
  /// <summary>
  /// A hash of the certificate's complete contents.
  /// </summary>
  certdetThumbprint
}
