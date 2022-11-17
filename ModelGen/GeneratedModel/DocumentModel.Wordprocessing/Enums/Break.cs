namespace DocumentModel.Wordprocessing;

public enum Break
{
  
  [XmlEnum("page")]
  Page,
  
  [XmlEnum("column")]
  Column,
  
  [XmlEnum("textWrapping")]
  TextWrapping,
}
