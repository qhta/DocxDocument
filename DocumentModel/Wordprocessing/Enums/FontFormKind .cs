namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the FontForm enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum FontFormKind
{
  /// <summary>
  ///   Regular IFont.
  /// </summary>
  Regular,

  /// <summary>
  ///   Bold IFont.
  /// </summary>
  Bold,

  /// <summary>
  ///   Italic IFont
  /// </summary>
  Italic,

  /// <summary>
  ///   BoldItalic IFont.
  /// </summary>
  BoldItalic,
}
