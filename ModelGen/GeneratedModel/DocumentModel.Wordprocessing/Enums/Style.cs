namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the StyleValues enumeration.
/// </summary>
public enum Style
{
  /// <summary>
  /// Paragraph Style.
  /// </summary>
  [XmlEnum("paragraph")]
  Paragraph,
  
  /// <summary>
  /// Character Style.
  /// </summary>
  [XmlEnum("character")]
  Character,
  
  /// <summary>
  /// Table Style.
  /// </summary>
  [XmlEnum("table")]
  Table,
  
  /// <summary>
  /// Numbering Style.
  /// </summary>
  [XmlEnum("numbering")]
  Numbering,
  
}
