namespace DocumentModel.Wordprocessing;

public enum Style
{
  
  [XmlEnum("paragraph")]
  Paragraph,
  
  [XmlEnum("character")]
  Character,
  
  [XmlEnum("table")]
  Table,
  
  [XmlEnum("numbering")]
  Numbering,
}
