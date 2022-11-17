namespace DocumentModel.Wordprocessing;

public enum TabStop
{
  
  [XmlEnum("clear")]
  Clear,
  
  [XmlEnum("left")]
  Left,
  
  [XmlEnum("start")]
  Start,
  
  [XmlEnum("center")]
  Center,
  
  [XmlEnum("right")]
  Right,
  
  [XmlEnum("end")]
  End,
  
  [XmlEnum("decimal")]
  Decimal,
  
  [XmlEnum("bar")]
  Bar,
  
  [XmlEnum("num")]
  Number,
}
