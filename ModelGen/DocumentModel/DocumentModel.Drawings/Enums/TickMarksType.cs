namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TickMarksType enumeration.
/// </summary>
public enum TickMarksType
{
  /// <summary>
  /// in.
  /// </summary>
  [XmlEnum("in")]
  In,
  
  /// <summary>
  /// out.
  /// </summary>
  [XmlEnum("out")]
  Out,
  
  /// <summary>
  /// cross.
  /// </summary>
  [XmlEnum("cross")]
  Cross,
  
  /// <summary>
  /// none.
  /// </summary>
  [XmlEnum("none")]
  None,
  
}
