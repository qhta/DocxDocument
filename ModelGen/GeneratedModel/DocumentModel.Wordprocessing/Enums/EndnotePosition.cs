namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the EndnotePositionValues enumeration.
/// </summary>
public enum EndnotePosition
{
  /// <summary>
  /// Endnotes Positioned at End of Section.
  /// </summary>
  [XmlEnum("sectEnd")]
  SectionEnd,
  
  /// <summary>
  /// Endnotes Positioned at End of Document.
  /// </summary>
  [XmlEnum("docEnd")]
  DocumentEnd,
  
}
