namespace DocumentModel.Wordprocessing;

public enum TextDirection
{

  [XmlEnum("lrTb")]
  LefToRightTopToBottom,

  [XmlEnum("tb")]
  LeftToRightTopToBottom2010,

  [XmlEnum("tbRl")]
  TopToBottomRightToLeft,

  [XmlEnum("rl")]
  TopToBottomRightToLeft2010,

  [XmlEnum("btLr")]
  BottomToTopLeftToRight,

  [XmlEnum("lr")]
  BottomToTopLeftToRight2010,

  [XmlEnum("lrTbV")]
  LefttoRightTopToBottomRotated,

  [XmlEnum("tbV")]
  LeftToRightTopToBottomRotated2010,

  [XmlEnum("tbRlV")]
  TopToBottomRightToLeftRotated,

  [XmlEnum("rlV")]
  TopToBottomRightToLeftRotated2010,

  [XmlEnum("tbLrV")]
  TopToBottomLeftToRightRotated,

  [XmlEnum("lrV")]
  TopToBottomLeftToRightRotated2010,
}
