namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the DocumentTypeValues enumeration.
/// </summary>
public enum DocumentTypeValues
{
  /// <summary>
  /// Default Document.
  /// </summary>
  [XmlEnum("notSpecified")]
  NotSpecified,
  
  /// <summary>
  /// Letter.
  /// </summary>
  [XmlEnum("letter")]
  Letter,
  
  /// <summary>
  /// E-Mail Message.
  /// </summary>
  [XmlEnum("eMail")]
  Email,
  
}
