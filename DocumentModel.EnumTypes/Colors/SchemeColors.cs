namespace DocumentModel;
/// <summary>
///   Scheme Color
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.SchemeColorValues))]
public enum SchemeColors
{
  /// <summary>
  ///   IStyle Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SchemeColorValues.PhColor))]
  PhColor = 0,
  /// <summary>
  ///   Dark Color 1.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SchemeColorValues.Dark1))]
  Dark1 = 1,
  /// <summary>
  ///   Light Color 1.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SchemeColorValues.Light1))]
  Light1 = 2,
  /// <summary>
  ///   Dark Color 2.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SchemeColorValues.Dark2))]
  Dark2 = 3,
  /// <summary>
  ///   Light Color 2.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SchemeColorValues.Light2))]
  Light2 = 4,
  /// <summary>
  ///   Accent Color 1.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SchemeColorValues.Accent1))]
  Accent1 = 5,
  /// <summary>
  ///   Accent Color 2.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SchemeColorValues.Accent2))]
  Accent2 = 6,
  /// <summary>
  ///   Accent Color 3.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SchemeColorValues.Accent3))]
  Accent3 = 7,
  /// <summary>
  ///   Accent Color 4.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SchemeColorValues.Accent4))]
  Accent4 = 8,
  /// <summary>
  ///   Accent Color 5.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SchemeColorValues.Accent5))]
  Accent5 = 9,
  /// <summary>
  ///   Accent Color 6.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SchemeColorValues.Accent6))]
  Accent6 = 10,
  /// <summary>
  ///   IHyperlink Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SchemeColorValues.Hyperlink))]
  Hyperlink = 11,
  /// <summary>
  ///   Followed IHyperlink Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SchemeColorValues.FollowedHyperlink))]
  FollowedHyperlink = 12,
  /// <summary>
  ///   Text Color 1.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SchemeColorValues.Text1))]
  Text1 = 17,
  /// <summary>
  ///   Background Color 2.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SchemeColorValues.Background1))]
  Background1 = 18,
  /// <summary>
  ///   Text Color 2.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SchemeColorValues.Text2))]
  Text2 = 19,
  /// <summary>
  ///   Background Color 1.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.SchemeColorValues.Background2))]
  Background2 = 20,

}
