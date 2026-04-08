namespace DocumentModel;
/// <summary>
///   Defines the ThemeColorValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.ThemeColorValues))]
public enum ThemeColors
{
  /// <summary>
  ///   No Theme Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeColorValues.None))]
  None = 0,
  /// <summary>
  ///   Dark Color 1.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeColorValues.Dark1))]
  Dark1 = 1,
  /// <summary>
  ///   Light Color 1.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeColorValues.Light1))]
  Light1 = 2,
  /// <summary>
  ///   Dark Color 2.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeColorValues.Dark2))]
  Dark2 = 3,
  /// <summary>
  ///   Light Color 2.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeColorValues.Light2))]
  Light2 = 4,
  /// <summary>
  ///   Accent Color 1.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeColorValues.Accent1))]
  Accent1 = 5,
  /// <summary>
  ///   Accent Color 2.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeColorValues.Accent2))]
  Accent2 = 6,
  /// <summary>
  ///   Accent Color 3.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeColorValues.Accent3))]
  Accent3 = 7,
  /// <summary>
  ///   Accent Color 4.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeColorValues.Accent4))]
  Accent4 = 8,
  /// <summary>
  ///   Accent Color 5.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeColorValues.Accent5))]
  Accent5 = 9,
  /// <summary>
  ///   Accent Color 6.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeColorValues.Accent6))]
  Accent6 = 10,
  /// <summary>
  ///   IHyperlink Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeColorValues.Hyperlink))]
  Hyperlink = 11,
  /// <summary>
  ///   Followed IHyperlink Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeColorValues.FollowedHyperlink))]
  FollowedHyperlink = 12,
  /// <summary>
  ///   Text Color 1.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeColorValues.Text1))]
  Text1 = 17,
  /// <summary>
  ///   Background Color 2.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeColorValues.Background1))]
  Background1 = 18,
  /// <summary>
  ///   Text Color 2.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeColorValues.Text2))]
  Text2 = 19,
  /// <summary>
  ///   Background Color 1.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeColorValues.Background2))]
  Background2 = 20,
}