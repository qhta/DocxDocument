namespace DocumentModel.Office2013.Excel;

public enum SurveyPosition
{
  
  [XmlEnum("absolute")]
  Absolute,
  
  [XmlEnum("fixed")]
  Fixed,
  
  [XmlEnum("relative")]
  Relative,
  
  [XmlEnum("static")]
  Static,
  
  [XmlEnum("inherit")]
  Inherit,
}
