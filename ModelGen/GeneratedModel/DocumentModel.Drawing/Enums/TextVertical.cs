namespace DocumentModel.Drawing;

public enum TextVertical
{
  
  [XmlEnum("horz")]
  Horizontal,
  
  [XmlEnum("vert")]
  Vertical,
  
  [XmlEnum("vert270")]
  Vertical270,
  
  [XmlEnum("wordArtVert")]
  WordArtVertical,
  
  [XmlEnum("eaVert")]
  EastAsianVetical,
  
  [XmlEnum("mongolianVert")]
  MongolianVertical,
  
  [XmlEnum("wordArtVertRtl")]
  WordArtLeftToRight,
}
