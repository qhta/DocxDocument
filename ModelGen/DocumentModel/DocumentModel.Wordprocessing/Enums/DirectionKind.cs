namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the DirectionValues enumeration.
/// </summary>
public enum DirectionKind
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
