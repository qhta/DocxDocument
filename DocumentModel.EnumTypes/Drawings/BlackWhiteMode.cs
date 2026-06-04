namespace DocumentModel.Drawings;
/// <summary>
///   Black and White Mode
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues))]
public enum BlackWhiteMode
{
  /// <summary>
  ///   Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues.Color))]
  Color = 1,
  /// <summary>
  ///   Automatic.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues.Auto))]
  Auto,
  /// <summary>
  ///   Gray.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues.Gray))]
  Gray,
  /// <summary>
  ///   Light Gray.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues.LightGray))]
  LightGray,
  /// <summary>
  ///   Inverse Gray.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues.InvGray))]
  InvGray,
  /// <summary>
  ///   Gray and White.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues.GrayWhite))]
  GrayWhite,
  /// <summary>
  ///   Black and Gray.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues.BlackGray))]
  BlackGray,
  /// <summary>
  ///   Black and White.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues.BlackWhite))]
  BlackWhite,
  /// <summary>
  ///   Black.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues.Black))]
  Black,
  /// <summary>
  ///   White.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues.White))]
  White,
  /// <summary>
  ///   Hidden.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.BlackWhiteModeValues.Hidden))]
  Hidden
}