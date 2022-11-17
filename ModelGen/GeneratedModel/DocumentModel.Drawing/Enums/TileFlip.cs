namespace DocumentModel.Drawing;

public enum TileFlip
{
  
  [XmlEnum("none")]
  None,
  
  [XmlEnum("x")]
  Horizontal,
  
  [XmlEnum("y")]
  Vertical,
  
  [XmlEnum("xy")]
  HorizontalAndVertical,
}
