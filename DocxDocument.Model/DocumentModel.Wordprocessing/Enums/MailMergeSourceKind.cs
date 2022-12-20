namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MailMergeSourceValues enumeration.
/// </summary>
public enum MailMergeSourceKind
{
  /// <summary>
  /// Database Data Source.
  /// </summary>
  Database,
  
  /// <summary>
  /// Address Book Data Source.
  /// </summary>
  AddressBook,
  
  /// <summary>
  /// Alternate Document Format Data Source.
  /// </summary>
  Document1,
  
  /// <summary>
  /// Alternate Document Format Data Source Two.
  /// </summary>
  Document2,
  
  /// <summary>
  /// Text File Data Source.
  /// </summary>
  Text,
  
  /// <summary>
  /// E-Mail Program Data Source.
  /// </summary>
  Email,
  
  /// <summary>
  /// Native Data Source.
  /// </summary>
  Native,
  
  /// <summary>
  /// Legacy Document Format Data Source.
  /// </summary>
  Legacy,
  
  /// <summary>
  /// Aggregate Data Source.
  /// </summary>
  Master,
  
}
