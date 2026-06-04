namespace DocumentModel.Drawings;
/// <summary>
///   Defines the ColorSchemeIndexValues enumeration.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues))]
public enum ColorSchemes
{
  /// <summary>
  ///   Dark 1 Theme Color Reference.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues.Dark1))]
  Dark1,
  /// <summary>
  ///   Light 1 Theme Color Reference.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues.Light1))]
  Light1,
  /// <summary>
  ///   Dark 2 Theme Color Reference.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues.Dark2))]
  Dark2,
  /// <summary>
  ///   Light 2 Theme Color Reference.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues.Light2))]
  Light2,
  /// <summary>
  ///   Accent 1 Theme Color Reference.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues.Accent1))]
  Accent1,
  /// <summary>
  ///   Accent 2 Theme Color Reference.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues.Accent2))]
  Accent2,
  /// <summary>
  ///   Accent 3 Theme Color Reference.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues.Accent3))]
  Accent3,
  /// <summary>
  ///   Accent4 Theme Color Reference.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues.Accent4))]
  Accent4,
  /// <summary>
  ///   Accent5 Theme Color Reference.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues.Accent5))]
  Accent5,
  /// <summary>
  ///   Accent 6 Theme Color Reference.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues.Accent6))]
  Accent6,
  /// <summary>
  ///   IHyperlink Theme Color Reference.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues.Hyperlink))]
  IHyperlink,
  /// <summary>
  ///   Followed IHyperlink Theme Color Reference.
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.ColorSchemeIndexValues.FollowedHyperlink))]
  FollowedHyperlink
}
