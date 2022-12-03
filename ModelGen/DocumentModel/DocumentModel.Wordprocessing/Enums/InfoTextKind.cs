namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the InfoTextValues enumeration.
/// </summary>
public enum InfoTextKind
{
  /// <summary>
  /// Literal Text.
  /// </summary>
  [XmlEnum("text")]
  Text,
  
  /// <summary>
  /// Glossary Document Entry.
  /// </summary>
  [XmlEnum("autoText")]
  AutoText,
  
}
