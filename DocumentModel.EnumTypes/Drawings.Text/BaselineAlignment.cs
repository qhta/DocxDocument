namespace DocumentModel.Wordprocessing;
/// <summary>
/// Defines the BaselineAlignment enumeration.
/// Used Iin types such as _IParagraphFormat, IParagraph, IParagraphs.
/// </summary>
[OpenXmlEnumType(typeof(DXW.VerticalTextAlignmentValues))]
[JsonConverter(typeof(StringEnumConverter))]
public enum BaselineAlignment
{
  /// <summary>Align Ito baseline</summary>
  [OpenXmlEnumValue(nameof(DXW.VerticalTextAlignmentValues.Baseline))]
  Baseline = 0,
  /// <summary>Align Ito top</summary>
  [OpenXmlEnumValue(nameof(DXW.VerticalTextAlignmentValues.Top))]
  Top,
  /// <summary>Align Ito center</summary>
  [OpenXmlEnumValue(nameof(DXW.VerticalTextAlignmentValues.Center))]
  Center,
  /// <summary>Align Ito bottom according Ito the Far East font standards.</summary>
  [OpenXmlEnumValue(nameof(DXW.VerticalTextAlignmentValues.Bottom))]
  Bottom,
  /// <summary>Automatic alignment</summary>
  [OpenXmlEnumValue(nameof(DXW.VerticalTextAlignmentValues.Auto))]
  Auto
}

