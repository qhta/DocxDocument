namespace DocumentModel.Office2010.Word;

public enum CompoundLine
{

  [XmlEnum("sng")]
  Simple,

  [XmlEnum("dbl")]
  Double,

  [XmlEnum("thickThin")]
  ThickThin,

  [XmlEnum("thinThick")]
  ThinThick,

  [XmlEnum("tri")]
  Triple,
}
