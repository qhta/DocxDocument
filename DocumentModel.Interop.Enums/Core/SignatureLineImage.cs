namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates the signature line image.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signaturelineimage?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.SignatureLineImage))]
public enum SignatureLineImage
{
  /// <summary>
  /// The SoftwareRequired image.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.SignatureLineImage.siglnimgSoftwareRequired))]
  SoftwareRequired,
  /// <summary>
  /// The Unsigned image.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.SignatureLineImage.siglnimgUnsigned))]
  Unsigned,
  /// <summary>
  /// The SignedValid image.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.SignatureLineImage.siglnimgSignedValid))]
  SignedValid,
  /// <summary>
  /// The SignedInvalid image.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.SignatureLineImage.siglnimgSignedInvalid))]
  SignedInvalid,
  /// <summary>
  /// No description is available.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.SignatureLineImage.siglnimgSigned))]
  Signed
}
