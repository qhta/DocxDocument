namespace DocumentModel.Drawing;

public enum PresetLineDash
{
  
  [XmlEnum("solid")]
  Solid,
  
  [XmlEnum("dot")]
  Dot,
  
  [XmlEnum("dash")]
  Dash,
  
  [XmlEnum("lgDash")]
  LargeDash,
  
  [XmlEnum("dashDot")]
  DashDot,
  
  [XmlEnum("lgDashDot")]
  LargeDashDot,
  
  [XmlEnum("lgDashDotDot")]
  LargeDashDotDot,
  
  [XmlEnum("sysDash")]
  SystemDash,
  
  [XmlEnum("sysDot")]
  SystemDot,
  
  [XmlEnum("sysDashDot")]
  SystemDashDot,
  
  [XmlEnum("sysDashDotDot")]
  SystemDashDotDot,
}
