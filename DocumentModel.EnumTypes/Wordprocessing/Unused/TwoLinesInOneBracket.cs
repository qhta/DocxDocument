namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TwoLinesInOneBracket enumeration.
/// Used to represent Open XML mapped options.
/// </summary>
[OpenXmlNotMapped]
[JsonConverter(typeof(StringEnumConverter))]
public enum TwoLinesInOneBracket
{
  /// <summary>No brackets</summary>
  [OpenXmlEnumValue("None")]
  None = 0,
  /// <summary>Parentheses ()</summary>
  [OpenXmlEnumValue("Parentheses")]
  Parentheses = 1,
  /// <summary>Square brackets []</summary>
  [OpenXmlEnumValue("SquareBrackets")]
  SquareBrackets = 2,
  /// <summary>Angle brackets &lt;&gt;</summary>
  [OpenXmlEnumValue("AngleBrackets")]
  AngleBrackets = 3,
  /// <summary>Curly brackets {}</summary>
  [OpenXmlEnumValue("CurlyBrackets")]
  CurlyBrackets = 4
}
