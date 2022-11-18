namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the DisplacedByCustomXmlValues enumeration.
/// </summary>
public enum DisplacedByCustomXml
{
  /// <summary>
  /// Displaced by Next Custom XML Markup Tag.
  /// </summary>
  [XmlEnum("next")]
  Next,
  
  /// <summary>
  /// Displaced by Previous Custom XML Markup Tag.
  /// </summary>
  [XmlEnum("prev")]
  Previous,
  
}
