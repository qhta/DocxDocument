namespace DocumentModel;
/// <summary>
///   Scheme Color
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.SchemeColorValues))]
public enum SchemeColors
{
  /// <summary>
  ///   Background Color 1.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SchemeColorValues.Background1))]
  Background1,
  /// <summary>
  ///   Text Color 1.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SchemeColorValues.Text1))]
  Text1,
  /// <summary>
  ///   Background Color 2.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SchemeColorValues.Background2))]
  Background2,
  /// <summary>
  ///   Text Color 2.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SchemeColorValues.Text2))]
  Text2,
  /// <summary>
  ///   Accent Color 1.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SchemeColorValues.Accent1))]
  Accent1,
  /// <summary>
  ///   Accent Color 2.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SchemeColorValues.Accent2))]
  Accent2,
  /// <summary>
  ///   Accent Color 3.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SchemeColorValues.Accent3))]
  Accent3,
  /// <summary>
  ///   Accent Color 4.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SchemeColorValues.Accent4))]
  Accent4,
  /// <summary>
  ///   Accent Color 5.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SchemeColorValues.Accent5))]
  Accent5,
  /// <summary>
  ///   Accent Color 6.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SchemeColorValues.Accent6))]
  Accent6,
  /// <summary>
  ///   IHyperlink Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SchemeColorValues.Hyperlink))]
  Hyperlink,
  /// <summary>
  ///   Followed IHyperlink Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SchemeColorValues.FollowedHyperlink))]
  FollowedHyperlink,
  /// <summary>
  ///   Style Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SchemeColorValues.PhColor))]
  PhColor,
  /// <summary>
  ///   Dark Color 1.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SchemeColorValues.Dark1))]
  Dark1,
  /// <summary>
  ///   Light Color 1.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SchemeColorValues.Light1))]
  Light1,
  /// <summary>
  ///   Dark Color 2.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SchemeColorValues.Dark2))]
  Dark2,
  /// <summary>
  ///   Light Color 2.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.SchemeColorValues.Light2))]
  Light2
}