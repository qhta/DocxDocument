namespace DocumentModel.Drawings;
/// <summary>
///   Black and White Mode
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.BlackWhiteModeValues))]
public enum BlackWhiteMode
{
  /// <summary>
  ///   Used only for detection.
  /// </summary>
  /// <summary>
  ///   Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BlackWhiteModeValues.Color))]
  Color = 1,

  /// <summary>
  ///   Automatic.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BlackWhiteModeValues.Auto))]
  Auto,
  /// <summary>
  ///   Gray.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BlackWhiteModeValues.Gray))]
  Gray,
  /// <summary>
  ///   Light Gray.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BlackWhiteModeValues.LightGray))]
  LightGray,
  /// <summary>
  ///   Inverse Gray.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BlackWhiteModeValues.InvGray))]
  InvGray,
  /// <summary>
  ///   Gray and White.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BlackWhiteModeValues.GrayWhite))]
  GrayWhite,
  /// <summary>
  ///   Black and Gray.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BlackWhiteModeValues.BlackGray))]
  BlackGray,
  /// <summary>
  ///   Black and White.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BlackWhiteModeValues.BlackWhite))]
  BlackWhite,
  /// <summary>
  ///   Black.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BlackWhiteModeValues.Black))]
  Black,
  /// <summary>
  ///   White.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BlackWhiteModeValues.White))]
  White,
  /// <summary>
  ///   Hidden.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.BlackWhiteModeValues.Hidden))]
  Hidden
}