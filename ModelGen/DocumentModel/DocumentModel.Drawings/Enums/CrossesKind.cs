namespace DocumentModel.Drawings;

/// <summary>
/// Crosses
/// </summary>
public enum CrossesKind
{
  /// <summary>
  /// Axis Crosses at Zero.
  /// </summary>
  [XmlEnum("autoZero")]
  AutoZero,
  
  /// <summary>
  /// Maximum.
  /// </summary>
  [XmlEnum("max")]
  Maximum,
  
  /// <summary>
  /// Minimum.
  /// </summary>
  [XmlEnum("min")]
  Minimum,
  
}
