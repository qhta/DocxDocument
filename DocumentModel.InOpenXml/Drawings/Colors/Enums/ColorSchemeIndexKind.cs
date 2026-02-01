namespace DocumentModel.Drawings;
/// <summary>
///   Defines the ColorSchemeIndexValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.ColorSchemeIndexValues))]
public enum ColorSchemeIndexKind
{
  /// <summary>
  ///   Dark 1 Theme Color Reference.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.ColorSchemeIndexValues.Dark1))]
  Dark1,
  /// <summary>
  ///   Light 1 Theme Color Reference.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.ColorSchemeIndexValues.Light1))]
  Light1,
  /// <summary>
  ///   Dark 2 Theme Color Reference.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.ColorSchemeIndexValues.Dark2))]
  Dark2,
  /// <summary>
  ///   Light 2 Theme Color Reference.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.ColorSchemeIndexValues.Light2))]
  Light2,
  /// <summary>
  ///   Accent 1 Theme Color Reference.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.ColorSchemeIndexValues.Accent1))]
  Accent1,
  /// <summary>
  ///   Accent 2 Theme Color Reference.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.ColorSchemeIndexValues.Accent2))]
  Accent2,
  /// <summary>
  ///   Accent 3 Theme Color Reference.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.ColorSchemeIndexValues.Accent3))]
  Accent3,
  /// <summary>
  ///   Accent4 Theme Color Reference.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.ColorSchemeIndexValues.Accent4))]
  Accent4,
  /// <summary>
  ///   Accent5 Theme Color Reference.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.ColorSchemeIndexValues.Accent5))]
  Accent5,
  /// <summary>
  ///   Accent 6 Theme Color Reference.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.ColorSchemeIndexValues.Accent6))]
  Accent6,
  /// <summary>
  ///   IHyperlink Theme Color Reference.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.ColorSchemeIndexValues.Hyperlink))]
  Hyperlink,
  /// <summary>
  ///   Followed IHyperlink Theme Color Reference.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.ColorSchemeIndexValues.FollowedHyperlink))]
  FollowedHyperlink
}