namespace DocumentModel.Presentation;

public enum ParagraphBuild
{
  
  [XmlEnum("allAtOnce")]
  AllAtOnce,
  
  [XmlEnum("p")]
  Paragraph,
  
  [XmlEnum("cust")]
  Custom,
  
  [XmlEnum("whole")]
  Whole,
}
