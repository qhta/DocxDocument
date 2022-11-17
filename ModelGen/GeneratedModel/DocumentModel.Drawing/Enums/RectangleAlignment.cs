namespace DocumentModel.Drawing;

public enum RectangleAlignment
{

  [XmlEnum("tl")]
  TopLeft,

  [XmlEnum("t")]
  Top,

  [XmlEnum("tr")]
  TopRight,

  [XmlEnum("l")]
  Left,

  [XmlEnum("ctr")]
  Center,

  [XmlEnum("r")]
  Right,

  [XmlEnum("bl")]
  BottomLeft,

  [XmlEnum("b")]
  Bottom,

  [XmlEnum("br")]
  BottomRight,
}
