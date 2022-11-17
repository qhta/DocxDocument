namespace DocumentModel.Wordprocessing;

public enum MailMergeDocument
{
  
  [XmlEnum("catalog")]
  Catalog,
  
  [XmlEnum("envelopes")]
  Envelope,
  
  [XmlEnum("mailingLabels")]
  MailingLabel,
  
  [XmlEnum("formLetters")]
  FormLetter,
  
  [XmlEnum("email")]
  Email,
  
  [XmlEnum("fax")]
  Fax,
}
