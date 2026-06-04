namespace DocumentModel.Drawings;
/// <summary>
///   IFont Alignment Types
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter))]
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Drawing.TextFontAlignmentValues))]
public enum TextFontAlignment
{
  /// <summary>
  ///   IFont Alignment Enum ( Automatic ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextFontAlignmentValues.Automatic))]
  Automatic = 1,

  /// <summary>
  ///   IFont Alignment Enum ( Top ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextFontAlignmentValues.Top))]
  Top,
  /// <summary>
  ///   IFont Alignment Enum ( Center ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextFontAlignmentValues.Center))]
  Center,
  /// <summary>
  ///   IFont Alignment Enum ( Baseline ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextFontAlignmentValues.Baseline))]
  Baseline,
  /// <summary>
  ///   IFont Alignment Enum ( Bottom ).
  /// </summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Drawing.TextFontAlignmentValues.Bottom))]
  Bottom
}
