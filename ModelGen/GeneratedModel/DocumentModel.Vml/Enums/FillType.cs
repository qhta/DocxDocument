namespace DocumentModel.Vml;

public enum FillType
{
  
  [XmlEnum("solid")]
  Solid,
  
  [XmlEnum("gradient")]
  Gradient,
  
  [XmlEnum("gradientRadial")]
  GradientRadial,
  
  [XmlEnum("tile")]
  Tile,
  
  [XmlEnum("pattern")]
  Pattern,
  
  [XmlEnum("frame")]
  Frame,
}
