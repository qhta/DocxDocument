namespace DocumentModel.Drawings;


/// <summary>
///   Preset Line Dash Value
/// </summary>
public enum PresetLineDashKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;solid&quot;.
  /// </summary>
  [EnumString("solid")]
  Solid,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dot&quot;.
  /// </summary>
  [EnumString("dot")]
  Dot,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dash&quot;.
  /// </summary>
  [EnumString("dash")]
  Dash,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lgDash&quot;.
  /// </summary>
  [EnumString("lgDash")]
  LargeDash,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;dashDot&quot;.
  /// </summary>
  [EnumString("dashDot")]
  DashDot,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lgDashDot&quot;.
  /// </summary>
  [EnumString("lgDashDot")]
  LargeDashDot,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lgDashDotDot&quot;.
  /// </summary>
  [EnumString("lgDashDotDot")]
  LargeDashDotDot,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;sysDash&quot;.
  /// </summary>
  [EnumString("sysDash")]
  SystemDash,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;sysDot&quot;.
  /// </summary>
  [EnumString("sysDot")]
  SystemDot,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;sysDashDot&quot;.
  /// </summary>
  [EnumString("sysDashDot")]
  SystemDashDot,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;sysDashDotDot&quot;.
  /// </summary>
  [EnumString("sysDashDotDot")]
  SystemDashDotDot,
  
}
