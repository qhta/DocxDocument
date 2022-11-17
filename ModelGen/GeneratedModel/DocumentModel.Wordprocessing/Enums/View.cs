namespace DocumentModel.Wordprocessing;

public enum View
{
  
  [XmlEnum("none")]
  None,
  
  [XmlEnum("print")]
  Print,
  
  [XmlEnum("outline")]
  Outline,
  
  [XmlEnum("masterPages")]
  MasterPages,
  
  [XmlEnum("normal")]
  Normal,
  
  [XmlEnum("web")]
  Web,
}
