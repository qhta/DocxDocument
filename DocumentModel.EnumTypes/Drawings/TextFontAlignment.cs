namespace DocumentModel.Drawings;
/// <summary>
///   IFont Alignment Types
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXD.TextFontAlignmentValues))]
public enum TextFontAlignment
{
  /// <summary>
  ///   IFont Alignment Enum ( Automatic ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextFontAlignmentValues.Automatic))]
  Automatic = 1,

  /// <summary>
  ///   IFont Alignment Enum ( Top ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextFontAlignmentValues.Top))]
  Top,
  /// <summary>
  ///   IFont Alignment Enum ( Center ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextFontAlignmentValues.Center))]
  Center,
  /// <summary>
  ///   IFont Alignment Enum ( Baseline ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextFontAlignmentValues.Baseline))]
  Baseline,
  /// <summary>
  ///   IFont Alignment Enum ( Bottom ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DXD.TextFontAlignmentValues.Bottom))]
  Bottom
}
