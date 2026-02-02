namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the EndnotePositionValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.EndnotePositionValues))]
public enum EndnotePosition
{
  /// <summary>
  ///   Endnotes Positioned at End of ISection.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.EndnotePositionValues.SectionEnd))]
  SectionEnd,
  /// <summary>
  ///   Endnotes Positioned at End of Document.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.EndnotePositionValues.DocumentEnd))]
  DocumentEnd
}