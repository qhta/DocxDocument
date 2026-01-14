namespace DocumentModel.Drawings;

/// <summary>
///   Blip Compression Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum BlipCompressionKind
{
  /// <summary>
  ///   Email Compression.
  /// </summary>
  Email,
  /// <summary>
  ///   Screen Viewing Compression.
  /// </summary>
  Screen,
  /// <summary>
  ///   Printing Compression.
  /// </summary>
  Print,
  /// <summary>
  ///   High Quality Printing Compression.
  /// </summary>
  HighQualityPrint,
  /// <summary>
  ///   No Compression.
  /// </summary>
  None
}