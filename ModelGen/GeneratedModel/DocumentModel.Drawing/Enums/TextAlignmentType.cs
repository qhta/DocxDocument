namespace DocumentModel.Drawing;

public enum TextAlignmentType
{

  [XmlEnum("l")]
  Left,

  [XmlEnum("ctr")]
  Center,

  [XmlEnum("r")]
  Right,

  [XmlEnum("just")]
  Justified,

  [XmlEnum("justLow")]
  JustifiedLow,

  [XmlEnum("dist")]
  Distributed,

  [XmlEnum("thaiDist")]
  ThaiDistributed,
}
