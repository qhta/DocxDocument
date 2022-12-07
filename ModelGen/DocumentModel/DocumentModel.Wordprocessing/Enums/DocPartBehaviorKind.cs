namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the DocPartBehaviorValues enumeration.
/// </summary>
public enum DocPartBehaviorKind
{
  /// <summary>
  /// Insert Content At Specified Location.
  /// </summary>
  Content,
  
  /// <summary>
  /// Ensure Entry Is In New Paragraph.
  /// </summary>
  Paragraph,
  
  /// <summary>
  /// Ensure Entry Is On New Page.
  /// </summary>
  Page,
  
}
