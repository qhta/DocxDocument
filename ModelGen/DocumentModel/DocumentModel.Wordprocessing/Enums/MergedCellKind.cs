namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MergedCellValues enumeration.
/// </summary>
public enum MergedCellKind
{
  /// <summary>
  /// Continue Merged Region.
  /// </summary>
  [XmlEnum("continue")]
  Continue,
  
  /// <summary>
  /// Start/Restart Merged Region.
  /// </summary>
  [XmlEnum("restart")]
  Restart,
  
}
