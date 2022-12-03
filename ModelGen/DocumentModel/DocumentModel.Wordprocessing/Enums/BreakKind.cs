namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the BreakValues enumeration.
/// </summary>
public enum BreakKind
{
  /// <summary>
  /// Page Break.
  /// </summary>
  [XmlEnum("page")]
  Page,
  
  /// <summary>
  /// Column Break.
  /// </summary>
  [XmlEnum("column")]
  Column,
  
  /// <summary>
  /// Line Break.
  /// </summary>
  [XmlEnum("textWrapping")]
  TextWrapping,
  
}
