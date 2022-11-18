namespace DocumentModel.Drawing;

/// <summary>
/// Preset Line Dash Value
/// </summary>
public enum PresetLineDash
{
  /// <summary>
  /// Solid.
  /// </summary>
  [XmlEnum("solid")]
  Solid,
  
  /// <summary>
  /// Dot.
  /// </summary>
  [XmlEnum("dot")]
  Dot,
  
  /// <summary>
  /// Dash.
  /// </summary>
  [XmlEnum("dash")]
  Dash,
  
  /// <summary>
  /// Large Dash.
  /// </summary>
  [XmlEnum("lgDash")]
  LargeDash,
  
  /// <summary>
  /// Dash Dot.
  /// </summary>
  [XmlEnum("dashDot")]
  DashDot,
  
  /// <summary>
  /// Large Dash Dot.
  /// </summary>
  [XmlEnum("lgDashDot")]
  LargeDashDot,
  
  /// <summary>
  /// Large Dash Dot Dot.
  /// </summary>
  [XmlEnum("lgDashDotDot")]
  LargeDashDotDot,
  
  /// <summary>
  /// System Dash.
  /// </summary>
  [XmlEnum("sysDash")]
  SystemDash,
  
  /// <summary>
  /// System Dot.
  /// </summary>
  [XmlEnum("sysDot")]
  SystemDot,
  
  /// <summary>
  /// System Dash Dot.
  /// </summary>
  [XmlEnum("sysDashDot")]
  SystemDashDot,
  
  /// <summary>
  /// System Dash Dot Dot.
  /// </summary>
  [XmlEnum("sysDashDotDot")]
  SystemDashDotDot,
  
}
