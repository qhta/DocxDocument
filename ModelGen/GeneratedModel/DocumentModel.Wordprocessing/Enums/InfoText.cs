namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the InfoTextValues enumeration.
/// </summary>
public enum InfoText
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
