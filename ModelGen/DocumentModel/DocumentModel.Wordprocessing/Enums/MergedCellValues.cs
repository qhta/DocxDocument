namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MergedCellValues enumeration.
/// </summary>
public enum MergedCellValues
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
