namespace DocumentModel.Wordprocessing;

public enum MailMergeDestination
{

  [XmlEnum("newDocument")]
  NewDocument,

  [XmlEnum("printer")]
  Printer,

  [XmlEnum("email")]
  Email,

  [XmlEnum("fax")]
  Fax,
}
