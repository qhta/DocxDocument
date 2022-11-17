namespace DocumentModel.Math;

public enum Script
{

  [XmlEnum("roman")]
  Roman,

  [XmlEnum("script")]
  Script,

  [XmlEnum("fraktur")]
  Fraktur,

  [XmlEnum("double-struck")]
  DoubleStruck,

  [XmlEnum("sans-serif")]
  SansSerif,

  [XmlEnum("monospace")]
  Monospace,
}
