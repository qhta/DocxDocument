namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MailMergeSourceValues enumeration.
/// </summary>
public enum MailMergeSourceKind
{
  /// <summary>
  /// Database Data Source.
  /// </summary>
  [XmlEnum("database")]
  Database,
  
  /// <summary>
  /// Address Book Data Source.
  /// </summary>
  [XmlEnum("addressBook")]
  AddressBook,
  
  /// <summary>
  /// Alternate Document Format Data Source.
  /// </summary>
  [XmlEnum("document1")]
  Document1,
  
  /// <summary>
  /// Alternate Document Format Data Source Two.
  /// </summary>
  [XmlEnum("document2")]
  Document2,
  
  /// <summary>
  /// Text File Data Source.
  /// </summary>
  [XmlEnum("text")]
  Text,
  
  /// <summary>
  /// E-Mail Program Data Source.
  /// </summary>
  [XmlEnum("email")]
  Email,
  
  /// <summary>
  /// Native Data Source.
  /// </summary>
  [XmlEnum("native")]
  Native,
  
  /// <summary>
  /// Legacy Document Format Data Source.
  /// </summary>
  [XmlEnum("legacy")]
  Legacy,
  
  /// <summary>
  /// Aggregate Data Source.
  /// </summary>
  [XmlEnum("master")]
  Master,
  
}
