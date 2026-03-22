namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates additional information about a signature.
/// </summary>
public enum SignatureDetail
{
  /// <summary>
  /// Specifies the local signing time.
  /// </summary>
  sigdetLocalSigningTime,
  /// <summary>
  /// Specifies the application name.
  /// </summary>
  sigdetApplicationName,
  /// <summary>
  /// Specifies the application version.
  /// </summary>
  sigdetApplicationVersion,
  /// <summary>
  /// Specifies the Office version.
  /// </summary>
  sigdetOfficeVersion,
  /// <summary>
  /// Specifies the Windows version. sigdetNumberOfMonitors5 Specifies the number of monitors
  /// </summary>
  sigdetWindowsVersion,
  /// <summary>
  /// Indicates additional information about a signature.
  /// </summary>
  sigdetNumberOfMonitors,
  /// <summary>
  /// Specifies the horizontal resolution.
  /// </summary>
  sigdetHorizResolution,
  /// <summary>
  /// Specifies the vertical resolution.
  /// </summary>
  sigdetVertResolution,
  /// <summary>
  /// Specifies the color depth.
  /// </summary>
  sigdetColorDepth,
  /// <summary>
  /// Specifies the signed data.
  /// </summary>
  sigdetSignedData,
  /// <summary>
  /// Specifies the document preview image.
  /// </summary>
  sigdetDocPreviewImg,
  /// <summary>
  /// Specifies the IP form hash.
  /// </summary>
  sigdetIPFormHash,
  /// <summary>
  /// Specifies the IP current view. public enum class SignatureDetail ﾉ Expand table
  /// </summary>
  sigdetIPCurrentView,
  /// <summary>
  /// Specifies the signature type.
  /// </summary>
  sigdetSignatureType,
  /// <summary>
  /// Specifies the hash algorithm.
  /// </summary>
  sigdetHashAlgorithm,
  /// <summary>
  /// Specifies the Should Show View Warning setting.
  /// </summary>
  sigdetShouldShowViewWarning,
  /// <summary>
  /// Specifies the suggested signer delegate.
  /// </summary>
  sigdetDelSuggSigner,
  /// <summary>
  /// Specifies the set of suggested signer's delegates. sigdetDelSuggSignerLine218 Specifies the suggested signer's
  /// delegate's signature line. sigdetDelSuggSignerLine2Set19 Specifies the set of suggested signer's delegate's
  /// signature lines. sigdetDelSuggSignerEmail20 Specifies the suggested signer's delegate's e-mail.
  /// sigdetDelSuggSignerEmailSet21 Indicates whether an email for a suggested signer delegate has been specified.
  /// </summary>
  sigdetDelSuggSignerSet,
  /// <summary>
  /// Indicates additional information about a signature.
  /// </summary>
  sigdetDelSuggSignerLine2,
  /// <summary>
  /// Indicates additional information about a signature.
  /// </summary>
  sigdetDelSuggSignerLine2Set,
  /// <summary>
  /// Indicates additional information about a signature.
  /// </summary>
  sigdetDelSuggSignerEmail,
  /// <summary>
  /// Indicates additional information about a signature.
  /// </summary>
  sigdetDelSuggSignerEmailSet
}
