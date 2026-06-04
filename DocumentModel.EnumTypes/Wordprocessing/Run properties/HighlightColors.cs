namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the HighlightColorValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues))]
public enum HighlightColors
{
  /// <summary>
  ///   Black Highlighting Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues.Black))]
  Black,
  /// <summary>
  ///   Blue Highlighting Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues.Blue))]
  Blue,
  /// <summary>
  ///   Cyan Highlighting Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues.Cyan))]
  Cyan,
  /// <summary>
  ///   Green Highlighting Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues.Green))]
  Green,
  /// <summary>
  ///   Magenta Highlighting Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues.Magenta))]
  Magenta,
  /// <summary>
  ///   Red Highlighting Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues.Red))]
  Red,
  /// <summary>
  ///   Yellow Highlighting Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues.Yellow))]
  Yellow,
  /// <summary>
  ///   White Highlighting Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues.White))]
  White,
  /// <summary>
  ///   Dark Blue Highlighting Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues.DarkBlue))]
  DarkBlue,
  /// <summary>
  ///   Dark Cyan Highlighting Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues.DarkCyan))]
  DarkCyan,
  /// <summary>
  ///   Dark Green Highlighting Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues.DarkGreen))]
  DarkGreen,
  /// <summary>
  ///   Dark Magenta Highlighting Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues.DarkMagenta))]
  DarkMagenta,
  /// <summary>
  ///   Dark Red Highlighting Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues.DarkRed))]
  DarkRed,
  /// <summary>
  ///   Dark Yellow Highlighting Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues.DarkYellow))]
  DarkYellow,
  /// <summary>
  ///   Dark Gray Highlighting Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues.DarkGray))]
  DarkGray,
  /// <summary>
  ///   Light Gray Highlighting Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues.LightGray))]
  LightGray,
  /// <summary>
  ///   No Text Highlighting.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.HighlightColorValues.None))]
  None
}