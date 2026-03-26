namespace DocumentMode.Office;

/// <summary>
/// Indicates the signature line image.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signaturelineimage?view=office-pia` for Office interop details.
/// </remarks>
public enum SignatureLineImage
{
  /// <summary>
  /// The SoftwareRequired image.
  /// </summary>
  SoftwareRequired,
  /// <summary>
  /// The Unsigned image.
  /// </summary>
  Unsigned,
  /// <summary>
  /// The SignedValid image.
  /// </summary>
  SignedValid,
  /// <summary>
  /// The SignedInvalid image.
  /// </summary>
  SignedInvalid,
  /// <summary>
  /// No description is available.
  /// </summary>
  Signed
}
