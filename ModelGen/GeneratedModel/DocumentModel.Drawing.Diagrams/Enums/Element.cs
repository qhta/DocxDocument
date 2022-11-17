namespace DocumentModel.Drawing.Diagrams;

public enum Element
{
  
  [XmlEnum("all")]
  All,
  
  [XmlEnum("doc")]
  Document,
  
  [XmlEnum("node")]
  Node,
  
  [XmlEnum("norm")]
  Normal,
  
  [XmlEnum("nonNorm")]
  NonNormal,
  
  [XmlEnum("asst")]
  Assistant,
  
  [XmlEnum("nonAsst")]
  NonAssistant,
  
  [XmlEnum("parTrans")]
  ParentTransition,
  
  [XmlEnum("pres")]
  Presentation,
  
  [XmlEnum("sibTrans")]
  SiblingTransition,
}
