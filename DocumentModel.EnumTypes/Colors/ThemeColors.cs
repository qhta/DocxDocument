namespace DocumentModel;
/// <summary>
///   Defines the ThemeColorValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.ThemeColorValues))]
public enum ThemeColors
{
  /// <summary>
  ///   Dark 1 Theme Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeColorValues.Dark1))]
  Dark1,
  /// <summary>
  ///   Light 1 Theme Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeColorValues.Light1))]
  Light1,
  /// <summary>
  ///   Dark 2 Theme Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeColorValues.Dark2))]
  Dark2,
  /// <summary>
  ///   Light 2 Theme Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeColorValues.Light2))]
  Light2,
  /// <summary>
  ///   Accent 1 Theme Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeColorValues.Accent1))]
  Accent1,
  /// <summary>
  ///   Accent 2 Theme Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeColorValues.Accent2))]
  Accent2,
  /// <summary>
  ///   Accent 3 Theme Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeColorValues.Accent3))]
  Accent3,
  /// <summary>
  ///   Accent 4 Theme Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeColorValues.Accent4))]
  Accent4,
  /// <summary>
  ///   Accent 5 Theme Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeColorValues.Accent5))]
  Accent5,
  /// <summary>
  ///   Accent 6 Theme Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeColorValues.Accent6))]
  Accent6,
  /// <summary>
  ///   IHyperlink Theme Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeColorValues.Hyperlink))]
  Hyperlink,
  /// <summary>
  ///   Followed IHyperlink Theme Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeColorValues.FollowedHyperlink))]
  FollowedHyperlink,
  /// <summary>
  ///   No Theme Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeColorValues.None))]
  None,
  /// <summary>
  ///   Background 1 Theme Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeColorValues.Background1))]
  Background1,
  /// <summary>
  ///   Text 1 Theme Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeColorValues.Text1))]
  Text1,
  /// <summary>
  ///   Background 2 Theme Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeColorValues.Background2))]
  Background2,
  /// <summary>
  ///   Text 2 Theme Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.ThemeColorValues.Text2))]
  Text2
}