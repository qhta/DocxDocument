namespace DocumentModel.Wordprocessing;
/// <summary>
/// Defines the BaselineAlignment enumeration.
/// Used in types such as _ParagraphFormat, Paragraph, Paragraphs.
/// </summary>
[OpenXmlEnumType(typeof(DXW.VerticalTextAlignmentValues))]
[JsonConverter(typeof(StringEnumConverter))]
public enum BaselineAlignment
{
  /// <summary>
  ///   Used only for detection.
  /// </summary>
  /// <summary>Align to baseline</summary>
  [OpenXmlEnumValue(nameof(DXW.VerticalTextAlignmentValues.Baseline))]
  Baseline = 1,
  /// <summary>Align to top</summary>
  [OpenXmlEnumValue(nameof(DXW.VerticalTextAlignmentValues.Top))]
  Top,
  /// <summary>Align to center</summary>
  [OpenXmlEnumValue(nameof(DXW.VerticalTextAlignmentValues.Center))]
  Center,
  /// <summary>Align to bottom according to the Far East font standards.</summary>
  [OpenXmlEnumValue(nameof(DXW.VerticalTextAlignmentValues.Bottom))]
  Bottom,
  /// <summary>Automatic alignment</summary>
  [OpenXmlEnumValue(nameof(DXW.VerticalTextAlignmentValues.Auto))]
  Auto
}
