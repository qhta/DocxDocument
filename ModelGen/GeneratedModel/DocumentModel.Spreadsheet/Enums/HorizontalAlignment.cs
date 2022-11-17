namespace DocumentModel.Spreadsheet;

public enum HorizontalAlignment
{
  
  [XmlEnum("general")]
  General,
  
  [XmlEnum("left")]
  Left,
  
  [XmlEnum("center")]
  Center,
  
  [XmlEnum("right")]
  Right,
  
  [XmlEnum("fill")]
  Fill,
  
  [XmlEnum("justify")]
  Justify,
  
  [XmlEnum("centerContinuous")]
  CenterContinuous,
  
  [XmlEnum("distributed")]
  Distributed,
}
