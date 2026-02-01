namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the FootnotePositionValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.FootnotePositionValues))]
public enum FootnotePositionKind
{
  /// <summary>
  ///   Footnotes Positioned at Page Bottom.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.FootnotePositionValues.PageBottom))]
  PageBottom,
  /// <summary>
  ///   Footnotes Positioned Beneath Text.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.FootnotePositionValues.BeneathText))]
  BeneathText,
  /// <summary>
  ///   Footnotes Positioned At End of ISection.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.FootnotePositionValues.SectionEnd))]
  SectionEnd
}