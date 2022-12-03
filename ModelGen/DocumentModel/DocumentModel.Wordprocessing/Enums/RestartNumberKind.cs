namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the RestartNumberValues enumeration.
/// </summary>
public enum RestartNumberKind
{
  /// <summary>
  /// Continue Numbering From Previous Section.
  /// </summary>
  [XmlEnum("continuous")]
  Continuous,
  
  /// <summary>
  /// Restart Numbering For Each Section.
  /// </summary>
  [XmlEnum("eachSect")]
  EachSection,
  
  /// <summary>
  /// Restart Numbering On Each Page.
  /// </summary>
  [XmlEnum("eachPage")]
  EachPage,
  
}
