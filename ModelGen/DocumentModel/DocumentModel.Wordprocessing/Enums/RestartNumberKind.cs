namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the RestartNumberValues enumeration.
/// </summary>
public enum RestartNumberKind
{
  /// <summary>
  /// Continue Numbering From Previous Section.
  /// </summary>
  Continuous,
  
  /// <summary>
  /// Restart Numbering For Each Section.
  /// </summary>
  EachSection,
  
  /// <summary>
  /// Restart Numbering On Each Page.
  /// </summary>
  EachPage,
  
}
