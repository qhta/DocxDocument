namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ColorSchemeIndex enumeration.
/// Used in types such as ColorMappingType, ColorMapOverride.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.ColorSchemeIndexValues))]
public enum ColorSchemeIndex
{
  /// <summary>
  ///   Dark 1.
  /// </summary>
  [OpenXmlEnumValue("Dark1")]
  Dark1,
  /// <summary>
  ///   Light 1.
  /// </summary>
  [OpenXmlEnumValue("Light1")]
  Light1,
  /// <summary>
  ///   Dark 2.
  /// </summary>
  [OpenXmlEnumValue("Dark2")]
  Dark2,
  /// <summary>
  ///   Light 2.
  /// </summary>
  [OpenXmlEnumValue("Light2")]
  Light2,
  /// <summary>
  ///   Accent 1.
  /// </summary>
  [OpenXmlEnumValue("Accent1")]
  Accent1,
  /// <summary>
  ///   Accent 2.
  /// </summary>
  [OpenXmlEnumValue("Accent2")]
  Accent2,
  /// <summary>
  ///   Accent 3.
  /// </summary>
  [OpenXmlEnumValue("Accent3")]
  Accent3,
  /// <summary>
  ///   Accent 4.
  /// </summary>
  [OpenXmlEnumValue("Accent4")]
  Accent4,
  /// <summary>
  ///   Accent 5.
  /// </summary>
  [OpenXmlEnumValue("Accent5")]
  Accent5,
  /// <summary>
  ///   Accent 6.
  /// </summary>
  [OpenXmlEnumValue("Accent6")]
  Accent6,
  /// <summary>
  ///   IHyperlink.
  /// </summary>
  [OpenXmlEnumValue("IHyperlink")]
  IHyperlink,
  /// <summary>
  ///   Followed IHyperlink.
  /// </summary>
  [OpenXmlEnumValue("FollowedHyperlink")]
  FollowedHyperlink
}

