namespace DocumentModel.Drawings;

/// <summary>
/// Alignment Type
/// </summary>
public enum PenAlignmentKind
{
  /// <summary>
  /// Center Alignment.
  /// </summary>
  [XmlEnum("ctr")]
  Center,
  
  /// <summary>
  /// Inset Alignment.
  /// </summary>
  [XmlEnum("in")]
  Insert,
  
}
