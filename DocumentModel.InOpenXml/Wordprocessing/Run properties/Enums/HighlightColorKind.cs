namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the HighlightColorValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum HighlightColorKind
{
  /// <summary>
  ///   Black Highlighting Color.
  /// </summary>
  Black,
  /// <summary>
  ///   Blue Highlighting Color.
  /// </summary>
  Blue,
  /// <summary>
  ///   Cyan Highlighting Color.
  /// </summary>
  Cyan,
  /// <summary>
  ///   Green Highlighting Color.
  /// </summary>
  Green,
  /// <summary>
  ///   Magenta Highlighting Color.
  /// </summary>
  Magenta,
  /// <summary>
  ///   Red Highlighting Color.
  /// </summary>
  Red,
  /// <summary>
  ///   Yellow Highlighting Color.
  /// </summary>
  Yellow,
  /// <summary>
  ///   White Highlighting Color.
  /// </summary>
  White,
  /// <summary>
  ///   Dark Blue Highlighting Color.
  /// </summary>
  DarkBlue,
  /// <summary>
  ///   Dark Cyan Highlighting Color.
  /// </summary>
  DarkCyan,
  /// <summary>
  ///   Dark Green Highlighting Color.
  /// </summary>
  DarkGreen,
  /// <summary>
  ///   Dark Magenta Highlighting Color.
  /// </summary>
  DarkMagenta,
  /// <summary>
  ///   Dark Red Highlighting Color.
  /// </summary>
  DarkRed,
  /// <summary>
  ///   Dark Yellow Highlighting Color.
  /// </summary>
  DarkYellow,
  /// <summary>
  ///   Dark Gray Highlighting Color.
  /// </summary>
  DarkGray,
  /// <summary>
  ///   Light Gray Highlighting Color.
  /// </summary>
  LightGray,
  /// <summary>
  ///   No Text Highlighting.
  /// </summary>
  None
}