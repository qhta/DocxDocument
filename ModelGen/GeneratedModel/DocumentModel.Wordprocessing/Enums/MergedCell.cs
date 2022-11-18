namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the MergedCellValues enumeration.
/// </summary>
public enum MergedCell
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
