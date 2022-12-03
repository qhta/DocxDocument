namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PresetLineDashValues enumeration.
/// </summary>
public enum PresetLineDashKind
{
  /// <summary>
  /// solid.
  /// </summary>
  [XmlEnum("solid")]
  Solid,
  
  /// <summary>
  /// dot.
  /// </summary>
  [XmlEnum("dot")]
  Dot,
  
  /// <summary>
  /// sysDot.
  /// </summary>
  [XmlEnum("sysDot")]
  SysDot,
  
  /// <summary>
  /// dash.
  /// </summary>
  [XmlEnum("dash")]
  Dash,
  
  /// <summary>
  /// sysDash.
  /// </summary>
  [XmlEnum("sysDash")]
  SysDash,
  
  /// <summary>
  /// lgDash.
  /// </summary>
  [XmlEnum("lgDash")]
  LongDash,
  
  /// <summary>
  /// dashDot.
  /// </summary>
  [XmlEnum("dashDot")]
  DashDot,
  
  /// <summary>
  /// sysDashDot.
  /// </summary>
  [XmlEnum("sysDashDot")]
  SystemDashDot,
  
  /// <summary>
  /// lgDashDot.
  /// </summary>
  [XmlEnum("lgDashDot")]
  LongDashDot,
  
  /// <summary>
  /// lgDashDotDot.
  /// </summary>
  [XmlEnum("lgDashDotDot")]
  LongDashDotDot,
  
  /// <summary>
  /// sysDashDotDot.
  /// </summary>
  [XmlEnum("sysDashDotDot")]
  SystemDashDotDot,
  
}
