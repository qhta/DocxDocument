namespace DocumentModel.Vml;
/// <summary>
///   Black And White Modes
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues))]
public enum BlackAndWhiteMode
{
  /// <summary>
  ///   Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues.Color))]
  Color = 1,

  /// <summary>
  ///   Automatic.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues.Auto))]
  Auto,
  /// <summary>
  ///   Grayscale.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues.GrayScale))]
  GrayScale,
  /// <summary>
  ///   Light grayscale.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues.LightGrayScale))]
  LightGrayScale,
  /// <summary>
  ///   Inverse Grayscale.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues.InverseGray))]
  InverseGray,
  /// <summary>
  ///   Gray Outlines.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues.GrayOutline))]
  GrayOutline,
  /// <summary>
  ///   Black And White.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues.HighContrast))]
  HighContrast,
  /// <summary>
  ///   Black.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues.Black))]
  Black,
  /// <summary>
  ///   White.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues.White))]
  White,
  /// <summary>
  ///   Do Not Show.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues.Undrawn))]
  Undrawn,
  /// <summary>
  ///   Black Text And Lines.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Vml.Office.BlackAndWhiteModeValues.BlackTextAndLines))]
  BlackTextAndLines
}