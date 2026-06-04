namespace DocumentModel.Wordprocessing;
/// <summary>
/// Defines the BaselineAlignment enumeration.
/// Used in types such as _IParagraphFormat, IParagraph, IParagraphs.
/// </summary>
[OpenXmlEnumType(typeof(DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentValues))]
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum BaselineAlignment
{
  /// <summary>Align to baseline</summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentValues.Baseline))]
  Baseline = 0,
  /// <summary>Align to top</summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentValues.Top))]
  Top,
  /// <summary>Align to center</summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentValues.Center))]
  Center,
  /// <summary>Align to bottom according to the Far East font standards.</summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentValues.Bottom))]
  Bottom,
  /// <summary>Automatic alignment</summary>
  [OpenXmlEnumValue(nameof(DocumentFormat.OpenXml.Wordprocessing.VerticalTextAlignmentValues.Auto))]
  Auto
}

