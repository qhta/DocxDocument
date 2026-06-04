namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates additional information about a signature.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signaturedetail?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.SignatureDetail")]
public enum SignatureDetail
{
  /// <summary>
  /// Specifies the local signing time.
  /// </summary>
  [InteropEnumValue("sigdetLocalSigningTime")]
  LocalSigningTime,
  /// <summary>
  /// Specifies the application name.
  /// </summary>
  [InteropEnumValue("sigdetApplicationName")]
  ApplicationName,
  /// <summary>
  /// Specifies the application version.
  /// </summary>
  [InteropEnumValue("sigdetApplicationVersion")]
  ApplicationVersion,
  /// <summary>
  /// Specifies the Office version.
  /// </summary>
  [InteropEnumValue("sigdetOfficeVersion")]
  OfficeVersion,
  /// <summary>
  /// Specifies the Windows version.
  /// </summary>
  [InteropEnumValue("sigdetWindowsVersion")]
  WindowsVersion,
  /// <summary>
  /// Specifies the number of monitors
  /// </summary>
  [InteropEnumValue("sigdetNumberOfMonitors")]
  NumberOfMonitors,
  /// <summary>
  /// Specifies the horizontal resolution.
  /// </summary>
  [InteropEnumValue("sigdetHorizResolution")]
  HorizResolution,
  /// <summary>
  /// Specifies the vertical resolution.
  /// </summary>
  [InteropEnumValue("sigdetVertResolution")]
  VertResolution,
  /// <summary>
  /// Specifies the color depth.
  /// </summary>
  [InteropEnumValue("sigdetColorDepth")]
  ColorDepth,
  /// <summary>
  /// Specifies the signed data.
  /// </summary>
  [InteropEnumValue("sigdetSignedData")]
  SignedData,
  /// <summary>
  /// Specifies the document preview image.
  /// </summary>
  [InteropEnumValue("sigdetDocPreviewImg")]
  DocPreviewImg,
  /// <summary>
  /// Specifies the IP form hash.
  /// </summary>
  [InteropEnumValue("sigdetIPFormHash")]
  IPFormHash,
  /// <summary>
  /// Specifies the IP current view.
  /// </summary>
  [InteropEnumValue("sigdetIPCurrentView")]
  IPCurrentView,
  /// <summary>
  /// Specifies the signature type.
  /// </summary>
  [InteropEnumValue("sigdetSignatureType")]
  SignatureType,
  /// <summary>
  /// Specifies the hash algorithm.
  /// </summary>
  [InteropEnumValue("sigdetHashAlgorithm")]
  HashAlgorithm,
  /// <summary>
  /// Specifies the Should Show View Warning setting.
  /// </summary>
  [InteropEnumValue("sigdetShouldShowViewWarning")]
  ShouldShowViewWarning,
  /// <summary>
  /// Specifies the suggested signer delegate.
  /// </summary>
  [InteropEnumValue("sigdetDelSuggSigner")]
  DelSuggSigner,
  /// <summary>
  /// Specifies the set of suggested signer's delegates.
  /// </summary>
  [InteropEnumValue("sigdetDelSuggSignerSet")]
  DelSuggSignerSet,
  /// <summary>
  /// Indicates additional information about a signature.
  /// </summary>
  [InteropEnumValue("sigdetDelSuggSignerLine2")]
  DelSuggSignerLine2,
  /// <summary>
  /// Specifies the set of suggested signer's delegate's signature lines.
  /// </summary>
  [InteropEnumValue("sigdetDelSuggSignerLine2Set")]
  DelSuggSignerLine2Set,
  /// <summary>
  /// Specifies the suggested signer's delegate's e-mail.
  /// </summary>
  [InteropEnumValue("sigdetDelSuggSignerEmail")]
  DelSuggSignerEmail,
  /// <summary>
  /// Indicates whether an email for a suggested signer delegate has been specified.
  /// </summary>
  [InteropEnumValue("sigdetDelSuggSignerEmailSet")]
  DelSuggSignerEmailSet
}
