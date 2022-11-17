namespace DocumentModel.Wordprocessing;

public enum Underline
{

  [XmlEnum("single")]
  Single,

  [XmlEnum("words")]
  Words,

  [XmlEnum("double")]
  Double,

  [XmlEnum("thick")]
  Thick,

  [XmlEnum("dotted")]
  Dotted,

  [XmlEnum("dottedHeavy")]
  DottedHeavy,

  [XmlEnum("dash")]
  Dash,

  [XmlEnum("dashedHeavy")]
  DashedHeavy,

  [XmlEnum("dashLong")]
  DashLong,

  [XmlEnum("dashLongHeavy")]
  DashLongHeavy,

  [XmlEnum("dotDash")]
  DotDash,

  [XmlEnum("dashDotHeavy")]
  DashDotHeavy,

  [XmlEnum("dotDotDash")]
  DotDotDash,

  [XmlEnum("dashDotDotHeavy")]
  DashDotDotHeavy,

  [XmlEnum("wave")]
  Wave,

  [XmlEnum("wavyHeavy")]
  WavyHeavy,

  [XmlEnum("wavyDouble")]
  WavyDouble,

  [XmlEnum("none")]
  None,
}
