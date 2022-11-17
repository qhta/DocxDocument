namespace DocumentModel.Drawing;

public enum TextUnderline
{

  [XmlEnum("none")]
  None,

  [XmlEnum("words")]
  Words,

  [XmlEnum("sng")]
  Single,

  [XmlEnum("dbl")]
  Double,

  [XmlEnum("heavy")]
  Heavy,

  [XmlEnum("dotted")]
  Dotted,

  [XmlEnum("dottedHeavy")]
  HeavyDotted,

  [XmlEnum("dash")]
  Dash,

  [XmlEnum("dashHeavy")]
  DashHeavy,

  [XmlEnum("dashLong")]
  DashLong,

  [XmlEnum("dashLongHeavy")]
  DashLongHeavy,

  [XmlEnum("dotDash")]
  DotDash,

  [XmlEnum("dotDashHeavy")]
  DotDashHeavy,

  [XmlEnum("dotDotDash")]
  DotDotDash,

  [XmlEnum("dotDotDashHeavy")]
  DotDotDashHeavy,

  [XmlEnum("wavy")]
  Wavy,

  [XmlEnum("wavyHeavy")]
  WavyHeavy,

  [XmlEnum("wavyDbl")]
  WavyDouble,
}
