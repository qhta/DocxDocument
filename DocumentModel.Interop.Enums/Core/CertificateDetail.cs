namespace DocumentModel.Interop.Core;

/// <summary>
/// Provides information about the digital certificate.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.certificatedetail?view=office-pia` for Office interop details.
/// </remarks>
public enum CertificateDetail
{
  /// <summary>
  /// Specifies that the digital certificate is available for signing.
  /// </summary>
  Available,
  /// <summary>
  /// The holder of a Private Key corresponding to a Public Key.
  /// </summary>
  Subject,
  /// <summary>
  /// The issuing authority of the certification. certdetExpirationDate3 The expiration date of the certificate.
  /// </summary>
  Issuer,
  /// <summary>
  /// Provides information about the digital certificate.
  /// </summary>
  ExpirationDate,
  /// <summary>
  /// A hash of the certificate's complete contents.
  /// </summary>
  Thumbprint
}
