namespace DocumentModel.Vml;
/// <summary>
///   Black And White Modes
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXVO.BlackAndWhiteModeValues))]
public enum BlackAndWhiteMode
{
  /// <summary>
  ///   Used only for detection.
  /// </summary>
  /// <summary>
  ///   Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.BlackAndWhiteModeValues.Color))]
  Color = 1,

  /// <summary>
  ///   Automatic.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.BlackAndWhiteModeValues.Auto))]
  Auto,
  /// <summary>
  ///   Grayscale.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.BlackAndWhiteModeValues.GrayScale))]
  GrayScale,
  /// <summary>
  ///   Light grayscale.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.BlackAndWhiteModeValues.LightGrayScale))]
  LightGrayScale,
  /// <summary>
  ///   Inverse Grayscale.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.BlackAndWhiteModeValues.InverseGray))]
  InverseGray,
  /// <summary>
  ///   Gray Outlines.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.BlackAndWhiteModeValues.GrayOutline))]
  GrayOutline,
  /// <summary>
  ///   Black And White.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.BlackAndWhiteModeValues.HighContrast))]
  HighContrast,
  /// <summary>
  ///   Black.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.BlackAndWhiteModeValues.Black))]
  Black,
  /// <summary>
  ///   White.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.BlackAndWhiteModeValues.White))]
  White,
  /// <summary>
  ///   Do Not Show.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.BlackAndWhiteModeValues.Undrawn))]
  Undrawn,
  /// <summary>
  ///   Black Text And Lines.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXVO.BlackAndWhiteModeValues.BlackTextAndLines))]
  BlackTextAndLines
}