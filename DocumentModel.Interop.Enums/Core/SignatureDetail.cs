namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates additional information about a signature.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signaturedetail?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("SignatureDetail")]
public enum SignatureDetail
{
  /// <summary>
  /// Specifies the local signing time.
  /// </summary>
  [OfficeInteropEnumValue("sigdetLocalSigningTime")]
  LocalSigningTime,
  /// <summary>
  /// Specifies the application name.
  /// </summary>
  [OfficeInteropEnumValue("sigdetApplicationName")]
  ApplicationName,
  /// <summary>
  /// Specifies the application version.
  /// </summary>
  [OfficeInteropEnumValue("sigdetApplicationVersion")]
  ApplicationVersion,
  /// <summary>
  /// Specifies the Office version.
  /// </summary>
  [OfficeInteropEnumValue("sigdetOfficeVersion")]
  OfficeVersion,
  /// <summary>
  /// Specifies the Windows version.
  /// </summary>
  [OfficeInteropEnumValue("sigdetWindowsVersion")]
  WindowsVersion,
  /// <summary>
  /// Specifies the number of monitors
  /// </summary>
  [OfficeInteropEnumValue("sigdetNumberOfMonitors")]
  NumberOfMonitors,
  /// <summary>
  /// Specifies the horizontal resolution.
  /// </summary>
  [OfficeInteropEnumValue("sigdetHorizResolution")]
  HorizResolution,
  /// <summary>
  /// Specifies the vertical resolution.
  /// </summary>
  [OfficeInteropEnumValue("sigdetVertResolution")]
  VertResolution,
  /// <summary>
  /// Specifies the color depth.
  /// </summary>
  [OfficeInteropEnumValue("sigdetColorDepth")]
  ColorDepth,
  /// <summary>
  /// Specifies the signed data.
  /// </summary>
  [OfficeInteropEnumValue("sigdetSignedData")]
  SignedData,
  /// <summary>
  /// Specifies the document preview image.
  /// </summary>
  [OfficeInteropEnumValue("sigdetDocPreviewImg")]
  DocPreviewImg,
  /// <summary>
  /// Specifies the IP form hash.
  /// </summary>
  [OfficeInteropEnumValue("sigdetIPFormHash")]
  IPFormHash,
  /// <summary>
  /// Specifies the IP current view.
  /// </summary>
  [OfficeInteropEnumValue("sigdetIPCurrentView")]
  IPCurrentView,
  /// <summary>
  /// Specifies the signature type.
  /// </summary>
  [OfficeInteropEnumValue("sigdetSignatureType")]
  SignatureType,
  /// <summary>
  /// Specifies the hash algorithm.
  /// </summary>
  [OfficeInteropEnumValue("sigdetHashAlgorithm")]
  HashAlgorithm,
  /// <summary>
  /// Specifies the Should Show View Warning setting.
  /// </summary>
  [OfficeInteropEnumValue("sigdetShouldShowViewWarning")]
  ShouldShowViewWarning,
  /// <summary>
  /// Specifies the suggested signer delegate.
  /// </summary>
  [OfficeInteropEnumValue("sigdetDelSuggSigner")]
  DelSuggSigner,
  /// <summary>
  /// Specifies the set of suggested signer's delegates.
  /// </summary>
  [OfficeInteropEnumValue("sigdetDelSuggSignerSet")]
  DelSuggSignerSet,
  /// <summary>
  /// Indicates additional information about a signature.
  /// </summary>
  [OfficeInteropEnumValue("sigdetDelSuggSignerLine2")]
  DelSuggSignerLine2,
  /// <summary>
  /// Specifies the set of suggested signer's delegate's signature lines.
  /// </summary>
  [OfficeInteropEnumValue("sigdetDelSuggSignerLine2Set")]
  DelSuggSignerLine2Set,
  /// <summary>
  /// Specifies the suggested signer's delegate's e-mail.
  /// </summary>
  [OfficeInteropEnumValue("sigdetDelSuggSignerEmail")]
  DelSuggSignerEmail,
  /// <summary>
  /// Indicates whether an email for a suggested signer delegate has been specified.
  /// </summary>
  [OfficeInteropEnumValue("sigdetDelSuggSignerEmailSet")]
  DelSuggSignerEmailSet
}
