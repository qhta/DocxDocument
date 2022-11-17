namespace DocumentModel.Drawing;

public enum CompoundLine
{

  [XmlEnum("sng")]
  Single,

  [XmlEnum("dbl")]
  Double,

  [XmlEnum("thickThin")]
  ThickThin,

  [XmlEnum("thinThick")]
  ThinThick,

  [XmlEnum("tri")]
  Triple,
}
