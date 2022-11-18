namespace DocumentModel.Presentation;

/// <summary>
/// Paragraph Build Type
/// </summary>
public enum ParagraphBuild
{
  /// <summary>
  /// All At Once.
  /// </summary>
  [XmlEnum("allAtOnce")]
  AllAtOnce,
  
  /// <summary>
  /// Paragraph.
  /// </summary>
  [XmlEnum("p")]
  Paragraph,
  
  /// <summary>
  /// Custom.
  /// </summary>
  [XmlEnum("cust")]
  Custom,
  
  /// <summary>
  /// Whole.
  /// </summary>
  [XmlEnum("whole")]
  Whole,
  
}
