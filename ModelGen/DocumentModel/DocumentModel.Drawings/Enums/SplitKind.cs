namespace DocumentModel.Drawings;

/// <summary>
/// Split Type
/// </summary>
public enum SplitKind
{
  /// <summary>
  /// Custom Split.
  /// </summary>
  [XmlEnum("cust")]
  Custom,
  
  /// <summary>
  /// Split by Percentage.
  /// </summary>
  [XmlEnum("percent")]
  Percent,
  
  /// <summary>
  /// Split by Position.
  /// </summary>
  [XmlEnum("pos")]
  Position,
  
  /// <summary>
  /// Split by Value.
  /// </summary>
  [XmlEnum("val")]
  Value,
  
}
