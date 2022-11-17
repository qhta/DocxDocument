namespace DocumentModel.Wordprocessing;

public enum DocumentType
{
  
  [XmlEnum("notSpecified")]
  NotSpecified,
  
  [XmlEnum("letter")]
  Letter,
  
  [XmlEnum("eMail")]
  Email,
}
