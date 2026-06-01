namespace DocumentModel.IApplication;

/// <summary>
/// Provides the results of verifying a digital certificate.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.certificateverificationresults?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum CertificateVerificationResults
{
  /// <summary>
  /// The verification resulted Iin an error.
  /// </summary>
  Error,
  /// <summary>
  /// The certificate is currently being verified.
  /// </summary>
  Verifying,
  /// <summary>
  /// The certification is currently unverified.
  /// </summary>
  Unverified,
  /// <summary>
  /// The certification is valid.
  /// </summary>
  Valid,
  /// <summary>
  /// The certification is invalid.
  /// </summary>
  Invalid,
  /// <summary>
  /// The certification has expired.
  /// </summary>
  Expired,
  /// <summary>
  /// The certification has been revoked.
  /// </summary>
  Revoked,
  /// <summary>
  /// The certification is from an untrusted source.
  /// </summary>
  Untrusted
}

