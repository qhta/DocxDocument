namespace DocumentModel.Wordprocessing;

public enum LineSpacingRule
{
  
  [XmlEnum("auto")]
  Auto,
  
  [XmlEnum("exact")]
  Exact,
  
  [XmlEnum("atLeast")]
  AtLeast,
}
