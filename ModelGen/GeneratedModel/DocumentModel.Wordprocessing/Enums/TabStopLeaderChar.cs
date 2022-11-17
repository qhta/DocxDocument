namespace DocumentModel.Wordprocessing;

public enum TabStopLeaderChar
{

  [XmlEnum("none")]
  None,

  [XmlEnum("dot")]
  Dot,

  [XmlEnum("hyphen")]
  Hyphen,

  [XmlEnum("underscore")]
  Underscore,

  [XmlEnum("heavy")]
  Heavy,

  [XmlEnum("middleDot")]
  MiddleDot,
}
