namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates the signature line image.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signaturelineimage?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.SignatureLineImage")]
public enum SignatureLineImage
{
  /// <summary>
  /// The SoftwareRequired image.
  /// </summary>
  [InteropEnumValue("siglnimgSoftwareRequired")]
  SoftwareRequired,
  /// <summary>
  /// The Unsigned image.
  /// </summary>
  [InteropEnumValue("siglnimgUnsigned")]
  Unsigned,
  /// <summary>
  /// The SignedValid image.
  /// </summary>
  [InteropEnumValue("siglnimgSignedValid")]
  SignedValid,
  /// <summary>
  /// The SignedInvalid image.
  /// </summary>
  [InteropEnumValue("siglnimgSignedInvalid")]
  SignedInvalid,
  /// <summary>
  /// No description is available.
  /// </summary>
  [InteropEnumValue("siglnimgSigned")]
  Signed
}
