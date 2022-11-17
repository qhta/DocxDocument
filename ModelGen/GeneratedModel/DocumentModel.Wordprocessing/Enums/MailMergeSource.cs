namespace DocumentModel.Wordprocessing;

public enum MailMergeSource
{

  [XmlEnum("database")]
  Database,

  [XmlEnum("addressBook")]
  AddressBook,

  [XmlEnum("document1")]
  Document1,

  [XmlEnum("document2")]
  Document2,

  [XmlEnum("text")]
  Text,

  [XmlEnum("email")]
  Email,

  [XmlEnum("native")]
  Native,

  [XmlEnum("legacy")]
  Legacy,

  [XmlEnum("master")]
  Master,
}
