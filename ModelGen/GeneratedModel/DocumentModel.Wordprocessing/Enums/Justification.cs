namespace DocumentModel.Wordprocessing;

public enum Justification
{

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

  [XmlEnum("both")]
  Both,

  [XmlEnum("mediumKashida")]
  MediumKashida,

  [XmlEnum("distribute")]
  Distribute,

  [XmlEnum("numTab")]
  NumTab,

  [XmlEnum("highKashida")]
  HighKashida,

  [XmlEnum("lowKashida")]
  LowKashida,

  [XmlEnum("thaiDistribute")]
  ThaiDistribute,
}
