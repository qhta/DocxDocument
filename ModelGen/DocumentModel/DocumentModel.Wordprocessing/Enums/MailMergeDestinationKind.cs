namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MailMergeDestinationValues enumeration.
/// </summary>
public enum MailMergeDestinationKind
{
  /// <summary>
  /// Send Merged Documents to New Documents.
  /// </summary>
  [XmlEnum("newDocument")]
  NewDocument,
  
  /// <summary>
  /// Send Merged Documents to Printer.
  /// </summary>
  [XmlEnum("printer")]
  Printer,
  
  /// <summary>
  /// Send Merged Documents as E-mail Messages.
  /// </summary>
  [XmlEnum("email")]
  Email,
  
  /// <summary>
  /// Send Merged Documents as Faxes.
  /// </summary>
  [XmlEnum("fax")]
  Fax,
  
}
