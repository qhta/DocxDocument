namespace DocumentModel.Interop.Core;

/// <summary>
/// Indicates additional information about a signature.
/// </summary>
public enum SignatureDetail
{
  /// <summary>
  /// Specifies the local signing time.
  /// </summary>
  LocalSigningTime,
  /// <summary>
  /// Specifies the application name.
  /// </summary>
  ApplicationName,
  /// <summary>
  /// Specifies the application version.
  /// </summary>
  ApplicationVersion,
  /// <summary>
  /// Specifies the Office version.
  /// </summary>
  OfficeVersion,
  /// <summary>
  /// Specifies the Windows version. sigdetNumberOfMonitors5 Specifies the number of monitors
  /// </summary>
  WindowsVersion,
  /// <summary>
  /// Indicates additional information about a signature.
  /// </summary>
  NumberOfMonitors,
  /// <summary>
  /// Specifies the horizontal resolution.
  /// </summary>
  HorizResolution,
  /// <summary>
  /// Specifies the vertical resolution.
  /// </summary>
  VertResolution,
  /// <summary>
  /// Specifies the color depth.
  /// </summary>
  ColorDepth,
  /// <summary>
  /// Specifies the signed data.
  /// </summary>
  SignedData,
  /// <summary>
  /// Specifies the document preview image.
  /// </summary>
  DocPreviewImg,
  /// <summary>
  /// Specifies the IP form hash.
  /// </summary>
  IPFormHash,
  /// <summary>
  /// Specifies the IP current view. public enum class SignatureDetail ﾉ Expand table
  /// </summary>
  IPCurrentView,
  /// <summary>
  /// Specifies the signature type.
  /// </summary>
  SignatureType,
  /// <summary>
  /// Specifies the hash algorithm.
  /// </summary>
  HashAlgorithm,
  /// <summary>
  /// Specifies the Should Show View Warning setting.
  /// </summary>
  ShouldShowViewWarning,
  /// <summary>
  /// Specifies the suggested signer delegate.
  /// </summary>
  DelSuggSigner,
  /// <summary>
  /// Specifies the set of suggested signer's delegates. sigdetDelSuggSignerLine218 Specifies the suggested signer's
  /// delegate's signature line. sigdetDelSuggSignerLine2Set19 Specifies the set of suggested signer's delegate's
  /// signature lines. sigdetDelSuggSignerEmail20 Specifies the suggested signer's delegate's e-mail.
  /// sigdetDelSuggSignerEmailSet21 Indicates whether an email for a suggested signer delegate has been specified.
  /// </summary>
  DelSuggSignerSet,
  /// <summary>
  /// Indicates additional information about a signature.
  /// </summary>
  DelSuggSignerLine2,
  /// <summary>
  /// Indicates additional information about a signature.
  /// </summary>
  DelSuggSignerLine2Set,
  /// <summary>
  /// Indicates additional information about a signature.
  /// </summary>
  DelSuggSignerEmail,
  /// <summary>
  /// Indicates additional information about a signature.
  /// </summary>
  DelSuggSignerEmailSet
}
