namespace DocumentModel.Presentation;

public enum BehaviorAdditive
{

  [XmlEnum("base")]
  Base,

  [XmlEnum("sum")]
  Sum,

  [XmlEnum("repl")]
  Replace,

  [XmlEnum("mult")]
  Multiply,

  [XmlEnum("none")]
  None,
}
