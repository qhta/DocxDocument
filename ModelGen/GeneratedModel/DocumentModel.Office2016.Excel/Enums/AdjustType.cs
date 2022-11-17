namespace DocumentModel.Office2016.Excel;

public enum AdjustType
{
  
  [XmlEnum("fmla")]
  Fmla,
  
  [XmlEnum("format")]
  Format,
  
  [XmlEnum("condFmt")]
  CondFmt,
  
  [XmlEnum("sparkline")]
  Sparkline,
  
  [XmlEnum("anchor")]
  Anchor,
  
  [XmlEnum("fmlaNoSticky")]
  FmlaNoSticky,
  
  [XmlEnum("noAdj")]
  NoAdj,
  
  [XmlEnum("fragile")]
  Fragile,
  
  [XmlEnum("future")]
  Future,
}
