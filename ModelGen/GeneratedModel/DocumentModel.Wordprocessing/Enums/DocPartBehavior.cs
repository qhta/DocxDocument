namespace DocumentModel.Wordprocessing;

public enum DocPartBehavior
{

  [XmlEnum("content")]
  Content,

  [XmlEnum("p")]
  Paragraph,

  [XmlEnum("pg")]
  Page,
}
