namespace DocumentModel.Vml;

/// <summary>
/// Callout Angles
/// </summary>
public enum AngleKind
{
  /// <summary>
  /// Any Angle.
  /// </summary>
  [XmlEnum("any")]
  Any,
  
  /// <summary>
  /// 30 degrees.
  /// </summary>
  [XmlEnum("30")]
  Degree30,
  
  /// <summary>
  /// 45 degrees.
  /// </summary>
  [XmlEnum("45")]
  Degree45,
  
  /// <summary>
  /// 60 degrees.
  /// </summary>
  [XmlEnum("60")]
  Degree60,
  
  /// <summary>
  /// 90 degrees.
  /// </summary>
  [XmlEnum("90")]
  Degree90,
  
  /// <summary>
  /// Automatic Angle.
  /// </summary>
  [XmlEnum("auto")]
  Auto,
  
}
