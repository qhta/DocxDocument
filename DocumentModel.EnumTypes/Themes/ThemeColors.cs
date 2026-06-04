namespace DocumentModel;
/// <summary>
///   Defines the ThemeColorValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues))]
public enum ThemeColors
{
  /// <summary>
  ///   No Theme Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues.None))]
  None = 0,
  /// <summary>
  ///   Dark Color 1.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues.Dark1))]
  Dark1 = 1,
  /// <summary>
  ///   Light Color 1.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues.Light1))]
  Light1 = 2,
  /// <summary>
  ///   Dark Color 2.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues.Dark2))]
  Dark2 = 3,
  /// <summary>
  ///   Light Color 2.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues.Light2))]
  Light2 = 4,
  /// <summary>
  ///   Accent Color 1.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues.Accent1))]
  Accent1 = 5,
  /// <summary>
  ///   Accent Color 2.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues.Accent2))]
  Accent2 = 6,
  /// <summary>
  ///   Accent Color 3.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues.Accent3))]
  Accent3 = 7,
  /// <summary>
  ///   Accent Color 4.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues.Accent4))]
  Accent4 = 8,
  /// <summary>
  ///   Accent Color 5.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues.Accent5))]
  Accent5 = 9,
  /// <summary>
  ///   Accent Color 6.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues.Accent6))]
  Accent6 = 10,
  /// <summary>
  ///   IHyperlink Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues.Hyperlink))]
  Hyperlink = 11,
  /// <summary>
  ///   Followed IHyperlink Color.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues.FollowedHyperlink))]
  FollowedHyperlink = 12,
  /// <summary>
  ///   Text Color 1.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues.Text1))]
  Text1 = 17,
  /// <summary>
  ///   Background Color 2.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues.Background1))]
  Background1 = 18,
  /// <summary>
  ///   Text Color 2.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues.Text2))]
  Text2 = 19,
  /// <summary>
  ///   Background Color 1.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues.Background2))]
  Background2 = 20,
}