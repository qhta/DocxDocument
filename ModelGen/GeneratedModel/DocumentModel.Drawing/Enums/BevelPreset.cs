namespace DocumentModel.Drawing;

public enum BevelPreset
{

  [XmlEnum("relaxedInset")]
  RelaxedInset,

  [XmlEnum("circle")]
  Circle,

  [XmlEnum("slope")]
  Slope,

  [XmlEnum("cross")]
  Cross,

  [XmlEnum("angle")]
  Angle,

  [XmlEnum("softRound")]
  SoftRound,

  [XmlEnum("convex")]
  Convex,

  [XmlEnum("coolSlant")]
  CoolSlant,

  [XmlEnum("divot")]
  Divot,

  [XmlEnum("riblet")]
  Riblet,

  [XmlEnum("hardEdge")]
  HardEdge,

  [XmlEnum("artDeco")]
  ArtDeco,
}
