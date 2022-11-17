namespace DocumentModel.Spreadsheet;

public enum Pattern
{
  
  [XmlEnum("none")]
  None,
  
  [XmlEnum("solid")]
  Solid,
  
  [XmlEnum("mediumGray")]
  MediumGray,
  
  [XmlEnum("darkGray")]
  DarkGray,
  
  [XmlEnum("lightGray")]
  LightGray,
  
  [XmlEnum("darkHorizontal")]
  DarkHorizontal,
  
  [XmlEnum("darkVertical")]
  DarkVertical,
  
  [XmlEnum("darkDown")]
  DarkDown,
  
  [XmlEnum("darkUp")]
  DarkUp,
  
  [XmlEnum("darkGrid")]
  DarkGrid,
  
  [XmlEnum("darkTrellis")]
  DarkTrellis,
  
  [XmlEnum("lightHorizontal")]
  LightHorizontal,
  
  [XmlEnum("lightVertical")]
  LightVertical,
  
  [XmlEnum("lightDown")]
  LightDown,
  
  [XmlEnum("lightUp")]
  LightUp,
  
  [XmlEnum("lightGrid")]
  LightGrid,
  
  [XmlEnum("lightTrellis")]
  LightTrellis,
  
  [XmlEnum("gray125")]
  Gray125,
  
  [XmlEnum("gray0625")]
  Gray0625,
}
