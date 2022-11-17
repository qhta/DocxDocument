namespace DocumentModel.Drawing.Diagrams;

public enum Point
{

  [XmlEnum("node")]
  Node,

  [XmlEnum("asst")]
  Assistant,

  [XmlEnum("doc")]
  Document,

  [XmlEnum("pres")]
  Presentation,

  [XmlEnum("parTrans")]
  ParentTransition,

  [XmlEnum("sibTrans")]
  SiblingTransition,
}
