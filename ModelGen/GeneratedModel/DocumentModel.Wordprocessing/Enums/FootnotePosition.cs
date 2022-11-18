namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FootnotePositionValues enumeration.
/// </summary>
public enum FootnotePosition
{
  /// <summary>
  /// Footnotes Positioned at Page Bottom.
  /// </summary>
  [XmlEnum("pageBottom")]
  PageBottom,
  
  /// <summary>
  /// Footnotes Positioned Beneath Text.
  /// </summary>
  [XmlEnum("beneathText")]
  BeneathText,
  
  /// <summary>
  /// Footnotes Positioned At End of Section.
  /// </summary>
  [XmlEnum("sectEnd")]
  SectionEnd,
  
}
