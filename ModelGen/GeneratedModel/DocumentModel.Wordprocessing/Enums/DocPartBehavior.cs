namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the DocPartBehaviorValues enumeration.
/// </summary>
public enum DocPartBehavior
{
  /// <summary>
  /// Insert Content At Specified Location.
  /// </summary>
  [XmlEnum("content")]
  Content,
  
  /// <summary>
  /// Ensure Entry Is In New Paragraph.
  /// </summary>
  [XmlEnum("p")]
  Paragraph,
  
  /// <summary>
  /// Ensure Entry Is On New Page.
  /// </summary>
  [XmlEnum("pg")]
  Page,
  
}
