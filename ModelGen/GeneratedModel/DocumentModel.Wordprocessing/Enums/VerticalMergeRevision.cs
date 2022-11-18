namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the VerticalMergeRevisionValues enumeration.
/// </summary>
public enum VerticalMergeRevision
{
  /// <summary>
  /// Vertically Merged Cell.
  /// </summary>
  [XmlEnum("cont")]
  Continue,
  
  /// <summary>
  /// Vertically Split Cell.
  /// </summary>
  [XmlEnum("rest")]
  Restart,
  
}
