namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the LineNumberRestartValues enumeration.
/// </summary>
public enum LineNumberRestartKind
{
  /// <summary>
  /// Restart Line Numbering on Each Page.
  /// </summary>
  [XmlEnum("newPage")]
  NewPage,
  
  /// <summary>
  /// Restart Line Numbering for Each Section.
  /// </summary>
  [XmlEnum("newSection")]
  NewSection,
  
  /// <summary>
  /// Continue Line Numbering From Previous Section.
  /// </summary>
  [XmlEnum("continuous")]
  Continuous,
  
}
