namespace DocumentModel.Drawings;
/// <summary>
///   Font Alignment Types
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.TextFontAlignmentValues))]
public enum TextFontAlignment
{
  /// <summary>
  ///   Used only for detection.
  /// </summary>
  /// <summary>
  ///   Font Alignment Enum ( Automatic ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextFontAlignmentValues.Automatic))]
  Automatic = 1,

  /// <summary>
  ///   Font Alignment Enum ( Top ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextFontAlignmentValues.Top))]
  Top,
  /// <summary>
  ///   Font Alignment Enum ( Center ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextFontAlignmentValues.Center))]
  Center,
  /// <summary>
  ///   Font Alignment Enum ( Baseline ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextFontAlignmentValues.Baseline))]
  Baseline,
  /// <summary>
  ///   Font Alignment Enum ( Bottom ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextFontAlignmentValues.Bottom))]
  Bottom
}