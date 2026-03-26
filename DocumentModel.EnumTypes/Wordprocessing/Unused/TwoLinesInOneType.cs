namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TwoLinesInOneBracket enumeration.
/// Used to represent Open XML mapped options.
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(StringEnumConverter))]
public enum TwoLinesInOneType
{
  /// <summary>
  /// Restore the two lines of text written into one to two separate lines.
  /// </summary>
  None = 0,
  /// <summary>
  /// Use no enclosing character.
  /// </summary>
  NoBrackets = 1,
  /// <summary>
  /// Enclose the lines using parentheses.
  /// </summary>
  Parentheses = 2,
  /// <summary>
  /// Enclose the lines using square brackets.
  /// </summary>
  SquareBrackets = 3,
  /// <summary>
  /// Enclose the lines using angle brackets.
  /// </summary>
  AngleBrackets = 4,
  /// <summary>
  /// Enclose the lines using curly brackets.
  /// </summary>
  CurlyBrackets = 5
}
