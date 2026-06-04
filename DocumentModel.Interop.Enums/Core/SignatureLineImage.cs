namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates the signature line image.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signaturelineimage?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("SignatureLineImage")]
public enum SignatureLineImage
{
  /// <summary>
  /// The SoftwareRequired image.
  /// </summary>
  [OfficeInteropEnumValue("siglnimgSoftwareRequired")]
  SoftwareRequired,
  /// <summary>
  /// The Unsigned image.
  /// </summary>
  [OfficeInteropEnumValue("siglnimgUnsigned")]
  Unsigned,
  /// <summary>
  /// The SignedValid image.
  /// </summary>
  [OfficeInteropEnumValue("siglnimgSignedValid")]
  SignedValid,
  /// <summary>
  /// The SignedInvalid image.
  /// </summary>
  [OfficeInteropEnumValue("siglnimgSignedInvalid")]
  SignedInvalid,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue("siglnimgSigned")]
  Signed
}
