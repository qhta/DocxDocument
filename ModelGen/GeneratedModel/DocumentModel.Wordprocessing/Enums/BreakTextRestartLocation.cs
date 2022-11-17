namespace DocumentModel.Wordprocessing;

public enum BreakTextRestartLocation
{
  
  [XmlEnum("none")]
  None,
  
  [XmlEnum("left")]
  Left,
  
  [XmlEnum("right")]
  Right,
  
  [XmlEnum("all")]
  All,
}
