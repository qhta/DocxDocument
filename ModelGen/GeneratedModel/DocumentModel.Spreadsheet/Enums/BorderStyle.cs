namespace DocumentModel.Spreadsheet;

public enum BorderStyle
{

  [XmlEnum("none")]
  None,

  [XmlEnum("thin")]
  Thin,

  [XmlEnum("medium")]
  Medium,

  [XmlEnum("dashed")]
  Dashed,

  [XmlEnum("dotted")]
  Dotted,

  [XmlEnum("thick")]
  Thick,

  [XmlEnum("double")]
  Double,

  [XmlEnum("hair")]
  Hair,

  [XmlEnum("mediumDashed")]
  MediumDashed,

  [XmlEnum("dashDot")]
  DashDot,

  [XmlEnum("mediumDashDot")]
  MediumDashDot,

  [XmlEnum("dashDotDot")]
  DashDotDot,

  [XmlEnum("mediumDashDotDot")]
  MediumDashDotDot,

  [XmlEnum("slantDashDot")]
  SlantDashDot,
}
