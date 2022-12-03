namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableOverlapValues enumeration.
/// </summary>
public enum TableOverlapKind
{
  /// <summary>
  /// Floating Table Cannot Overlap.
  /// </summary>
  [XmlEnum("never")]
  Never,
  
  /// <summary>
  /// Floating Table Can Overlap.
  /// </summary>
  [XmlEnum("overlap")]
  Overlap,
  
}
