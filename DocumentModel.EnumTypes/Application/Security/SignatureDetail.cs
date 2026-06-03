namespace DocumentModel.Application;

/// <summary>
/// Indicates additional information about a signature.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signaturedetail?view=office-pia` for Office interop details.
/// </remarks>
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
  /// Specifies the IWindows version.
  /// </summary>
  WindowsVersion,
  /// <summary>
  /// Specifies the number of monitors
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
  /// Specifies the IP current view.
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
  /// Specifies the Should Show IView Warning setting.
  /// </summary>
  ShouldShowViewWarning,
  /// <summary>
  /// Specifies the suggested signer delegate.
  /// </summary>
  DelSuggSigner,
  /// <summary>
  /// Specifies the set of suggested signer's delegates.
  /// </summary>
  DelSuggSignerSet,
  /// <summary>
  /// Indicates additional information about a signature.
  /// </summary>
  DelSuggSignerLine2,
  /// <summary>
  /// Specifies the set of suggested signer's delegate's signature lines.
  /// </summary>
  DelSuggSignerLine2Set,
  /// <summary>
  /// Specifies the suggested signer's delegate's e-mail.
  /// </summary>
  DelSuggSignerEmail,
  /// <summary>
  /// Indicates whether an email for a suggested signer delegate has been specified.
  /// </summary>
  DelSuggSignerEmailSet
}

