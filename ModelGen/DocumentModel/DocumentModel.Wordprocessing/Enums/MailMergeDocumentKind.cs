namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MailMergeDocumentValues enumeration.
/// </summary>
public enum MailMergeDocumentKind
{
  /// <summary>
  /// Catalog Source Document.
  /// </summary>
  [XmlEnum("catalog")]
  Catalog,
  
  /// <summary>
  /// Envelope Source Document.
  /// </summary>
  [XmlEnum("envelopes")]
  Envelope,
  
  /// <summary>
  /// Mailing Label Source Document.
  /// </summary>
  [XmlEnum("mailingLabels")]
  MailingLabel,
  
  /// <summary>
  /// Form Letter Source Document.
  /// </summary>
  [XmlEnum("formLetters")]
  FormLetter,
  
  /// <summary>
  /// E-Mail Source Document.
  /// </summary>
  [XmlEnum("email")]
  Email,
  
  /// <summary>
  /// Fax Source Document.
  /// </summary>
  [XmlEnum("fax")]
  Fax,
  
}
