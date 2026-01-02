namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the FootnotePositionValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum FootnotePositionKind
{
  /// <summary>
  ///   Footnotes Positioned at Page Bottom.
  /// </summary>
  PageBottom,
  /// <summary>
  ///   Footnotes Positioned Beneath Text.
  /// </summary>
  BeneathText,
  /// <summary>
  ///   Footnotes Positioned At End of ISection.
  /// </summary>
  SectionEnd
}