namespace DocxDocument.Model;

/// <summary>
/// Defines the DocumentTypeValues enumeration.
/// </summary>
public enum MailingType
{
  /// <summary>
  /// Type of document is not specified.
  /// </summary>
  [XmlEnum("notSpecified")]
  NotSpecified,
  /// <summary>
  /// Document is a letter.
  /// </summary>
  [XmlEnum("letter")]
  Letter,
  /// <summary>
  /// Document is an e-Mail message.
  /// </summary>
  [XmlEnum("eMail")]
  Email
}