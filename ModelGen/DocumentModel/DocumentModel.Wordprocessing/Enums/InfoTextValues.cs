namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the InfoTextValues enumeration.
/// </summary>
public enum InfoTextValues
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
