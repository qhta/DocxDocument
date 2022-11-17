namespace DocumentModel.InkML;

public enum TraceType
{
  
  [XmlEnum("penDown")]
  PenDown,
  
  [XmlEnum("penUp")]
  PenUp,
  
  [XmlEnum("indeterminate")]
  Indeterminate,
}
