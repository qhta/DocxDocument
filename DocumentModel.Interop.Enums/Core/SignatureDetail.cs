namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates additional information about a signature.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signaturedetail?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.SignatureDetail))]
public enum SignatureDetail
{
  /// <summary>
  /// Specifies the local signing time.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.SignatureDetail.sigdetLocalSigningTime))]
  LocalSigningTime,
  /// <summary>
  /// Specifies the application name.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.SignatureDetail.sigdetApplicationName))]
  ApplicationName,
  /// <summary>
  /// Specifies the application version.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.SignatureDetail.sigdetApplicationVersion))]
  ApplicationVersion,
  /// <summary>
  /// Specifies the Office version.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.SignatureDetail.sigdetOfficeVersion))]
  OfficeVersion,
  /// <summary>
  /// Specifies the Windows version.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.SignatureDetail.sigdetWindowsVersion))]
  WindowsVersion,
  /// <summary>
  /// Specifies the number of monitors
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.SignatureDetail.sigdetNumberOfMonitors))]
  NumberOfMonitors,
  /// <summary>
  /// Specifies the horizontal resolution.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.SignatureDetail.sigdetHorizResolution))]
  HorizResolution,
  /// <summary>
  /// Specifies the vertical resolution.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.SignatureDetail.sigdetVertResolution))]
  VertResolution,
  /// <summary>
  /// Specifies the color depth.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.SignatureDetail.sigdetColorDepth))]
  ColorDepth,
  /// <summary>
  /// Specifies the signed data.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.SignatureDetail.sigdetSignedData))]
  SignedData,
  /// <summary>
  /// Specifies the document preview image.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.SignatureDetail.sigdetDocPreviewImg))]
  DocPreviewImg,
  /// <summary>
  /// Specifies the IP form hash.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.SignatureDetail.sigdetIPFormHash))]
  IPFormHash,
  /// <summary>
  /// Specifies the IP current view.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.SignatureDetail.sigdetIPCurrentView))]
  IPCurrentView,
  /// <summary>
  /// Specifies the signature type.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.SignatureDetail.sigdetSignatureType))]
  SignatureType,
  /// <summary>
  /// Specifies the hash algorithm.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.SignatureDetail.sigdetHashAlgorithm))]
  HashAlgorithm,
  /// <summary>
  /// Specifies the Should Show View Warning setting.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.SignatureDetail.sigdetShouldShowViewWarning))]
  ShouldShowViewWarning,
  /// <summary>
  /// Specifies the suggested signer delegate.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.SignatureDetail.sigdetDelSuggSigner))]
  DelSuggSigner,
  /// <summary>
  /// Specifies the set of suggested signer's delegates.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.SignatureDetail.sigdetDelSuggSignerSet))]
  DelSuggSignerSet,
  /// <summary>
  /// Indicates additional information about a signature.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.SignatureDetail.sigdetDelSuggSignerLine2))]
  DelSuggSignerLine2,
  /// <summary>
  /// Specifies the set of suggested signer's delegate's signature lines.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.SignatureDetail.sigdetDelSuggSignerLine2Set))]
  DelSuggSignerLine2Set,
  /// <summary>
  /// Specifies the suggested signer's delegate's e-mail.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.SignatureDetail.sigdetDelSuggSignerEmail))]
  DelSuggSignerEmail,
  /// <summary>
  /// Indicates whether an email for a suggested signer delegate has been specified.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.SignatureDetail.sigdetDelSuggSignerEmailSet))]
  DelSuggSignerEmailSet
}
