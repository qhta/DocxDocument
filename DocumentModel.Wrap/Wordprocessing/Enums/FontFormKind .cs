namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the FontForm enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum FontFormKind
{
  /// <summary>
  ///   Regular Font.
  /// </summary>
  Regular,

  /// <summary>
  ///   Bold Font.
  /// </summary>
  Bold,

  /// <summary>
  ///   Italic Font
  /// </summary>
  Italic,

  /// <summary>
  ///   BoldItalic Font.
  /// </summary>
  BoldItalic,
}