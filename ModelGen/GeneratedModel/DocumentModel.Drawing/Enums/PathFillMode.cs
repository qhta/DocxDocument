namespace DocumentModel.Drawing;

public enum PathFillMode
{

  [XmlEnum("none")]
  None,

  [XmlEnum("norm")]
  Norm,

  [XmlEnum("lighten")]
  Lighten,

  [XmlEnum("lightenLess")]
  LightenLess,

  [XmlEnum("darken")]
  Darken,

  [XmlEnum("darkenLess")]
  DarkenLess,
}
