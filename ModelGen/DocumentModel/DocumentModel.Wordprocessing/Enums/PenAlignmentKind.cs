namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PenAlignmentValues enumeration.
/// </summary>
public enum PenAlignmentKind
{
  /// <summary>
  /// ctr.
  /// </summary>
  [XmlEnum("ctr")]
  Center,
  
  /// <summary>
  /// in.
  /// </summary>
  [XmlEnum("in")]
  Inset,
  
}
