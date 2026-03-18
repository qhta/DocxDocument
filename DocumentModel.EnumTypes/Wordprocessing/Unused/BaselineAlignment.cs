namespace DocumentModel.Wordprocessing;
/// <summary>
/// Defines the BaselineAlignment enumeration.
/// Used in types such as _ParagraphFormat, Paragraph, Paragraphs.
/// </summary>
[OpenXmlEnumType(typeof(DXW.VerticalTextAlignmentValues))]
[JsonConverter(typeof(StringEnumConverter))]
public enum BaselineAlignment
{
  /// <summary>Align to baseline</summary>
  [OpenXmlEnumValue(nameof(DXW.VerticalTextAlignmentValues.Baseline))]
  Baseline = 0,
  /// <summary>Align to top</summary>
  [OpenXmlEnumValue(nameof(DXW.VerticalTextAlignmentValues.Top))]
  Top = 1,
  /// <summary>Align to center</summary>
  [OpenXmlEnumValue(nameof(DXW.VerticalTextAlignmentValues.Center))]
  Center = 2,
  /// <summary>Align to bottom</summary>
  [OpenXmlEnumValue(nameof(DXW.VerticalTextAlignmentValues.Bottom))]
  Bottom = 3,
  /// <summary>Automatic alignment</summary>
  [OpenXmlEnumValue(nameof(DXW.VerticalTextAlignmentValues.Auto))]
  Auto = 4
}
