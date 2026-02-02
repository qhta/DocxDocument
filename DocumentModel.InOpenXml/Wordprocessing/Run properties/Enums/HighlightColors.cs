namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the HighlightColorValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.HighlightColorValues))]
public enum HighlightColors
{
  /// <summary>
  ///   Black Highlighting Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.HighlightColorValues.Black))]
  Black,
  /// <summary>
  ///   Blue Highlighting Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.HighlightColorValues.Blue))]
  Blue,
  /// <summary>
  ///   Cyan Highlighting Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.HighlightColorValues.Cyan))]
  Cyan,
  /// <summary>
  ///   Green Highlighting Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.HighlightColorValues.Green))]
  Green,
  /// <summary>
  ///   Magenta Highlighting Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.HighlightColorValues.Magenta))]
  Magenta,
  /// <summary>
  ///   Red Highlighting Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.HighlightColorValues.Red))]
  Red,
  /// <summary>
  ///   Yellow Highlighting Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.HighlightColorValues.Yellow))]
  Yellow,
  /// <summary>
  ///   White Highlighting Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.HighlightColorValues.White))]
  White,
  /// <summary>
  ///   Dark Blue Highlighting Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.HighlightColorValues.DarkBlue))]
  DarkBlue,
  /// <summary>
  ///   Dark Cyan Highlighting Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.HighlightColorValues.DarkCyan))]
  DarkCyan,
  /// <summary>
  ///   Dark Green Highlighting Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.HighlightColorValues.DarkGreen))]
  DarkGreen,
  /// <summary>
  ///   Dark Magenta Highlighting Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.HighlightColorValues.DarkMagenta))]
  DarkMagenta,
  /// <summary>
  ///   Dark Red Highlighting Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.HighlightColorValues.DarkRed))]
  DarkRed,
  /// <summary>
  ///   Dark Yellow Highlighting Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.HighlightColorValues.DarkYellow))]
  DarkYellow,
  /// <summary>
  ///   Dark Gray Highlighting Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.HighlightColorValues.DarkGray))]
  DarkGray,
  /// <summary>
  ///   Light Gray Highlighting Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.HighlightColorValues.LightGray))]
  LightGray,
  /// <summary>
  ///   No Text Highlighting.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.HighlightColorValues.None))]
  None
}