namespace DocumentModel.Drawing;

public enum BlendMode
{

  [XmlEnum("over")]
  Overlay,

  [XmlEnum("mult")]
  Multiply,

  [XmlEnum("screen")]
  Screen,

  [XmlEnum("darken")]
  Darken,

  [XmlEnum("lighten")]
  Lighten,
}
