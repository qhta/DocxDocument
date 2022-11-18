namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the DirectionValues enumeration.
/// </summary>
public enum Direction
{
  /// <summary>
  /// ltr.
  /// </summary>
  [XmlEnum("ltr")]
  Ltr,
  
  /// <summary>
  /// rtl.
  /// </summary>
  [XmlEnum("rtl")]
  Rtl,
  
}
