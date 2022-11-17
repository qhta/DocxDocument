namespace DocumentModel.Presentation;

public enum TimeNodeFill
{

  [XmlEnum("remove")]
  Remove,

  [XmlEnum("freeze")]
  Freeze,

  [XmlEnum("hold")]
  Hold,

  [XmlEnum("transition")]
  Transition,
}
