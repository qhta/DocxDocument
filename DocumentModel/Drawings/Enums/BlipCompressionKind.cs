namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Blip Compression Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum BlipCompressionKind
{
  /// <summary>
  ///   IEmail Compression.
  /// </summary>
  IEmail,

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
